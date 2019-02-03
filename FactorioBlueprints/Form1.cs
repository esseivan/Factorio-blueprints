using System;
using System.IO;
using System.IO.Compression;
using System.Text;
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
                dataVersion = '0';

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
        }
    }
}