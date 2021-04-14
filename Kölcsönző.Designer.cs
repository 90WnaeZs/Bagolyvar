
namespace Vezeteknev_Keresztnev_Gepszam
{
    partial class Kölcsönző
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kölcsönző));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.peldany = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bérlő_combo = new System.Windows.Forms.ComboBox();
            this.könyv_combo = new System.Windows.Forms.ComboBox();
            this.btn_List = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.btn_Rögzít = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peldany)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.peldany);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.bérlő_combo);
            this.groupBox1.Controls.Add(this.könyv_combo);
            this.groupBox1.Location = new System.Drawing.Point(28, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 169);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kölcsönzés adatok";
            // 
            // peldany
            // 
            this.peldany.Location = new System.Drawing.Point(187, 117);
            this.peldany.Name = "peldany";
            this.peldany.Size = new System.Drawing.Size(120, 20);
            this.peldany.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Példány";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Bérlő";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Könyv";
            // 
            // bérlő_combo
            // 
            this.bérlő_combo.FormattingEnabled = true;
            this.bérlő_combo.Location = new System.Drawing.Point(115, 74);
            this.bérlő_combo.Name = "bérlő_combo";
            this.bérlő_combo.Size = new System.Drawing.Size(192, 21);
            this.bérlő_combo.TabIndex = 1;
            // 
            // könyv_combo
            // 
            this.könyv_combo.FormattingEnabled = true;
            this.könyv_combo.Location = new System.Drawing.Point(115, 36);
            this.könyv_combo.Name = "könyv_combo";
            this.könyv_combo.Size = new System.Drawing.Size(192, 21);
            this.könyv_combo.TabIndex = 0;
            // 
            // btn_List
            // 
            this.btn_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_List.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_List.Location = new System.Drawing.Point(50, 228);
            this.btn_List.Name = "btn_List";
            this.btn_List.Size = new System.Drawing.Size(304, 40);
            this.btn_List.TabIndex = 1;
            this.btn_List.Text = "Listában tárolja az adatot";
            this.btn_List.UseVisualStyleBackColor = false;
            this.btn_List.Click += new System.EventHandler(this.btn_List_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(423, 31);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 238);
            this.listBox1.TabIndex = 2;
            // 
            // btn_Rögzít
            // 
            this.btn_Rögzít.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Rögzít.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Rögzít.Location = new System.Drawing.Point(244, 363);
            this.btn_Rögzít.Name = "btn_Rögzít";
            this.btn_Rögzít.Size = new System.Drawing.Size(304, 40);
            this.btn_Rögzít.TabIndex = 3;
            this.btn_Rögzít.Text = "Rögzítés az adatbázisban";
            this.btn_Rögzít.UseVisualStyleBackColor = false;
            this.btn_Rögzít.Click += new System.EventHandler(this.btn_Rögzít_Click);
            // 
            // Kölcsönző
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Rögzít);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btn_List);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kölcsönző";
            this.Text = "Kölcsönzések";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peldany)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.NumericUpDown peldany;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox bérlő_combo;
        private System.Windows.Forms.ComboBox könyv_combo;
        private System.Windows.Forms.Button btn_List;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button btn_Rögzít;
    }
}