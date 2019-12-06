namespace LatvanyossagokApplication
{
    partial class Form1
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
            this.listBox_varosok = new System.Windows.Forms.ListBox();
            this.label_varoshozzad = new System.Windows.Forms.Label();
            this.textBox_varosHozzaAd = new System.Windows.Forms.TextBox();
            this.numericUpDown_lakossagHozzaAd = new System.Windows.Forms.NumericUpDown();
            this.label_lakossag = new System.Windows.Forms.Label();
            this.button_hozzaAd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakossagHozzaAd)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_varosok
            // 
            this.listBox_varosok.FormattingEnabled = true;
            this.listBox_varosok.Location = new System.Drawing.Point(12, 12);
            this.listBox_varosok.Name = "listBox_varosok";
            this.listBox_varosok.Size = new System.Drawing.Size(120, 95);
            this.listBox_varosok.TabIndex = 0;
            // 
            // label_varoshozzad
            // 
            this.label_varoshozzad.AutoSize = true;
            this.label_varoshozzad.Location = new System.Drawing.Point(9, 110);
            this.label_varoshozzad.Name = "label_varoshozzad";
            this.label_varoshozzad.Size = new System.Drawing.Size(141, 13);
            this.label_varoshozzad.TabIndex = 1;
            this.label_varoshozzad.Text = "Kérem adjon meg egy várost";
            // 
            // textBox_varosHozzaAd
            // 
            this.textBox_varosHozzaAd.Location = new System.Drawing.Point(12, 126);
            this.textBox_varosHozzaAd.Name = "textBox_varosHozzaAd";
            this.textBox_varosHozzaAd.Size = new System.Drawing.Size(120, 20);
            this.textBox_varosHozzaAd.TabIndex = 2;
            // 
            // numericUpDown_lakossagHozzaAd
            // 
            this.numericUpDown_lakossagHozzaAd.Location = new System.Drawing.Point(12, 165);
            this.numericUpDown_lakossagHozzaAd.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_lakossagHozzaAd.Name = "numericUpDown_lakossagHozzaAd";
            this.numericUpDown_lakossagHozzaAd.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown_lakossagHozzaAd.TabIndex = 3;
            // 
            // label_lakossag
            // 
            this.label_lakossag.AutoSize = true;
            this.label_lakossag.Location = new System.Drawing.Point(9, 149);
            this.label_lakossag.Name = "label_lakossag";
            this.label_lakossag.Size = new System.Drawing.Size(173, 13);
            this.label_lakossag.TabIndex = 4;
            this.label_lakossag.Text = "Kérem adja meg a lakosság számát";
            // 
            // button_hozzaAd
            // 
            this.button_hozzaAd.Location = new System.Drawing.Point(32, 191);
            this.button_hozzaAd.Name = "button_hozzaAd";
            this.button_hozzaAd.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaAd.TabIndex = 5;
            this.button_hozzaAd.Text = "Hozzá ad";
            this.button_hozzaAd.UseVisualStyleBackColor = true;
            this.button_hozzaAd.Click += new System.EventHandler(this.button_hozzaAd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 329);
            this.Controls.Add(this.button_hozzaAd);
            this.Controls.Add(this.label_lakossag);
            this.Controls.Add(this.numericUpDown_lakossagHozzaAd);
            this.Controls.Add(this.textBox_varosHozzaAd);
            this.Controls.Add(this.label_varoshozzad);
            this.Controls.Add(this.listBox_varosok);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakossagHozzaAd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_varosok;
        private System.Windows.Forms.Label label_varoshozzad;
        private System.Windows.Forms.TextBox textBox_varosHozzaAd;
        private System.Windows.Forms.NumericUpDown numericUpDown_lakossagHozzaAd;
        private System.Windows.Forms.Label label_lakossag;
        private System.Windows.Forms.Button button_hozzaAd;
    }
}

