
namespace OtoparkOtomasyonu
{
    partial class AnaSayfa
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
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnYer = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnKayit
            // 
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.Location = new System.Drawing.Point(12, 12);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(256, 50);
            this.btnKayit.TabIndex = 0;
            this.btnKayit.Text = "ARAÇ OTOPARK KAYDI SAYFASI";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnYer
            // 
            this.btnYer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYer.Location = new System.Drawing.Point(12, 68);
            this.btnYer.Name = "btnYer";
            this.btnYer.Size = new System.Drawing.Size(256, 50);
            this.btnYer.TabIndex = 1;
            this.btnYer.Text = "ARAÇ OTOPARK YERLERİ";
            this.btnYer.UseVisualStyleBackColor = true;
            this.btnYer.Click += new System.EventHandler(this.btnYer_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.Location = new System.Drawing.Point(12, 124);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(256, 50);
            this.btnCikis.TabIndex = 2;
            this.btnCikis.Text = "ARAÇ OTOPARK ÇIKIŞ SAYFASI";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Location = new System.Drawing.Point(12, 180);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(256, 50);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "ÇIKIŞ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(281, 243);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnYer);
            this.Controls.Add(this.btnKayit);
            this.Name = "AnaSayfa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ana Sayfa";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnYer;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnExit;
    }
}