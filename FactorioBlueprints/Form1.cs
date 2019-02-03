using System;
using System.IO;
using System.Windows.Forms;

//https://wiki.factorio.com/Blueprint_string_format

namespace FactorioBlueprints
{
    public partial class Form1 : Form
    {
        private string currentPath = string.Empty;
        private string dataPath = string.Empty;
        private string tempPath = string.Empty;
        private char dataVersion = '0';
        private Belts dest = Belts.None;
        private bool fastMode = false;

        private string name_belt = "transport-belt",
            name_undeground = "underground-belt",
            name_splitter = "splitter",
            name_1 = "",
            name_2 = "fast-",
            name_3 = "express-",
            data_around = "\"name\":\"{0}\"";

        public Form1()
        {
            InitializeComponent();
        }

        private string Decode(string encoded)
        {
            dataVersion = encoded[0];
            return Ionic.Zlib.ZlibStream.UncompressString(Convert.FromBase64String(encoded.Remove(0, 1)));
        }

        private string Encode(string decoded)
        {
            if (!(dataVersion >= '0' && dataVersion <= '9'))
            {
                dataVersion = '0';
            }

            return dataVersion + Convert.ToBase64String(Ionic.Zlib.ZlibStream.CompressString(decoded));
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
            toolStripMenuItem5.Checked = toolStripMenuItem6.Checked = false;
            toolStripMenuItem7.Checked = true;
            dest = Belts.B3;
        }

        private void ConvertBelts(Belts source, Belts dest)
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
            //    }
            //}

            if (source > (Belts.B1 | Belts.B2 | Belts.B3) || source <= 0)
            {
                showMessage("No source selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


            string searchString = string.Empty,
            replaceString = string.Empty,
            searchStringName = string.Empty,
            replaceStringName = string.Empty;

            switch (dest)
            {
                case Belts.B1:
                    replaceStringName = name_1;
                    break;
                case Belts.B2:
                    replaceStringName = name_2;
                    break;
                case Belts.B3:
                    replaceStringName = name_3;
                    break;
                default:
                    showMessage("No replacement selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    break;
            }

            if ((source & Belts.B1) != 0 && dest != Belts.B1)
            {
                ReplaceBelts(name_1, replaceStringName);
            }
            if ((source & Belts.B2) != 0 && dest != Belts.B2)
            {
                ReplaceBelts(name_2, replaceStringName);
            }
            if ((source & Belts.B3) != 0 && dest != Belts.B3)
            {
                ReplaceBelts(name_3, replaceStringName);
            }

            txtEncoded.Text = Encode(txtDecoded.Text);

            Clipboard.SetText(txtEncoded.Text);
            showMessage("Complete !\nEncoded data has been copied to clipboard", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void showMessage(string message, string title, MessageBoxButtons button, MessageBoxIcon icon)
        {
            if(!fastMode)
            {
                MessageBox.Show(message, title, button, icon);
            }
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

            if(fastMode)
            {
                runToolStripMenuItem.PerformClick();
            }
        }

        private void fastModeToolStripMenuItem_CheckedChanged(object sender, EventArgs e)
        {
            fastMode = fastModeToolStripMenuItem.Checked;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            convertBeltTypeToolStripMenuItem.ShowDropDown();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem5.Checked)
            {
                toolStripMenuItem6.Checked = toolStripMenuItem7.Checked = false;
                dest = Belts.B1;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem6.Checked)
            {
                toolStripMenuItem5.Checked = toolStripMenuItem7.Checked = false;
                dest = Belts.B2;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
        }

        private void toolStripMenuItem7_Click(object sender, EventArgs e)
        {
            if (toolStripMenuItem7.Checked)
            {
                toolStripMenuItem5.Checked = toolStripMenuItem6.Checked = false;
                dest = Belts.B3;
                convertBeltTypeToolStripMenuItem.ShowDropDown();
            }
        }

        private enum Belts
        {
            None = 0b000,
            B1 = 0b001,
            B2 = 0b010,
            B3 = 0b100,
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Belts source = Belts.None;
            if (toolStripMenuItem2.Checked)
            {
                source |= Belts.B1;
            }

            if (toolStripMenuItem3.Checked)
            {
                source |= Belts.B2;
            }

            if (toolStripMenuItem4.Checked)
            {
                source |= Belts.B3;
            }

            ConvertBelts(source, dest);
        }
    }
}