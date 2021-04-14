
namespace Vezeteknev_Keresztnev_Gepszam
{
    partial class Visszavétel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Visszavétel));
            this.label1 = new System.Windows.Forms.Label();
            this.combo_berlo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Visszaad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbx_szerzo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbx_konyv = new System.Windows.Forms.TextBox();
            this.tbx_isbn = new System.Windows.Forms.TextBox();
            this.num_peldany = new System.Windows.Forms.NumericUpDown();
            this.lbl_date = new System.Windows.Forms.Label();
            this.check_késett = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.num_peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bérlő neve";
            // 
            // combo_berlo
            // 
            this.combo_berlo.FormattingEnabled = true;
            this.combo_berlo.Location = new System.Drawing.Point(100, 25);
            this.combo_berlo.Name = "combo_berlo";
            this.combo_berlo.Size = new System.Drawing.Size(218, 21);
            this.combo_berlo.TabIndex = 1;
            this.combo_berlo.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(5, 82);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(357, 340);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzött könyvek";
            // 
            // listBox1
            // 
            this.listBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(3, 16);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(351, 321);
            this.listBox1.TabIndex = 0;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // btn_Visszaad
            // 
            this.btn_Visszaad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Visszaad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Visszaad.Location = new System.Drawing.Point(461, 368);
            this.btn_Visszaad.Name = "btn_Visszaad";
            this.btn_Visszaad.Size = new System.Drawing.Size(304, 40);
            this.btn_Visszaad.TabIndex = 3;
            this.btn_Visszaad.Text = "Visszaad";
            this.btn_Visszaad.UseVisualStyleBackColor = false;
            this.btn_Visszaad.Click += new System.EventHandler(this.btn_Visszaad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Szerző";
            // 
            // tbx_szerzo
            // 
            this.tbx_szerzo.Location = new System.Drawing.Point(473, 82);
            this.tbx_szerzo.Name = "tbx_szerzo";
            this.tbx_szerzo.Size = new System.Drawing.Size(201, 20);
            this.tbx_szerzo.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(387, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Könyvcím";
            // 
            // tbx_konyv
            // 
            this.tbx_konyv.Location = new System.Drawing.Point(473, 126);
            this.tbx_konyv.Name = "tbx_konyv";
            this.tbx_konyv.Size = new System.Drawing.Size(201, 20);
            this.tbx_konyv.TabIndex = 7;
            // 
            // tbx_isbn
            // 
            this.tbx_isbn.Location = new System.Drawing.Point(473, 170);
            this.tbx_isbn.Name = "tbx_isbn";
            this.tbx_isbn.Size = new System.Drawing.Size(201, 20);
            this.tbx_isbn.TabIndex = 8;
            // 
            // num_peldany
            // 
            this.num_peldany.Location = new System.Drawing.Point(473, 214);
            this.num_peldany.Name = "num_peldany";
            this.num_peldany.Size = new System.Drawing.Size(120, 20);
            this.num_peldany.TabIndex = 9;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(470, 258);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(0, 13);
            this.lbl_date.TabIndex = 10;
            // 
            // check_késett
            // 
            this.check_késett.AutoSize = true;
            this.check_késett.ForeColor = System.Drawing.Color.Red;
            this.check_késett.Location = new System.Drawing.Point(473, 295);
            this.check_késett.Name = "check_késett";
            this.check_késett.Size = new System.Drawing.Size(59, 17);
            this.check_késett.TabIndex = 11;
            this.check_késett.Text = "Késett!";
            this.check_késett.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(387, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "ISBN";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(387, 214);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Példány";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Dátum";
            // 
            // Visszavétel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.check_késett);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.num_peldany);
            this.Controls.Add(this.tbx_isbn);
            this.Controls.Add(this.tbx_konyv);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbx_szerzo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Visszaad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.combo_berlo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Visszavétel";
            this.Text = "Könyv visszavétel";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.num_peldany)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox combo_berlo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Visszaad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbx_szerzo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbx_konyv;
        private System.Windows.Forms.TextBox tbx_isbn;
        private System.Windows.Forms.NumericUpDown num_peldany;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.CheckBox check_késett;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}