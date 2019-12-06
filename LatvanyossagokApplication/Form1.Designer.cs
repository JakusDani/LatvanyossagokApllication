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
            this.groupBox_varos = new System.Windows.Forms.GroupBox();
            this.groupBox_latvanyossag = new System.Windows.Forms.GroupBox();
            this.label_valaszVaros = new System.Windows.Forms.Label();
            this.label_latvanyosag_nev = new System.Windows.Forms.Label();
            this.textBox_latvanyossagNev = new System.Windows.Forms.TextBox();
            this.label_latvanyossag_leiras = new System.Windows.Forms.Label();
            this.textBox_latvanyossag_leiras = new System.Windows.Forms.TextBox();
            this.label_latvanyossag_ar = new System.Windows.Forms.Label();
            this.numericUpDown_latvanyossag_ar = new System.Windows.Forms.NumericUpDown();
            this.button_latvanyossag_hozaad = new System.Windows.Forms.Button();
            this.button_torles = new System.Windows.Forms.Button();
            this.button_modositas = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakossagHozzaAd)).BeginInit();
            this.groupBox_varos.SuspendLayout();
            this.groupBox_latvanyossag.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latvanyossag_ar)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_varosok
            // 
            this.listBox_varosok.FormattingEnabled = true;
            this.listBox_varosok.Location = new System.Drawing.Point(6, 17);
            this.listBox_varosok.Name = "listBox_varosok";
            this.listBox_varosok.Size = new System.Drawing.Size(210, 173);
            this.listBox_varosok.TabIndex = 0;
            // 
            // label_varoshozzad
            // 
            this.label_varoshozzad.AutoSize = true;
            this.label_varoshozzad.Location = new System.Drawing.Point(6, 16);
            this.label_varoshozzad.Name = "label_varoshozzad";
            this.label_varoshozzad.Size = new System.Drawing.Size(141, 13);
            this.label_varoshozzad.TabIndex = 1;
            this.label_varoshozzad.Text = "Kérem adjon meg egy várost";
            // 
            // textBox_varosHozzaAd
            // 
            this.textBox_varosHozzaAd.Location = new System.Drawing.Point(9, 32);
            this.textBox_varosHozzaAd.Name = "textBox_varosHozzaAd";
            this.textBox_varosHozzaAd.Size = new System.Drawing.Size(138, 20);
            this.textBox_varosHozzaAd.TabIndex = 2;
            // 
            // numericUpDown_lakossagHozzaAd
            // 
            this.numericUpDown_lakossagHozzaAd.Location = new System.Drawing.Point(9, 71);
            this.numericUpDown_lakossagHozzaAd.Maximum = new decimal(new int[] {
            1410065408,
            2,
            0,
            0});
            this.numericUpDown_lakossagHozzaAd.Name = "numericUpDown_lakossagHozzaAd";
            this.numericUpDown_lakossagHozzaAd.Size = new System.Drawing.Size(170, 20);
            this.numericUpDown_lakossagHozzaAd.TabIndex = 3;
            // 
            // label_lakossag
            // 
            this.label_lakossag.AutoSize = true;
            this.label_lakossag.Location = new System.Drawing.Point(6, 55);
            this.label_lakossag.Name = "label_lakossag";
            this.label_lakossag.Size = new System.Drawing.Size(173, 13);
            this.label_lakossag.TabIndex = 4;
            this.label_lakossag.Text = "Kérem adja meg a lakosság számát";
            // 
            // button_hozzaAd
            // 
            this.button_hozzaAd.BackColor = System.Drawing.Color.GreenYellow;
            this.button_hozzaAd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_hozzaAd.Location = new System.Drawing.Point(60, 97);
            this.button_hozzaAd.Name = "button_hozzaAd";
            this.button_hozzaAd.Size = new System.Drawing.Size(75, 23);
            this.button_hozzaAd.TabIndex = 5;
            this.button_hozzaAd.Text = "Hozzá ad";
            this.button_hozzaAd.UseVisualStyleBackColor = false;
            this.button_hozzaAd.Click += new System.EventHandler(this.button_hozzaAd_Click);
            // 
            // groupBox_varos
            // 
            this.groupBox_varos.Controls.Add(this.label_varoshozzad);
            this.groupBox_varos.Controls.Add(this.button_hozzaAd);
            this.groupBox_varos.Controls.Add(this.textBox_varosHozzaAd);
            this.groupBox_varos.Controls.Add(this.numericUpDown_lakossagHozzaAd);
            this.groupBox_varos.Controls.Add(this.label_lakossag);
            this.groupBox_varos.Location = new System.Drawing.Point(12, 12);
            this.groupBox_varos.Name = "groupBox_varos";
            this.groupBox_varos.Size = new System.Drawing.Size(189, 128);
            this.groupBox_varos.TabIndex = 6;
            this.groupBox_varos.TabStop = false;
            this.groupBox_varos.Text = "Város hozzáadás";
            // 
            // groupBox_latvanyossag
            // 
            this.groupBox_latvanyossag.Controls.Add(this.button_modositas);
            this.groupBox_latvanyossag.Controls.Add(this.button_torles);
            this.groupBox_latvanyossag.Controls.Add(this.button_latvanyossag_hozaad);
            this.groupBox_latvanyossag.Controls.Add(this.numericUpDown_latvanyossag_ar);
            this.groupBox_latvanyossag.Controls.Add(this.label_latvanyossag_ar);
            this.groupBox_latvanyossag.Controls.Add(this.textBox_latvanyossag_leiras);
            this.groupBox_latvanyossag.Controls.Add(this.label_latvanyossag_leiras);
            this.groupBox_latvanyossag.Controls.Add(this.textBox_latvanyossagNev);
            this.groupBox_latvanyossag.Controls.Add(this.label_latvanyosag_nev);
            this.groupBox_latvanyossag.Controls.Add(this.label_valaszVaros);
            this.groupBox_latvanyossag.Controls.Add(this.listBox_varosok);
            this.groupBox_latvanyossag.Location = new System.Drawing.Point(207, 12);
            this.groupBox_latvanyossag.Name = "groupBox_latvanyossag";
            this.groupBox_latvanyossag.Size = new System.Drawing.Size(469, 242);
            this.groupBox_latvanyossag.TabIndex = 7;
            this.groupBox_latvanyossag.TabStop = false;
            this.groupBox_latvanyossag.Text = "Látványoság hozzáadása";
            // 
            // label_valaszVaros
            // 
            this.label_valaszVaros.AutoSize = true;
            this.label_valaszVaros.Location = new System.Drawing.Point(219, 17);
            this.label_valaszVaros.Name = "label_valaszVaros";
            this.label_valaszVaros.Size = new System.Drawing.Size(160, 13);
            this.label_valaszVaros.TabIndex = 1;
            this.label_valaszVaros.Text = "<-- Kérem válasszon egy várost!!";
            // 
            // label_latvanyosag_nev
            // 
            this.label_latvanyosag_nev.AutoSize = true;
            this.label_latvanyosag_nev.Location = new System.Drawing.Point(219, 46);
            this.label_latvanyosag_nev.Name = "label_latvanyosag_nev";
            this.label_latvanyosag_nev.Size = new System.Drawing.Size(103, 13);
            this.label_latvanyosag_nev.TabIndex = 2;
            this.label_latvanyosag_nev.Text = "Látványosság neve:";
            // 
            // textBox_latvanyossagNev
            // 
            this.textBox_latvanyossagNev.Location = new System.Drawing.Point(328, 43);
            this.textBox_latvanyossagNev.Name = "textBox_latvanyossagNev";
            this.textBox_latvanyossagNev.Size = new System.Drawing.Size(132, 20);
            this.textBox_latvanyossagNev.TabIndex = 3;
            // 
            // label_latvanyossag_leiras
            // 
            this.label_latvanyossag_leiras.AutoSize = true;
            this.label_latvanyossag_leiras.Location = new System.Drawing.Point(218, 66);
            this.label_latvanyossag_leiras.Name = "label_latvanyossag_leiras";
            this.label_latvanyossag_leiras.Size = new System.Drawing.Size(133, 13);
            this.label_latvanyossag_leiras.TabIndex = 4;
            this.label_latvanyossag_leiras.Text = "Kérem adja meg a leírását:";
            this.label_latvanyossag_leiras.Click += new System.EventHandler(this.label_latvanyossag_leiras_Click);
            // 
            // textBox_latvanyossag_leiras
            // 
            this.textBox_latvanyossag_leiras.Location = new System.Drawing.Point(222, 83);
            this.textBox_latvanyossag_leiras.Multiline = true;
            this.textBox_latvanyossag_leiras.Name = "textBox_latvanyossag_leiras";
            this.textBox_latvanyossag_leiras.Size = new System.Drawing.Size(238, 42);
            this.textBox_latvanyossag_leiras.TabIndex = 5;
            // 
            // label_latvanyossag_ar
            // 
            this.label_latvanyossag_ar.AutoSize = true;
            this.label_latvanyossag_ar.Location = new System.Drawing.Point(222, 132);
            this.label_latvanyossag_ar.Name = "label_latvanyossag_ar";
            this.label_latvanyossag_ar.Size = new System.Drawing.Size(158, 13);
            this.label_latvanyossag_ar.TabIndex = 6;
            this.label_latvanyossag_ar.Text = "Kérem adja meg az árát(EURO):";
            // 
            // numericUpDown_latvanyossag_ar
            // 
            this.numericUpDown_latvanyossag_ar.Location = new System.Drawing.Point(386, 130);
            this.numericUpDown_latvanyossag_ar.Maximum = new decimal(new int[] {
            100000000,
            0,
            0,
            0});
            this.numericUpDown_latvanyossag_ar.Name = "numericUpDown_latvanyossag_ar";
            this.numericUpDown_latvanyossag_ar.Size = new System.Drawing.Size(74, 20);
            this.numericUpDown_latvanyossag_ar.TabIndex = 7;
            // 
            // button_latvanyossag_hozaad
            // 
            this.button_latvanyossag_hozaad.BackColor = System.Drawing.Color.GreenYellow;
            this.button_latvanyossag_hozaad.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_latvanyossag_hozaad.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_latvanyossag_hozaad.Location = new System.Drawing.Point(252, 167);
            this.button_latvanyossag_hozaad.Name = "button_latvanyossag_hozaad";
            this.button_latvanyossag_hozaad.Size = new System.Drawing.Size(177, 23);
            this.button_latvanyossag_hozaad.TabIndex = 8;
            this.button_latvanyossag_hozaad.Text = "látványossság hozzáadása";
            this.button_latvanyossag_hozaad.UseVisualStyleBackColor = false;
            this.button_latvanyossag_hozaad.Click += new System.EventHandler(this.button_latvanyossag_hozaad_Click);
            // 
            // button_torles
            // 
            this.button_torles.BackColor = System.Drawing.Color.Red;
            this.button_torles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_torles.ForeColor = System.Drawing.SystemColors.Control;
            this.button_torles.Location = new System.Drawing.Point(111, 196);
            this.button_torles.Name = "button_torles";
            this.button_torles.Size = new System.Drawing.Size(105, 40);
            this.button_torles.TabIndex = 8;
            this.button_torles.Text = "Törlés";
            this.button_torles.UseVisualStyleBackColor = false;
            this.button_torles.Click += new System.EventHandler(this.button_torles_Click);
            // 
            // button_modositas
            // 
            this.button_modositas.BackColor = System.Drawing.Color.Aqua;
            this.button_modositas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_modositas.Location = new System.Drawing.Point(7, 197);
            this.button_modositas.Name = "button_modositas";
            this.button_modositas.Size = new System.Drawing.Size(98, 39);
            this.button_modositas.TabIndex = 9;
            this.button_modositas.Text = "Módosítás";
            this.button_modositas.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(689, 266);
            this.Controls.Add(this.groupBox_latvanyossag);
            this.Controls.Add(this.groupBox_varos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_lakossagHozzaAd)).EndInit();
            this.groupBox_varos.ResumeLayout(false);
            this.groupBox_varos.PerformLayout();
            this.groupBox_latvanyossag.ResumeLayout(false);
            this.groupBox_latvanyossag.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown_latvanyossag_ar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_varosok;
        private System.Windows.Forms.Label label_varoshozzad;
        private System.Windows.Forms.TextBox textBox_varosHozzaAd;
        private System.Windows.Forms.NumericUpDown numericUpDown_lakossagHozzaAd;
        private System.Windows.Forms.Label label_lakossag;
        private System.Windows.Forms.Button button_hozzaAd;
        private System.Windows.Forms.GroupBox groupBox_varos;
        private System.Windows.Forms.GroupBox groupBox_latvanyossag;
        private System.Windows.Forms.Label label_latvanyossag_leiras;
        private System.Windows.Forms.TextBox textBox_latvanyossagNev;
        private System.Windows.Forms.Label label_latvanyosag_nev;
        private System.Windows.Forms.Label label_valaszVaros;
        private System.Windows.Forms.NumericUpDown numericUpDown_latvanyossag_ar;
        private System.Windows.Forms.Label label_latvanyossag_ar;
        private System.Windows.Forms.TextBox textBox_latvanyossag_leiras;
        private System.Windows.Forms.Button button_latvanyossag_hozaad;
        private System.Windows.Forms.Button button_torles;
        private System.Windows.Forms.Button button_modositas;
    }
}

