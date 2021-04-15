
namespace NotepadYT.View
{
    internal sealed partial class FontForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxFont = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.listViewFonts = new System.Windows.Forms.ListView();
            this.listViewStyles = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelAmostra = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxFont
            // 
            this.textBoxFont.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxFont.Location = new System.Drawing.Point(44, 39);
            this.textBoxFont.Margin = new System.Windows.Forms.Padding(2);
            this.textBoxFont.Name = "textBoxFont";
            this.textBoxFont.Size = new System.Drawing.Size(164, 27);
            this.textBoxFont.TabIndex = 0;
            this.textBoxFont.TextChanged += new System.EventHandler(this.UpdateFontView);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fonte:";
            // 
            // listViewFonts
            // 
            this.listViewFonts.AutoArrange = false;
            this.listViewFonts.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.None;
            this.listViewFonts.HideSelection = false;
            this.listViewFonts.Location = new System.Drawing.Point(44, 70);
            this.listViewFonts.Margin = new System.Windows.Forms.Padding(2);
            this.listViewFonts.MultiSelect = false;
            this.listViewFonts.Name = "listViewFonts";
            this.listViewFonts.Size = new System.Drawing.Size(164, 139);
            this.listViewFonts.TabIndex = 2;
            this.listViewFonts.UseCompatibleStateImageBehavior = false;
            this.listViewFonts.View = System.Windows.Forms.View.List;
            this.listViewFonts.SelectedIndexChanged += new System.EventHandler(this.ListViewFonts_SelectedIndexChanged);
            // 
            // listViewStyles
            // 
            this.listViewStyles.AutoArrange = false;
            this.listViewStyles.HideSelection = false;
            this.listViewStyles.Location = new System.Drawing.Point(221, 39);
            this.listViewStyles.Margin = new System.Windows.Forms.Padding(2);
            this.listViewStyles.MultiSelect = false;
            this.listViewStyles.Name = "listViewStyles";
            this.listViewStyles.Size = new System.Drawing.Size(126, 170);
            this.listViewStyles.TabIndex = 5;
            this.listViewStyles.UseCompatibleStateImageBehavior = false;
            this.listViewStyles.View = System.Windows.Forms.View.List;
            this.listViewStyles.SelectedIndexChanged += new System.EventHandler(this.ListViewStyles_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 20);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Estilo da fonte:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(365, 20);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Tamanho:";
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "Exemplo:";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.labelAmostra);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(44, 225);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(187, 82);
            this.panel1.TabIndex = 10;
            // 
            // labelAmostra
            // 
            this.labelAmostra.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelAmostra.Location = new System.Drawing.Point(0, 19);
            this.labelAmostra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAmostra.Name = "labelAmostra";
            this.labelAmostra.Size = new System.Drawing.Size(185, 61);
            this.labelAmostra.TabIndex = 10;
            this.labelAmostra.Text = "AaBbYyZz";
            this.labelAmostra.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(358, 318);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(368, 36);
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(52, 26);
            this.numericUpDown1.TabIndex = 12;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // FontForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 366);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.listViewStyles);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listViewFonts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxFont);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 405);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 405);
            this.Name = "FontForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fontes";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listViewFonts;
        private System.Windows.Forms.ListView listViewStyles;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelAmostra;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}