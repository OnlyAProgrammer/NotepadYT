using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.ListView;

namespace NotepadYT.View
{
    internal sealed partial class FontForm : Form
    {
        internal FontForm(Font theFont)
        {
            InitializeComponent();
            TheFont = theFont;
            var fonts = new InstalledFontCollection();

            for (int i = 0; i < fonts.Families.Length; i++)
            {
                listViewFonts.Items.Add(fonts.Families[i].Name);
            }
            listViewStyles.Items.Add(Enum.GetName(typeof(FontStyle), FontStyle.Regular));
            listViewStyles.Items.Add(Enum.GetName(typeof(FontStyle), FontStyle.Bold));
            listViewStyles.Items.Add(Enum.GetName(typeof(FontStyle), FontStyle.Italic));
            listViewStyles.Items.Add(Enum.GetName(typeof(FontStyle), FontStyle.Underline));

            Fonts = listViewFonts.Items;
            Styles = listViewStyles.Items;
            numericUpDown1.Value = (decimal) theFont.Size;

            UpdateAmostra();
        }

        private Font TheFont { get; set;}
        private ListViewItemCollection Fonts { get; }
        private ListViewItemCollection Styles { get; }
        private ListViewItemCollection Sizes { get; }

        internal delegate void UpdateFont(Font font);
        internal event UpdateFont FontUpdated;

        private void UpdateAmostra()
        {
            labelAmostra.Font = TheFont;
        }

        // Seleciona font family
        private void ListViewFonts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFonts.SelectedItems.Count <= 0)
                return;

            var name = listViewFonts.SelectedItems[0].Text;
            var style = TheFont.Style;
            var size = TheFont.Size;

            TheFont = new Font(name, size, style);
            UpdateAmostra();
        }

        private void ListViewStyles_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewStyles.SelectedItems.Count <= 0)
                return;

            var name = TheFont.FontFamily;
            var style = listViewStyles.SelectedItems[0].Text;
            var size = TheFont.Size;

            TheFont = new Font(name, size, (FontStyle)Enum.Parse(typeof(FontStyle), style));
            UpdateAmostra();
        }

        private void ListViewSizes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewFonts.SelectedItems.Count <= 0)
                return;

            var name = TheFont.FontFamily;
            var style = TheFont.Style;
            var size = (float) numericUpDown1.Value;
            
            TheFont = new Font(name, size, style);
            UpdateAmostra();
        }

        private void UpdateFontView(object sender, EventArgs e)
        {
            var text = textBoxFont.Text;
            var fonts = new InstalledFontCollection();

            listViewFonts.Items.Clear();
            for (int i = 0; i < fonts.Families.Length; i++)
            {
                var fontname = fonts.Families[i].Name.ToLower();

                if (fontname.Contains(text) || fontname.Equals(text))
                    listViewFonts.Items.Add(fonts.Families[i].Name);
            }

            if (listViewFonts.Items.Count == 0)
            {
                for (int i = 0; i < fonts.Families.Length; i++)
                {
                    listViewFonts.Items.Add(fonts.Families[i].Name);
                }
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            string name;
            string style;
            float size = (float) numericUpDown1.Value;

            if (listViewFonts.SelectedItems.Count <= 0)
                name = TheFont.FontFamily.Name;
            else
                name = listViewFonts.SelectedItems[0].Text;

            if (listViewStyles.SelectedItems.Count <= 0)
                style = TheFont.Style.ToString();
            else
                style = listViewStyles.SelectedItems[0].Text;

            TheFont = new Font(name, size, (FontStyle)Enum.Parse(typeof(FontStyle), style));
            FontUpdated?.Invoke(TheFont);
            Close();
        }
    }
}
