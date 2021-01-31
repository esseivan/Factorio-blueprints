using EsseivaN.Tools;
using System;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

//https://wiki.factorio.com/Blueprint_string_format

namespace BlueprintLibrary
{
    public partial class Form1 : Form
    {
        private string currentPath = string.Empty;
        private string dataPath = string.Empty;
        private string tempPath = string.Empty;
        private char dataVersion = '0';
        private Level dest_belt = Level.None;
        private Level dest_inserter = Level.None;
        private bool fastMode = false;
        private bool expressMode = false;
        private bool beltEnabled = false;
        private bool inserterEnabled = false;
        private SettingsManager<Settings> settingsManager = new SettingsManager<Settings>(getSettingName);
        private string settingsPath = string.Empty;
        private Flags flags = new Flags();
        private const int flags_start_mode = 0,
            flags_count_mode = 2,
            flags_start_belt_mode = 3,
            flags_count_belt_mode = 7,
            flags_start_inserter_mode = 11,
            flags_count_inserter_mode = 7;

        public enum SettingNames
        {
            Mode = 1,
            BeltConverterMode = 10,
            InserterConverterMode = 11,
        };

        private string name_belt = "transport-belt",
            name_undeground = "underground-belt",
            name_splitter = "splitter",
            name_inserter = "inserter",
            belt_name_1 = "",
            belt_name_2 = "fast-",
            belt_name_3 = "express-",
            inserter_name_1 = "",
            inserter_name_2 = "fast-",
            inserter_name_3 = "stack-",
            data_around = "\"name\":\"{0}\"";

        public Form1()
        {
            InitializeComponent();
        }

        public static string getSettingName(Settings setting)
        {
            return getSettingName(setting.index);
        }

        public static string getSettingName(int index)
        {
            return ((SettingNames)index).ToString();
        }

        public string getSettingName(SettingNames settingName)
        {
            return settingName.ToString();
        }

