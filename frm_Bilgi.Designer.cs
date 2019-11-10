namespace MasaUstuDuzenleyici
{
    partial class frm_Bilgi
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Bilgi));
            this.lbl_yazi = new System.Windows.Forms.Label();
            this.time_OpeningEffect = new System.Windows.Forms.Timer(this.components);
            this.pcr_logo = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_yazi
            // 
            this.lbl_yazi.AutoSize = true;
            this.lbl_yazi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_yazi.Location = new System.Drawing.Point(149, 59);
            this.lbl_yazi.Name = "lbl_yazi";
            this.lbl_yazi.Size = new System.Drawing.Size(465, 76);
            this.lbl_yazi.TabIndex = 0;
            this.lbl_yazi.Text = resources.GetString("lbl_yazi.Text");
            this.lbl_yazi.Click += new System.EventHandler(this.label1_Click);
            // 
            // time_OpeningEffect
            // 
            this.time_OpeningEffect.Tick += new System.EventHandler(this.time_OpeningEffect_Tick);
            // 
            // pcr_logo
            // 
            this.pcr_logo.Image = global::MasaUstuDuzenleyici.Properties.Resources.logo;
            this.pcr_logo.Location = new System.Drawing.Point(32, 50);
            this.pcr_logo.Name = "pcr_logo";
            this.pcr_logo.Size = new System.Drawing.Size(100, 100);
            this.pcr_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcr_logo.TabIndex = 1;
            this.pcr_logo.TabStop = false;
            this.pcr_logo.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // frm_Bilgi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 200);
            this.Controls.Add(this.pcr_logo);
            this.Controls.Add(this.lbl_yazi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Bilgi";
            this.Opacity = 0D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Bilgi";
            this.Click += new System.EventHandler(this.frm_Bilgi_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pcr_logo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_yazi;
        private System.Windows.Forms.PictureBox pcr_logo;
        private System.Windows.Forms.Timer time_OpeningEffect;
    }
}