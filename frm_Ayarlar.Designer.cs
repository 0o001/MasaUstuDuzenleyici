namespace MasaUstuDuzenleyici
{
    partial class frm_Ayarlar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Ayarlar));
            this.chk_Eminmisiniz = new System.Windows.Forms.CheckBox();
            this.pcr_ayarlar = new System.Windows.Forms.PictureBox();
            this.lbl_ayarlar = new System.Windows.Forms.Label();
            this.chk_sagtik = new System.Windows.Forms.CheckBox();
            this.chk_baslangic = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ayarlar)).BeginInit();
            this.SuspendLayout();
            // 
            // chk_Eminmisiniz
            // 
            this.chk_Eminmisiniz.AutoSize = true;
            this.chk_Eminmisiniz.Location = new System.Drawing.Point(42, 74);
            this.chk_Eminmisiniz.Name = "chk_Eminmisiniz";
            this.chk_Eminmisiniz.Size = new System.Drawing.Size(286, 17);
            this.chk_Eminmisiniz.TabIndex = 0;
            this.chk_Eminmisiniz.Text = "Dosyalarım üzerinde işlem yapılacağında beni bilgilendir.";
            this.chk_Eminmisiniz.UseVisualStyleBackColor = true;
            this.chk_Eminmisiniz.CheckedChanged += new System.EventHandler(this.chk_Eminmisiniz_CheckedChanged);
            // 
            // pcr_ayarlar
            // 
            this.pcr_ayarlar.Image = global::MasaUstuDuzenleyici.Properties.Resources.settings;
            this.pcr_ayarlar.Location = new System.Drawing.Point(6, 5);
            this.pcr_ayarlar.Name = "pcr_ayarlar";
            this.pcr_ayarlar.Size = new System.Drawing.Size(48, 48);
            this.pcr_ayarlar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pcr_ayarlar.TabIndex = 1;
            this.pcr_ayarlar.TabStop = false;
            // 
            // lbl_ayarlar
            // 
            this.lbl_ayarlar.AutoSize = true;
            this.lbl_ayarlar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_ayarlar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_ayarlar.Location = new System.Drawing.Point(60, 18);
            this.lbl_ayarlar.Name = "lbl_ayarlar";
            this.lbl_ayarlar.Size = new System.Drawing.Size(80, 25);
            this.lbl_ayarlar.TabIndex = 2;
            this.lbl_ayarlar.Text = "Ayarlar";
            // 
            // chk_sagtik
            // 
            this.chk_sagtik.AutoSize = true;
            this.chk_sagtik.Location = new System.Drawing.Point(42, 97);
            this.chk_sagtik.Name = "chk_sagtik";
            this.chk_sagtik.Size = new System.Drawing.Size(137, 17);
            this.chk_sagtik.TabIndex = 3;
            this.chk_sagtik.Text = "Masaüstü sağtık\'a ekle.";
            this.chk_sagtik.UseVisualStyleBackColor = true;
            this.chk_sagtik.CheckedChanged += new System.EventHandler(this.chk_sagtik_CheckedChanged);
            this.chk_sagtik.Click += new System.EventHandler(this.chk_sagtik_Click);
            // 
            // chk_baslangic
            // 
            this.chk_baslangic.AutoSize = true;
            this.chk_baslangic.Location = new System.Drawing.Point(42, 120);
            this.chk_baslangic.Name = "chk_baslangic";
            this.chk_baslangic.Size = new System.Drawing.Size(104, 17);
            this.chk_baslangic.TabIndex = 4;
            this.chk_baslangic.Text = "Başlangıca ekle.";
            this.chk_baslangic.UseVisualStyleBackColor = true;
            this.chk_baslangic.CheckedChanged += new System.EventHandler(this.chk_baslangic_CheckedChanged);
            this.chk_baslangic.Click += new System.EventHandler(this.chk_baslangic_Click);
            // 
            // frm_Ayarlar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(340, 148);
            this.Controls.Add(this.chk_baslangic);
            this.Controls.Add(this.chk_sagtik);
            this.Controls.Add(this.lbl_ayarlar);
            this.Controls.Add(this.pcr_ayarlar);
            this.Controls.Add(this.chk_Eminmisiniz);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frm_Ayarlar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ayarlar";
            this.Load += new System.EventHandler(this.frm_Ayarlar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_ayarlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chk_Eminmisiniz;
        private System.Windows.Forms.PictureBox pcr_ayarlar;
        private System.Windows.Forms.Label lbl_ayarlar;
        private System.Windows.Forms.CheckBox chk_sagtik;
        private System.Windows.Forms.CheckBox chk_baslangic;
    }
}