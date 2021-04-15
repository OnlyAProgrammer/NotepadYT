using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace NotepadYT.View
{
    internal sealed partial class Main : Form
    {
        private FontForm fontForm;
        private ColorForm colorForm;
        private string lastpath;

        private string text;

        internal Main()
        {
            InitializeComponent();

            if(Properties.Settings.Default.LastFont != null)
                textBoxText.Font = Properties.Settings.Default.LastFont;

            textBoxText.BackColor = Properties.Settings.Default.BackColor;
            textBoxText.ForeColor = Properties.Settings.Default.ForeColor;
        }

        private void SetTitle(string filename)
        {
            Text = $"NotepadYT - {filename}";
        }

        private void AbrirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.DefaultExt = ".txt";
            openFileDialog1.Filter = "Text files(*.txt)|*.txt";

            var result = openFileDialog1.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                lastpath = openFileDialog1.FileName;

                SetTitle(Data.DataController.ExtractName(lastpath));
                textBoxText.Text = Data.DataController.Read(lastpath);
                text = textBoxText.Text;
            }
        }

        private void SalvarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (File.Exists(lastpath)) // Salva o texto em um arquivo existente
            {
                Data.DataController.Write(lastpath, textBoxText.Text);
                text = textBoxText.Text;
            }
            else // Salva o texto em um novo arquivo
            {
                saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
                var result = saveFileDialog1.ShowDialog();

                if (result.Equals(DialogResult.OK))
                {
                    lastpath = saveFileDialog1.FileName;
                    Data.DataController.Write(lastpath, textBoxText.Text);
                    SetTitle(Data.DataController.ExtractName(lastpath));
                    text = textBoxText.Text;
                }
            }
        }

        private void SalvarComoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Text files(*.txt)|*.txt";
            var result = saveFileDialog1.ShowDialog();

            if (result.Equals(DialogResult.OK))
            {
                lastpath = saveFileDialog1.FileName;
                Data.DataController.Write(lastpath, textBoxText.Text);
                SetTitle(Data.DataController.ExtractName(lastpath));
                text = textBoxText.Text;
            }
        }

        private void SairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBoxText.Text != text)
            {
                if (MessageBox.Show("Deseja salvar o texto antes de desligar ?", "Salvar?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    SalvarToolStripMenuItem_Click(sender, e);
                }
            }

            Application.Exit();
        }

        private void FonteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (fontForm != null)
            {
                fontForm.Dispose();
                fontForm.Close();
                fontForm = null;
            }

            fontForm = new FontForm(textBoxText.Font);
            fontForm.FontUpdated += UpdateFont;
            fontForm.Show();
        }

        private void UpdateFont(Font font)
        {
            textBoxText.Font = font;
            Properties.Settings.Default.LastFont = font;
            Properties.Settings.Default.Save();
        }

        private void CoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorForm != null)
            {
                colorForm.Dispose();
                colorForm.Close();
                colorForm = null;
            }

            colorForm = new ColorForm(textBoxText.BackColor, textBoxText.ForeColor);
            colorForm.ColorUpdated += ColorUpdated;
            colorForm.Show();
        }

        private void ColorUpdated(Color backcolor, Color forecolor)
        {
            textBoxText.BackColor = backcolor;
            textBoxText.ForeColor = forecolor;

            Properties.Settings.Default.BackColor = backcolor;
            Properties.Settings.Default.ForeColor = forecolor;
            Properties.Settings.Default.Save();
        }

        private void SobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("NotepadYT, notepad personalizado tutorial yt", "da like", MessageBoxButtons.OK);
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            SairToolStripMenuItem_Click(sender, new EventArgs());
        }
    }
}
