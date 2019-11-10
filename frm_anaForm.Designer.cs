namespace MasaUstuDuzenleyici
{
    partial class frm_AnaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_AnaForm));
            this.cmb_secim = new System.Windows.Forms.ComboBox();
            this.lbl_adim = new System.Windows.Forms.Label();
            this.sc_BolmeliKutu = new System.Windows.Forms.SplitContainer();
            this.flp_Butonlar = new System.Windows.Forms.FlowLayoutPanel();
            this.lsv_Icerik = new System.Windows.Forms.ListView();
            this.lil_resimler = new System.Windows.Forms.ImageList(this.components);
            this.pnl_Durum = new System.Windows.Forms.Panel();
            this.btn_klasorYenile = new System.Windows.Forms.Button();
            this.btn_ara = new System.Windows.Forms.Button();
            this.btn_Tumu = new System.Windows.Forms.Button();
            this.btn_Sirala = new System.Windows.Forms.Button();
            this.lbl_ToplamBoyut = new System.Windows.Forms.Label();
            this.btn_Yenile = new System.Windows.Forms.Button();
            this.bgw_YukAzaltici = new System.ComponentModel.BackgroundWorker();
            this.btn_uygula = new System.Windows.Forms.Button();
            this.btn_geri = new System.Windows.Forms.Button();
            this.btnAyarlar = new System.Windows.Forms.Button();
            this.lbl_adimSayi = new System.Windows.Forms.Label();
            this.sc_BolmeliKutu.Panel1.SuspendLayout();
            this.sc_BolmeliKutu.Panel2.SuspendLayout();
            this.sc_BolmeliKutu.SuspendLayout();
            this.pnl_Durum.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmb_secim
            // 
            this.cmb_secim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cmb_secim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.cmb_secim.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmb_secim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_secim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmb_secim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmb_secim.ForeColor = System.Drawing.Color.White;
            this.cmb_secim.ItemHeight = 23;
            this.cmb_secim.Items.AddRange(new object[] {
            "Kategoriye göre",
            "Tarihe göre"});
            this.cmb_secim.Location = new System.Drawing.Point(10, 25);
            this.cmb_secim.Margin = new System.Windows.Forms.Padding(0);
            this.cmb_secim.Name = "cmb_secim";
            this.cmb_secim.Size = new System.Drawing.Size(130, 29);
            this.cmb_secim.TabIndex = 26;
            this.cmb_secim.Visible = false;
            this.cmb_secim.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cmb_secim_DrawItem);
            this.cmb_secim.MeasureItem += new System.Windows.Forms.MeasureItemEventHandler(this.cmb_secim_MeasureItem);
            this.cmb_secim.SelectedIndexChanged += new System.EventHandler(this.cmb_secim_SelectedIndexChanged);
            // 
            // lbl_adim
            // 
            this.lbl_adim.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_adim.AutoSize = true;
            this.lbl_adim.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adim.ForeColor = System.Drawing.Color.Green;
            this.lbl_adim.Location = new System.Drawing.Point(222, 65);
            this.lbl_adim.Name = "lbl_adim";
            this.lbl_adim.Size = new System.Drawing.Size(214, 15);
            this.lbl_adim.TabIndex = 10;
            this.lbl_adim.Text = "[1]. Adım : Başlamak için butona basın";
            // 
            // sc_BolmeliKutu
            // 
            this.sc_BolmeliKutu.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.sc_BolmeliKutu.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc_BolmeliKutu.Location = new System.Drawing.Point(0, 112);
            this.sc_BolmeliKutu.Name = "sc_BolmeliKutu";
            // 
            // sc_BolmeliKutu.Panel1
            // 
            this.sc_BolmeliKutu.Panel1.Controls.Add(this.flp_Butonlar);
            this.sc_BolmeliKutu.Panel1MinSize = 180;
            // 
            // sc_BolmeliKutu.Panel2
            // 
            this.sc_BolmeliKutu.Panel2.Controls.Add(this.lsv_Icerik);
            this.sc_BolmeliKutu.Size = new System.Drawing.Size(614, 293);
            this.sc_BolmeliKutu.SplitterDistance = 180;
            this.sc_BolmeliKutu.SplitterWidth = 1;
            this.sc_BolmeliKutu.TabIndex = 11;
            this.sc_BolmeliKutu.KeyDown += new System.Windows.Forms.KeyEventHandler(this.sc_BolmeliKutu_KeyDown);
            // 
            // flp_Butonlar
            // 
            this.flp_Butonlar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flp_Butonlar.AutoScroll = true;
            this.flp_Butonlar.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_Butonlar.Location = new System.Drawing.Point(0, 0);
            this.flp_Butonlar.Margin = new System.Windows.Forms.Padding(0);
            this.flp_Butonlar.Name = "flp_Butonlar";
            this.flp_Butonlar.Size = new System.Drawing.Size(180, 293);
            this.flp_Butonlar.TabIndex = 1;
            this.flp_Butonlar.WrapContents = false;
            // 
            // lsv_Icerik
            // 
            this.lsv_Icerik.AllowDrop = true;
            this.lsv_Icerik.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lsv_Icerik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lsv_Icerik.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lsv_Icerik.FullRowSelect = true;
            this.lsv_Icerik.LargeImageList = this.lil_resimler;
            this.lsv_Icerik.Location = new System.Drawing.Point(0, 0);
            this.lsv_Icerik.MultiSelect = false;
            this.lsv_Icerik.Name = "lsv_Icerik";
            this.lsv_Icerik.Size = new System.Drawing.Size(433, 293);
            this.lsv_Icerik.SmallImageList = this.lil_resimler;
            this.lsv_Icerik.TabIndex = 6;
            this.lsv_Icerik.UseCompatibleStateImageBehavior = false;
            this.lsv_Icerik.View = System.Windows.Forms.View.Details;
            this.lsv_Icerik.SelectedIndexChanged += new System.EventHandler(this.lsv_Icerik_SelectedIndexChanged);
            this.lsv_Icerik.DoubleClick += new System.EventHandler(this.lsv_Icerik_DoubleClick);
            this.lsv_Icerik.Resize += new System.EventHandler(this.lsv_Icerik_Resize);
            // 
            // lil_resimler
            // 
            this.lil_resimler.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("lil_resimler.ImageStream")));
            this.lil_resimler.TransparentColor = System.Drawing.Color.Transparent;
            this.lil_resimler.Images.SetKeyName(0, "picture.png");
            this.lil_resimler.Images.SetKeyName(1, "video.png");
            this.lil_resimler.Images.SetKeyName(2, "ses.png");
            this.lil_resimler.Images.SetKeyName(3, "word.png");
            this.lil_resimler.Images.SetKeyName(4, "excel.png");
            this.lil_resimler.Images.SetKeyName(5, "sunum.png");
            this.lil_resimler.Images.SetKeyName(6, "sikistirilmis.png");
            this.lil_resimler.Images.SetKeyName(7, "text.png");
            this.lil_resimler.Images.SetKeyName(8, "diger.png");
            // 
            // pnl_Durum
            // 
            this.pnl_Durum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnl_Durum.Controls.Add(this.btn_klasorYenile);
            this.pnl_Durum.Controls.Add(this.btn_ara);
            this.pnl_Durum.Controls.Add(this.btn_Tumu);
            this.pnl_Durum.Controls.Add(this.btn_Sirala);
            this.pnl_Durum.Controls.Add(this.lbl_ToplamBoyut);
            this.pnl_Durum.Controls.Add(this.btn_Yenile);
            this.pnl_Durum.Location = new System.Drawing.Point(0, 90);
            this.pnl_Durum.Name = "pnl_Durum";
            this.pnl_Durum.Size = new System.Drawing.Size(614, 22);
            this.pnl_Durum.TabIndex = 12;
            // 
            // btn_klasorYenile
            // 
            this.btn_klasorYenile.BackgroundImage = global::MasaUstuDuzenleyici.Properties.Resources.sinchronize_16;
            this.btn_klasorYenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_klasorYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_klasorYenile.FlatAppearance.BorderSize = 0;
            this.btn_klasorYenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_klasorYenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_klasorYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_klasorYenile.Location = new System.Drawing.Point(3, 3);
            this.btn_klasorYenile.Name = "btn_klasorYenile";
            this.btn_klasorYenile.Size = new System.Drawing.Size(16, 16);
            this.btn_klasorYenile.TabIndex = 8;
            this.btn_klasorYenile.UseVisualStyleBackColor = true;
            this.btn_klasorYenile.Click += new System.EventHandler(this.btn_klasorYenile_Click);
            // 
            // btn_ara
            // 
            this.btn_ara.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ara.BackgroundImage = global::MasaUstuDuzenleyici.Properties.Resources.search_13_16__2_;
            this.btn_ara.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_ara.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ara.FlatAppearance.BorderSize = 0;
            this.btn_ara.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_ara.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_ara.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ara.ForeColor = System.Drawing.Color.Transparent;
            this.btn_ara.Location = new System.Drawing.Point(565, 2);
            this.btn_ara.Name = "btn_ara";
            this.btn_ara.Size = new System.Drawing.Size(18, 18);
            this.btn_ara.TabIndex = 7;
            this.btn_ara.UseVisualStyleBackColor = true;
            this.btn_ara.Click += new System.EventHandler(this.btn_ara_Click);
            // 
            // btn_Tumu
            // 
            this.btn_Tumu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Tumu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Tumu.FlatAppearance.BorderSize = 0;
            this.btn_Tumu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Tumu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Tumu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Tumu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_Tumu.Location = new System.Drawing.Point(514, 1);
            this.btn_Tumu.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Tumu.Name = "btn_Tumu";
            this.btn_Tumu.Size = new System.Drawing.Size(46, 19);
            this.btn_Tumu.TabIndex = 6;
            this.btn_Tumu.Text = "Tümü";
            this.btn_Tumu.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Tumu.UseVisualStyleBackColor = true;
            this.btn_Tumu.Click += new System.EventHandler(this.btn_Tumu_Click);
            // 
            // btn_Sirala
            // 
            this.btn_Sirala.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Sirala.FlatAppearance.BorderSize = 0;
            this.btn_Sirala.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Sirala.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Sirala.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_Sirala.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.btn_Sirala.Location = new System.Drawing.Point(180, 1);
            this.btn_Sirala.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Sirala.Name = "btn_Sirala";
            this.btn_Sirala.Size = new System.Drawing.Size(44, 19);
            this.btn_Sirala.TabIndex = 5;
            this.btn_Sirala.Text = "A - Z";
            this.btn_Sirala.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn_Sirala.UseVisualStyleBackColor = true;
            this.btn_Sirala.Click += new System.EventHandler(this.btn_Sirala_Click);
            // 
            // lbl_ToplamBoyut
            // 
            this.lbl_ToplamBoyut.AutoSize = true;
            this.lbl_ToplamBoyut.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(90)))), ((int)(((byte)(90)))));
            this.lbl_ToplamBoyut.Location = new System.Drawing.Point(25, 5);
            this.lbl_ToplamBoyut.Name = "lbl_ToplamBoyut";
            this.lbl_ToplamBoyut.Size = new System.Drawing.Size(82, 13);
            this.lbl_ToplamBoyut.TabIndex = 0;
            this.lbl_ToplamBoyut.Text = "Dosya Sayısı : 0";
            // 
            // btn_Yenile
            // 
            this.btn_Yenile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Yenile.BackgroundImage = global::MasaUstuDuzenleyici.Properties.Resources.sinchronize_16;
            this.btn_Yenile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_Yenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Yenile.FlatAppearance.BorderSize = 0;
            this.btn_Yenile.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_Yenile.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_Yenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Yenile.Location = new System.Drawing.Point(591, 3);
            this.btn_Yenile.Name = "btn_Yenile";
            this.btn_Yenile.Size = new System.Drawing.Size(16, 16);
            this.btn_Yenile.TabIndex = 4;
            this.btn_Yenile.UseVisualStyleBackColor = true;
            this.btn_Yenile.Click += new System.EventHandler(this.btn_Yenile_Click);
            // 
            // bgw_YukAzaltici
            // 
            this.bgw_YukAzaltici.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bgw_YukAzaltici_DoWork);
            this.bgw_YukAzaltici.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.bgw_YukAzaltici_ProgressChanged);
            this.bgw_YukAzaltici.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.bgw_YukAzaltici_RunWorkerCompleted);
            // 
            // btn_uygula
            // 
            this.btn_uygula.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_uygula.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_uygula.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_uygula.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.btn_uygula.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_uygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn_uygula.ForeColor = System.Drawing.Color.White;
            this.btn_uygula.Location = new System.Drawing.Point(253, 21);
            this.btn_uygula.Name = "btn_uygula";
            this.btn_uygula.Size = new System.Drawing.Size(145, 37);
            this.btn_uygula.TabIndex = 6;
            this.btn_uygula.Text = "Masaüstünü Düzenle";
            this.btn_uygula.UseVisualStyleBackColor = false;
            this.btn_uygula.Click += new System.EventHandler(this.btn_uygula_Click);
            this.btn_uygula.MouseEnter += new System.EventHandler(this.btnTum_MouseEnter);
            this.btn_uygula.MouseLeave += new System.EventHandler(this.btnTum_MouseLeave);
            // 
            // btn_geri
            // 
            this.btn_geri.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_geri.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_geri.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_geri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_geri.FlatAppearance.BorderSize = 0;
            this.btn_geri.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btn_geri.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btn_geri.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_geri.ForeColor = System.Drawing.Color.White;
            this.btn_geri.Image = global::MasaUstuDuzenleyici.Properties.Resources.arrow_89_24;
            this.btn_geri.Location = new System.Drawing.Point(198, 28);
            this.btn_geri.Name = "btn_geri";
            this.btn_geri.Size = new System.Drawing.Size(15, 25);
            this.btn_geri.TabIndex = 25;
            this.btn_geri.UseVisualStyleBackColor = false;
            this.btn_geri.Click += new System.EventHandler(this.btn_geri_Click);
            this.btn_geri.MouseEnter += new System.EventHandler(this.btnTum_MouseEnter);
            this.btn_geri.MouseLeave += new System.EventHandler(this.btnTum_MouseLeave);
            // 
            // btnAyarlar
            // 
            this.btnAyarlar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAyarlar.BackColor = System.Drawing.Color.Transparent;
            this.btnAyarlar.BackgroundImage = global::MasaUstuDuzenleyici.Properties.Resources.settings;
            this.btnAyarlar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAyarlar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAyarlar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnAyarlar.FlatAppearance.BorderSize = 0;
            this.btnAyarlar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.btnAyarlar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.btnAyarlar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAyarlar.ForeColor = System.Drawing.Color.White;
            this.btnAyarlar.Location = new System.Drawing.Point(566, 12);
            this.btnAyarlar.Name = "btnAyarlar";
            this.btnAyarlar.Size = new System.Drawing.Size(36, 36);
            this.btnAyarlar.TabIndex = 24;
            this.btnAyarlar.UseVisualStyleBackColor = false;
            this.btnAyarlar.Click += new System.EventHandler(this.btnAyarlar_Click);
            this.btnAyarlar.MouseEnter += new System.EventHandler(this.btnAyarlar_MouseEnter);
            this.btnAyarlar.MouseLeave += new System.EventHandler(this.btnAyarlar_MouseLeave);
            // 
            // lbl_adimSayi
            // 
            this.lbl_adimSayi.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_adimSayi.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_adimSayi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lbl_adimSayi.Location = new System.Drawing.Point(214, 19);
            this.lbl_adimSayi.Name = "lbl_adimSayi";
            this.lbl_adimSayi.Size = new System.Drawing.Size(31, 34);
            this.lbl_adimSayi.TabIndex = 27;
            this.lbl_adimSayi.Text = "➊";
            this.lbl_adimSayi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frm_AnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 405);
            this.Controls.Add(this.btn_geri);
            this.Controls.Add(this.lbl_adimSayi);
            this.Controls.Add(this.btnAyarlar);
            this.Controls.Add(this.pnl_Durum);
            this.Controls.Add(this.sc_BolmeliKutu);
            this.Controls.Add(this.lbl_adim);
            this.Controls.Add(this.cmb_secim);
            this.Controls.Add(this.btn_uygula);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frm_AnaForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Masaüstü Düzenleyici";
            this.Load += new System.EventHandler(this.frm_AnaForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frm_AnaForm_KeyDown);
            this.sc_BolmeliKutu.Panel1.ResumeLayout(false);
            this.sc_BolmeliKutu.Panel2.ResumeLayout(false);
            this.sc_BolmeliKutu.ResumeLayout(false);
            this.pnl_Durum.ResumeLayout(false);
            this.pnl_Durum.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Yenile;
        private System.Windows.Forms.ComboBox cmb_secim;
        private System.Windows.Forms.Button btn_uygula;
        private System.Windows.Forms.Label lbl_adim;
        private System.Windows.Forms.SplitContainer sc_BolmeliKutu;
        private System.Windows.Forms.ListView lsv_Icerik;
        private System.Windows.Forms.Panel pnl_Durum;
        private System.Windows.Forms.Label lbl_ToplamBoyut;
        private System.Windows.Forms.FlowLayoutPanel flp_Butonlar;
        private System.Windows.Forms.ImageList lil_resimler;
        private System.ComponentModel.BackgroundWorker bgw_YukAzaltici;
        private System.Windows.Forms.Button btnAyarlar;
        private System.Windows.Forms.Button btn_geri;
        private System.Windows.Forms.Button btn_Sirala;
        private System.Windows.Forms.Button btn_Tumu;
        private System.Windows.Forms.Button btn_ara;
        private System.Windows.Forms.Label lbl_adimSayi;
        private System.Windows.Forms.Button btn_klasorYenile;
    }
}