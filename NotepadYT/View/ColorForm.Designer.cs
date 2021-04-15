
namespace NotepadYT.View
{
    internal sealed partial class ColorForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSelectBackColor = new System.Windows.Forms.Button();
            this.buttonSelectForeColor = new System.Windows.Forms.Button();
            this.buttonApply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 202);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 32);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sair";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(207, 126);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(113, 28);
            this.comboBox1.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 13;
            this.label1.Text = "Cor do fundo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 14;
            this.label2.Text = "Cor do texto:";
            // 
            // buttonSelectBackColor
            // 
            this.buttonSelectBackColor.Location = new System.Drawing.Point(171, 36);
            this.buttonSelectBackColor.Name = "buttonSelectBackColor";
            this.buttonSelectBackColor.Size = new System.Drawing.Size(100, 29);
            this.buttonSelectBackColor.TabIndex = 15;
            this.buttonSelectBackColor.Text = "Selecionar";
            this.buttonSelectBackColor.UseVisualStyleBackColor = true;
            this.buttonSelectBackColor.Click += new System.EventHandler(this.ButtonSelectBackColor_Click);
            // 
            // buttonSelectForeColor
            // 
            this.buttonSelectForeColor.Location = new System.Drawing.Point(171, 80);
            this.buttonSelectForeColor.Name = "buttonSelectForeColor";
            this.buttonSelectForeColor.Size = new System.Drawing.Size(100, 29);
            this.buttonSelectForeColor.TabIndex = 16;
            this.buttonSelectForeColor.Text = "Selecionar";
            this.buttonSelectForeColor.UseVisualStyleBackColor = true;
            this.buttonSelectForeColor.Click += new System.EventHandler(this.ButtonSelectForeColor_Click);
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(336, 125);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(100, 29);
            this.buttonApply.TabIndex = 17;
            this.buttonApply.Text = "Aplicar";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.ButtonApply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(44, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Temas predefinidos";
            // 
            // ColorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(459, 267);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.buttonSelectForeColor);
            this.Controls.Add(this.buttonSelectBackColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(475, 306);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(475, 306);
            this.Name = "ColorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Fontes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonSelectBackColor;
        private System.Windows.Forms.Button buttonSelectForeColor;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.Label label3;
    }
}