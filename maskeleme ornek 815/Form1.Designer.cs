namespace maskeleme_ornek_815
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.nTatli = new System.Windows.Forms.NumericUpDown();
            this.nYemek = new System.Windows.Forms.NumericUpDown();
            this.nSalata = new System.Windows.Forms.NumericUpDown();
            this.nCorba = new System.Windows.Forms.NumericUpDown();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.txtBilgi = new System.Windows.Forms.TextBox();
            this.txtBilgi2 = new System.Windows.Forms.TextBox();
            this.txtBilgi3 = new System.Windows.Forms.TextBox();
            this.txtBilgi4 = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 270);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtAdres);
            this.tabPage1.Controls.Add(this.txtTelefon);
            this.tabPage1.Controls.Add(this.txtAdSoyad);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(385, 244);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Müşteri";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(130, 110);
            this.txtAdres.Multiline = true;
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(130, 44);
            this.txtAdres.TabIndex = 5;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(130, 81);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(130, 20);
            this.txtTelefon.TabIndex = 4;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(130, 55);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(130, 20);
            this.txtAdSoyad.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Adres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Telefon";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ad Soyad";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.nTatli);
            this.tabPage2.Controls.Add(this.nYemek);
            this.tabPage2.Controls.Add(this.nSalata);
            this.tabPage2.Controls.Add(this.nCorba);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(385, 244);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Sipariş";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // nTatli
            // 
            this.nTatli.Location = new System.Drawing.Point(135, 118);
            this.nTatli.Name = "nTatli";
            this.nTatli.Size = new System.Drawing.Size(120, 20);
            this.nTatli.TabIndex = 7;
            // 
            // nYemek
            // 
            this.nYemek.Location = new System.Drawing.Point(135, 92);
            this.nYemek.Name = "nYemek";
            this.nYemek.Size = new System.Drawing.Size(120, 20);
            this.nYemek.TabIndex = 6;
            // 
            // nSalata
            // 
            this.nSalata.Location = new System.Drawing.Point(135, 71);
            this.nSalata.Name = "nSalata";
            this.nSalata.Size = new System.Drawing.Size(120, 20);
            this.nSalata.TabIndex = 5;
            // 
            // nCorba
            // 
            this.nCorba.Location = new System.Drawing.Point(135, 47);
            this.nCorba.Name = "nCorba";
            this.nCorba.Size = new System.Drawing.Size(120, 20);
            this.nCorba.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(92, 120);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 3;
            this.label7.Text = "Tatlı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(62, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Ana Yemek";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Salata";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Çorba";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.txtBilgi4);
            this.tabPage3.Controls.Add(this.txtBilgi3);
            this.tabPage3.Controls.Add(this.txtBilgi2);
            this.tabPage3.Controls.Add(this.txtBilgi);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(385, 244);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Hesap";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // txtBilgi
            // 
            this.txtBilgi.Enabled = false;
            this.txtBilgi.Location = new System.Drawing.Point(3, 3);
            this.txtBilgi.Name = "txtBilgi";
            this.txtBilgi.Size = new System.Drawing.Size(379, 20);
            this.txtBilgi.TabIndex = 0;
            this.txtBilgi.TextChanged += new System.EventHandler(this.txtBilgi_TextChanged);
            // 
            // txtBilgi2
            // 
            this.txtBilgi2.Enabled = false;
            this.txtBilgi2.Location = new System.Drawing.Point(3, 29);
            this.txtBilgi2.Name = "txtBilgi2";
            this.txtBilgi2.Size = new System.Drawing.Size(379, 20);
            this.txtBilgi2.TabIndex = 1;
            // 
            // txtBilgi3
            // 
            this.txtBilgi3.Enabled = false;
            this.txtBilgi3.Location = new System.Drawing.Point(0, 55);
            this.txtBilgi3.Name = "txtBilgi3";
            this.txtBilgi3.Size = new System.Drawing.Size(382, 20);
            this.txtBilgi3.TabIndex = 2;
            // 
            // txtBilgi4
            // 
            this.txtBilgi4.Enabled = false;
            this.txtBilgi4.Location = new System.Drawing.Point(3, 81);
            this.txtBilgi4.Name = "txtBilgi4";
            this.txtBilgi4.Size = new System.Drawing.Size(379, 20);
            this.txtBilgi4.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 271);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nTatli)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nYemek)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nSalata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nCorba)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nTatli;
        private System.Windows.Forms.NumericUpDown nYemek;
        private System.Windows.Forms.NumericUpDown nSalata;
        private System.Windows.Forms.NumericUpDown nCorba;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox txtBilgi;
        private System.Windows.Forms.TextBox txtBilgi2;
        private System.Windows.Forms.TextBox txtBilgi3;
        private System.Windows.Forms.TextBox txtBilgi4;
    }
}

