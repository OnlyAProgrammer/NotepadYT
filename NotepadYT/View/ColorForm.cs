using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace NotepadYT.View
{
    internal sealed partial class ColorForm : Form
    {
        private readonly Dictionary<string, Color[]> temas = new Dictionary<string, Color[]>
        {
            {"Padrão", new Color[]{ Color.White, Color.Black } },
            {"Escuro", new Color[]{ Color.Black, Color.White } },
        };

        internal ColorForm(Color backcolor, Color forecolor)
        {
            InitializeComponent();

            foreach (var vk in temas)
            {
                comboBox1.Items.Add(vk.Key);
            }

            if (comboBox1.Items.Count > 0)
                comboBox1.SelectedIndex = 0;
            Backcolor = backcolor;
            Forecolor = forecolor;
        }

        internal delegate void UpdateColors(Color backcolor, Color forecolor);
        internal event UpdateColors ColorUpdated;

        internal Color Backcolor { get; set; }
        internal Color Forecolor { get; set; }

        private void ButtonSelectBackColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Backcolor = colorDialog1.Color;
                Send();
            }
        }

        private void ButtonSelectForeColor_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Forecolor = colorDialog1.Color;
                Send();
            }
        }

        private void ButtonApply_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null) return;

            if (comboBox1.SelectedIndex > comboBox1.Items.Count) return;

            var tema = comboBox1.Items[comboBox1.SelectedIndex].ToString();

            var colors = temas[tema];

            Backcolor = colors[0];
            Forecolor = colors[1];
            Send();
        }

        private void Send() => ColorUpdated?.Invoke(Backcolor, Forecolor);

        private void Button1_Click(object sender, EventArgs e) => Close();
    }
}
