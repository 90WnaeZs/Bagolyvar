
namespace Vezeteknev_Keresztnev_Gepszam
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.btn_Kolcsonzes = new System.Windows.Forms.Button();
            this.btn_Visszavitel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Kolcsonzes
            // 
            this.btn_Kolcsonzes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Kolcsonzes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Kolcsonzes.Location = new System.Drawing.Point(95, 100);
            this.btn_Kolcsonzes.Name = "btn_Kolcsonzes";
            this.btn_Kolcsonzes.Size = new System.Drawing.Size(136, 33);
            this.btn_Kolcsonzes.TabIndex = 0;
            this.btn_Kolcsonzes.Text = "Kölcsönzés";
            this.btn_Kolcsonzes.UseVisualStyleBackColor = false;
            this.btn_Kolcsonzes.Click += new System.EventHandler(this.btn_Kolcsonzes_Click);
            // 
            // btn_Visszavitel
            // 
            this.btn_Visszavitel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btn_Visszavitel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_Visszavitel.Location = new System.Drawing.Point(310, 100);
            this.btn_Visszavitel.Name = "btn_Visszavitel";
            this.btn_Visszavitel.Size = new System.Drawing.Size(136, 33);
            this.btn_Visszavitel.TabIndex = 1;
            this.btn_Visszavitel.Text = "Visszavitel";
            this.btn_Visszavitel.UseVisualStyleBackColor = false;
            this.btn_Visszavitel.Click += new System.EventHandler(this.btn_Visszavitel_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(550, 211);
            this.Controls.Add(this.btn_Visszavitel);
            this.Controls.Add(this.btn_Kolcsonzes);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Könyvkölcsönzés";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Kolcsonzes;
        private System.Windows.Forms.Button btn_Visszavitel;
    }
}