        private string Decode(string encoded)
        {
            try
            {
                dataVersion = encoded[0];
                return Zlib.ZlibStream.UncompressString(Convert.FromBase64String(encoded.Remove(0, 1)));
            }
            catch (Exception ex)
            {
                showMessage("Invalid data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }

        private string Encode(string decoded)
        {
            try
            {
                if (!(dataVersion >= '0' && dataVersion <= '9'))
                {
                    dataVersion = '0';
                }

                return dataVersion + Convert.ToBase64String(Ionic.Zlib.ZlibStream.CompressString(decoded));
            }
            catch (Exception ex)
            {
                showMessage("Invalid data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "-1";
            }
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (File.Exists(openFileDialog1.FileName))
                {
                    string content = File.ReadAllText(openFileDialog1.FileName);
                    txtEncoded.Text = content;
                    txtDecoded.Text = string.Empty;
                }
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (txtEncoded.Text == string.Empty && txtDecoded.Text == string.Empty)
            {
                showMessage("No data to save !", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (txtEncoded.Text == string.Empty)
                {
                    txtEncoded.Text = Encode(txtDecoded.Text);
                }

                File.WriteAllText(saveFileDialog1.FileName, txtEncoded.Text);
            }
        }

        private void encodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtEncoded.Text = Encode(txtDecoded.Text);
        }

        private void decodeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtDecoded.Text = Decode(txtEncoded.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            settingsPath = $"{Environment.CurrentDirectory}\\config.cfg";
            if (!File.Exists(settingsPath))
            {
                ResetConfig();
            }
            else
            {
                settingsManager.load(settingsPath);
            }

            if (settingsManager.count != 3)
            {
                ResetConfig();
            }

            try
            {
                UpdateFlagsFromSettings();
                UpdateFromFlags();
            }
            catch (Exception ex)
            {
                ResetConfig();
                UpdateFlagsFromSettings();
                UpdateFromFlags();
            }

            dest_belt = Level.B3;
        }

        private void UpdateSettings()
        {
            UpdateFlags();
            settingsManager.getSetting(getSettingName(SettingNames.Mode)).data_int = flags.getBits(flags_start_mode, flags_count_mode);
            settingsManager.getSetting(getSettingName(SettingNames.BeltConverterMode)).data_int = flags.getBits(flags_start_belt_mode, flags_count_belt_mode);
            settingsManager.getSetting(getSettingName(SettingNames.InserterConverterMode)).data_int = flags.getBits(flags_start_inserter_mode, flags_count_inserter_mode);
        }

        private void UpdateFlagsFromSettings()
        {
            flags.setBits(flags_start_mode, flags_count_mode, settingsManager.getSetting(getSettingName(SettingNames.Mode)).data_int);
            flags.setBits(flags_start_belt_mode, flags_count_belt_mode, settingsManager.getSetting(getSettingName(SettingNames.BeltConverterMode)).data_int);
            flags.setBits(flags_start_inserter_mode, flags_count_inserter_mode, settingsManager.getSetting(getSettingName(SettingNames.InserterConverterMode)).data_int);
        }

        private void UpdateFlags()
        {
            flags.setBit(flags_start_mode + 0, fastMode);
            flags.setBit(flags_start_mode + 1, expressMode);

            flags.setBit(flags_start_belt_mode + 0, enabledToolStripMenuItem.Checked);
            flags.setBit(flags_start_belt_mode + 1, tsmF1.Checked);
            flags.setBit(flags_start_belt_mode + 2, tsmF2.Checked);
            flags.setBit(flags_start_belt_mode + 3, tsmF3.Checked);
            flags.setBit(flags_start_belt_mode + 4, tsmT1.Checked);
            flags.setBit(flags_start_belt_mode + 5, tsmT2.Checked);
            flags.setBit(flags_start_belt_mode + 6, tsmT3.Checked);

            flags.setBit(flags_start_inserter_mode + 0, enabledToolStripMenuItem1.Checked);
            flags.setBit(flags_start_inserter_mode + 1, tsmIF1.Checked);
            flags.setBit(flags_start_inserter_mode + 2, tsmIF2.Checked);
            flags.setBit(flags_start_inserter_mode + 3, tsmIF3.Checked);
            flags.setBit(flags_start_inserter_mode + 4, tsmIT1.Checked);
            flags.setBit(flags_start_inserter_mode + 5, tsmIT2.Checked);
            flags.setBit(flags_start_inserter_mode + 6, tsmIT3.Checked);
        }

        private void UpdateFromFlags()
        {
            fastMode = fastModeToolStripMenuItem.Checked = flags.getBit(flags_start_mode + 0);
            expressMode = expressModeToolStripMenuItem.Checked = flags.getBit(flags_start_mode + 1);

            enabledToolStripMenuItem.Checked = flags.getBit(flags_start_belt_mode + 0);
            tsmF1.Checked = flags.getBit(flags_start_belt_mode + 1);
            tsmF2.Checked = flags.getBit(flags_start_belt_mode + 2);
            tsmF3.Checked = flags.getBit(flags_start_belt_mode + 3);
            tsmT1.Checked = flags.getBit(flags_start_belt_mode + 4);
            tsmT2.Checked = flags.getBit(flags_start_belt_mode + 5);
            tsmT3.Checked = flags.getBit(flags_start_belt_mode + 6);

            enabledToolStripMenuItem1.Checked = flags.getBit(flags_start_inserter_mode + 0);
            tsmIF1.Checked = flags.getBit(flags_start_inserter_mode + 1);
            tsmIF2.Checked = flags.getBit(flags_start_inserter_mode + 2);
            tsmIF3.Checked = flags.getBit(flags_start_inserter_mode + 3);
            tsmIT1.Checked = flags.getBit(flags_start_inserter_mode + 4);
            tsmIT2.Checked = flags.getBit(flags_start_inserter_mode + 5);
            tsmIT3.Checked = flags.getBit(flags_start_inserter_mode + 6);
        }

        private void ResetConfig()
        {   // Settings not existing, creating new one
            File.WriteAllText(settingsPath, "{}");
            settingsManager.load(settingsPath);
            flags.setBits(flags_start_mode, flags_count_mode, 0b00);
            flags.setBits(flags_start_belt_mode, flags_count_belt_mode, 0b1001111);
            flags.setBits(flags_start_inserter_mode, flags_count_inserter_mode, 0b1001111);

            settingsManager.addSetting(new Settings()
            { // Mode
                index = 1,
                data_int = flags.getBits(flags_start_mode, flags_count_mode),
            });
            settingsManager.addSetting(new Settings()
            { // BeltConverterMode
                index = 10,
                data_int = flags.getBits(flags_start_belt_mode, flags_count_belt_mode),
            });
            settingsManager.addSetting(new Settings()
            { // InserterConverterMode
                index = 11,
                data_int = flags.getBits(flags_start_inserter_mode, flags_count_inserter_mode),
            });
            settingsManager.save(settingsPath);
        }

        private void ConvertInserter(Level source, Level dest)
        {
            //if (txtDecoded.Text == string.Empty)
            //{
            //    if (txtEncoded.Text == string.Empty)
            //    {
            //        showMessage("No data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //    {
            txtDecoded.Text = Decode(txtEncoded.Text);
            if (txtDecoded.Text == "-1")
            {
                return;
            }
            //    }
            //}

            if (source > (Level.B1 | Level.B2 | Level.B3) || source <= 0)
            {
                showMessage("No source selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string searchString = string.Empty,
            replaceString = string.Empty,
            searchStringName = string.Empty,
            replaceStringName = string.Empty;

            switch (dest)
            {
                case Level.B1:
                    replaceStringName = inserter_name_1;
                    break;
                case Level.B2:
                    replaceStringName = inserter_name_2;
                    break;
                case Level.B3:
                    replaceStringName = inserter_name_3;
                    break;
                default:
                    showMessage("No replacement selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if ((source & Level.B1) != 0 && dest != Level.B1)
            {
                ReplaceInserters(inserter_name_1, replaceStringName);
            }
            if ((source & Level.B2) != 0 && dest != Level.B2)
            {
                ReplaceInserters(inserter_name_2, replaceStringName);
            }
            if ((source & Level.B3) != 0 && dest != Level.B3)
            {
                ReplaceInserters(inserter_name_3, replaceStringName);
            }

            txtEncoded.Text = Encode(txtDecoded.Text);

            if (txtEncoded.Text == "-1")
            {
                return;
            }
        }

        private void ConvertBelts(Level source, Level dest)
        {
            //if (txtDecoded.Text == string.Empty)
            //{
            //    if (txtEncoded.Text == string.Empty)
            //    {
            //        showMessage("No data !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }
            //    else
            //    {
            txtDecoded.Text = Decode(txtEncoded.Text);
            if (txtDecoded.Text == "-1")
            {
                return;
            }
            //    }
            //}

            if (source > (Level.B1 | Level.B2 | Level.B3) || source <= 0)
            {
                showMessage("No source selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            string searchString = string.Empty,
            replaceString = string.Empty,
            searchStringName = string.Empty,
            replaceStringName = string.Empty;

            switch (dest)
            {
                case Level.B1:
                    replaceStringName = belt_name_1;
                    break;
                case Level.B2:
                    replaceStringName = belt_name_2;
                    break;
                case Level.B3:
                    replaceStringName = belt_name_3;
                    break;
                default:
                    showMessage("No replacement selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
            }

            if ((source & Level.B1) != 0 && dest != Level.B1)
            {
                ReplaceBelts(belt_name_1, replaceStringName);
            }
            if ((source & Level.B2) != 0 && dest != Level.B2)
            {
                ReplaceBelts(belt_name_2, replaceStringName);
            }
            if ((source & Level.B3) != 0 && dest != Level.B3)
            {
                ReplaceBelts(belt_name_3, replaceStringName);
            }

            txtEncoded.Text = Encode(txtDecoded.Text);

            if (txtEncoded.Text == "-1")
            {
                return;
            }
        }

        private void CopyToClipboard()
        {
            Clipboard.SetText(txtEncoded.Text);
        }

        private void showMessage(string message, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            if (!fastMode && !expressMode)
            {
                MessageBox.Show(message, title, button, icon);
            }
        }

        private void ReplaceInserters(string searchName, string destName)
        {
            txtDecoded.Text = txtDecoded.Text.Replace(
                string.Format(data_around, $"{searchName}{name_inserter}"),
                string.Format(data_around, $"{destName}{name_inserter}"));
        }

        private void ReplaceBelts(string searchName, string destName)
        {
            txtDecoded.Text = txtDecoded.Text.Replace(
                string.Format(data_around, $"{searchName}{name_belt}"),
                string.Format(data_around, $"{destName}{name_belt}"))
                .Replace(
                string.Format(data_around, $"{searchName}{name_undeground}"),
                string.Format(data_around, $"{destName}{name_undeground}"))
                .Replace(
                string.Format(data_around, $"{searchName}{name_splitter}"),
                string.Format(data_around, $"{destName}{name_splitter}"));
        }

        private void Form1_Enter(object sender, EventArgs e)
        {
            if (txtEncoded.Text == string.Empty || fastMode)
            {
                txtEncoded.Text = Clipboard.GetText();
                txtDecoded.Text = string.Empty;
            }

            if (fastMode)
            {
                RunAutoConverter();
            }
        }

        private void fastModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastMode = fastModeToolStripMenuItem.Checked;
            expressMode = expressModeToolStripMenuItem.Checked = false;
        }

        private void runToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RunInserterConverter();
        }

        private void tsmIT3_Click(object sender, EventArgs e)
        {
            if (tsmIT3.Checked)
            {
                tsmIT1.Checked = tsmIT2.Checked = false;
                dest_inserter = Level.B3;
                convertInserterTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_inserter = Level.None;
            }
        }

        private void enabledToolStripMenuItem_Click(object sender, EventArgs e)
        {
            beltEnabled = enabledToolStripMenuItem.Checked;
        }

        private void enabledToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            inserterEnabled = enabledToolStripMenuItem1.Checked;
        }

        private void tsmIT2_Click(object sender, EventArgs e)
        {
            if (tsmIT2.Checked)
            {
                tsmIT1.Checked = tsmIT3.Checked = false;
                dest_inserter = Level.B2;
                convertInserterTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_inserter = Level.None;
            }
        }

        private void tsmIT1_Click(object sender, EventArgs e)
        {
            if (tsmIT1.Checked)
            {
                tsmIT2.Checked = tsmIT3.Checked = false;
                dest_inserter = Level.B1;
                convertInserterTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_inserter = Level.None;
            }
        }

        private void tsmIF2_Click(object sender, EventArgs e)
        {
            convertInserterTypeToolStripMenuItem.ShowDropDown();
        }

        private void expressModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fastMode = fastModeToolStripMenuItem.Checked = false;
            expressMode = expressModeToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            convertBeltTypeToolStripMenuItem.ShowDropDown();
        }

        private void clipboardMonitor1_ClipboardChanged(object sender, ClipboardChangedEventArgs e)
        {
            if (expressMode)
            {
                clipboardMonitor1.ClipboardChanged -= clipboardMonitor1_ClipboardChanged;
                txtEncoded.Text = Clipboard.GetText();
                txtDecoded.Text = string.Empty;
                RunAutoConverter();
                EnableEvent();
            }
        }
        private async void EnableEvent()
        {
            await Task.Delay(500);
            clipboardMonitor1.ClipboardChanged += clipboardMonitor1_ClipboardChanged;
            Console.WriteLine("Event enabled");
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (tsmT1.Checked)
            {
                tsmT2.Checked = tsmT3.Checked = false;
                dest_belt = Level.B1;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_belt = Level.None;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            UpdateSettings();
            settingsManager.save(settingsPath);
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (tsmT2.Checked)
            {
                tsmT1.Checked = tsmT3.Checked = false;
                dest_belt = Level.B2;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_belt = Level.None;
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (tsmT3.Checked)
            {
                tsmT1.Checked = tsmT2.Checked = false;
                dest_belt = Level.B3;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
            else
            {
                dest_belt = Level.None;
            }
        }

        private enum Level
        {
            None = 0b000,
            B1 = 0b001,
            B2 = 0b010,
            B3 = 0b100,
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RunBeltConverter();
        }

        private void RunAutoConverter()
        {
            RunBeltConverter();
            RunInserterConverter();
            CopyToClipboard();
            showMessage("Complete !\nEncoded data has been copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RunBeltConverter()
        {
            Level source = Level.None;
            if (tsmF1.Checked)
            {
                source |= Level.B1;
            }

            if (tsmF2.Checked)
            {
                source |= Level.B2;
            }

            if (tsmF3.Checked)
            {
                source |= Level.B3;
            }

            Console.WriteLine("Running belt converter : " + source.ToString() + " " + dest_belt.ToString());

            ConvertBelts(source, dest_belt);
        }

        private void RunInserterConverter()
        {
            Level source = Level.None;
            if (tsmIF1.Checked)
            {
                source |= Level.B1;
            }

            if (tsmIF2.Checked)
            {
                source |= Level.B2;
            }

            if (tsmIF3.Checked)
            {
                source |= Level.B3;
            }

            Console.WriteLine("Running inserter converter : " + source.ToString() + " " + dest_inserter.ToString());

            ConvertInserter(source, dest_inserter);
        }

        public class Settings
        {
            public int index;
            public int data_int;
            public string data_string;
        }
    }
}