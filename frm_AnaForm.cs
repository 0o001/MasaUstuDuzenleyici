using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MasaUstuDuzenleyici
{
    public partial class frm_AnaForm : Form
    {
        [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Auto)]
        public struct SHFILEINFO
        {
            public IntPtr hIcon;
            public int iIcon;
            public uint dwAttributes;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 260)]
            public string szDisplayName;
            [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 80)]
            public string szTypeName;
        };

        public enum FolderType
        {
            Closed,
            Open
        }

        public enum IconSize
        {
            Large,
            Small
        }
        #region Sürücü, dosya ve klasör ikonlarını çekmek

        [DllImport("shell32.dll", CharSet = CharSet.Auto)]
        public static extern IntPtr SHGetFileInfo(string pszPath, uint dwFileAttributes, out SHFILEINFO psfi, uint cbFileInfo, uint uFlags);

        [DllImport("user32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool DestroyIcon(IntPtr hIcon);

        public const uint SHGFI_ICON = 0x000000100;
        public const uint SHGFI_USEFILEATTRIBUTES = 0x000000010;
        public const uint SHGFI_OPENICON = 0x000000002;
        public const uint SHGFI_SMALLICON = 0x000000001;
        public const uint SHGFI_LARGEICON = 0x000000000;
        public const uint FILE_ATTRIBUTE_DIRECTORY = 0x00000010;

        public static Icon GetFolderIcon(IconSize size, FolderType folderType, string yer)
        {
            // Need to add size check, although errors generated at present!    
            uint flags = SHGFI_ICON | SHGFI_USEFILEATTRIBUTES;

            if (FolderType.Open == folderType)
            {
                flags += SHGFI_OPENICON;
            }
            if (IconSize.Small == size)
            {
                flags += SHGFI_SMALLICON;
            }
            else
            {
                flags += SHGFI_LARGEICON;
            }
            // Get the folder icon    
            var shfi = new SHFILEINFO();

            var res = SHGetFileInfo(@yer,
                FILE_ATTRIBUTE_DIRECTORY,
                out shfi,
                (uint)Marshal.SizeOf(shfi),
                flags);

            if (res == IntPtr.Zero)
                throw Marshal.GetExceptionForHR(Marshal.GetHRForLastWin32Error());

            // Load the icon from an HICON handle  
            Icon.FromHandle(shfi.hIcon);

            // Now clone the icon, so that it can be successfully stored in an ImageList
            var icon = (Icon)Icon.FromHandle(shfi.hIcon).Clone();

            DestroyIcon(shfi.hIcon);        // Cleanup    
            return icon;
        }
        #endregion
        [DllImport("uxtheme.dll", ExactSpelling = true, CharSet = CharSet.Unicode)] //UIX
        private static extern int SetWindowTheme(IntPtr hwnd, string pszSubAppName, string pszSubIdList);
        string[] cmb;
        string btn_SonTiklananButonAdi = "";
        public frm_AnaForm()
        {
            CheckForIllegalCrossThreadCalls = false; // Çekirdekteki tüm threadleri kullan
            InitializeComponent();
            cmb_secim.SelectedIndex = 0;
            lsv_Icerik.Columns.Add("dosyaAdi", -2);
            lsv_Icerik.HeaderStyle = ColumnHeaderStyle.None;

            ButonOlusturucu();
            bgw_YukAzaltici.RunWorkerAsync();// Aynı anda yapılacak başka işler

        }
        byte adim = 1;
        MoveFile class_movefile = new MoveFile();

        public void Adimla()
        {
            switch (adim)
            {
                case 1:
                    btn_geri.Hide();
                    btn_uygula.Visible = true;
                    btn_uygula.Text = "Masaüstünü Düzenle";
                    cmb_secim.Visible = false;
                    lbl_adimSayi.Text = "➊";
                    lbl_adim.Text = "[2]. Adım: Dosyalarınızı neye göre düzeleyelim?";
                    btn_geri.Visible = false;
                    lbl_ToplamBoyut.Text = "";
                    break;
                case 2:
                    btn_uygula.Visible = false;
                    cmb_secim.Visible = true;
                    cmb_secim.Location = new Point(this.Width/2-55, 25);
                    lbl_adimSayi.Text = "➋";
                    lbl_adim.Text = "[3]. Adım: Gözden geçirme ve önizleme...";
                    lbl_ToplamBoyut.Text = "";
                    btn_geri.Visible = true;
                    break;
                case 3:
                    lbl_adimSayi.Text = "➌";
                    btn_uygula.Visible = true;
                    cmb_secim.Visible = false;
                    btn_uygula.Text = "İşleme Başla!";
                    lbl_adim.Text = "[4]. Adım: Düzenleme İşlemi";
                    btn_geri.Visible = true;
                    break;
                case 4:
                    lbl_adimSayi.Text = "➍";
                    btn_uygula.Visible = false;
                    lbl_adim.Text = "Geri dönmek isterseniz [<] tuşuna basınız.";
                    btn_geri.Visible = true;
                    if (Ayarlar.Default.eminmisiniz)
                    {
                        if (DialogResult.Yes == MessageBox.Show("Dosyalarınız \"Düzenli\" isimli bir klasöre taşınacak, onaylıyor musunuz?", "Dikkat", MessageBoxButtons.YesNo, MessageBoxIcon.Information))
                        {
                            class_movefile.KategoriyeGore(true);
                            MessageBox.Show("Masaüstünüz artık düzenli!", "Tebrikler...", MessageBoxButtons.OK, MessageBoxIcon.None);
                            flp_Butonlar.Controls.Clear();
                            lsv_Icerik.Items.Clear();
                            ButonOlusturucu();
                            if (flp_Butonlar.Controls.Count > 0)
                            {
                                (flp_Butonlar.Controls[0] as Button).PerformClick();
                                lbl_ToplamBoyut.Text = (flp_Butonlar.Controls[0] as Button).Text + " Sayısı : " + lsv_Icerik.Items.Count.ToString();
                            }
                        }
                    }
                    else
                    {
                        class_movefile.KategoriyeGore(true);
                        MessageBox.Show("Masaüstünüz artık düzenli!", "Tebrikler...", MessageBoxButtons.OK, MessageBoxIcon.None);
                    }
                    adim = 1;
                    Adimla();
                    break;
                default:
                    break;
            }
        }

        private void btn_geri_Click(object sender, EventArgs e)
        {
            adim--;
            bgw_YukAzaltici.RunWorkerAsync();
        }
        private void btnTum_MouseEnter(object sender, EventArgs e)
        {
            //(sender as Button).BackColor = Color.White;
            //(sender as Button).ForeColor = Color.FromArgb(0, 122, 204);
        }
        private void btnTum_MouseLeave(object sender, EventArgs e)
        {
            //(sender as Button).BackColor = Color.FromArgb(0, 122, 204);
            //(sender as Button).ForeColor = Color.White;
        }

        private void cmb_secim_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (adim != 1)
            {
                adim++;
                Adimla();
                if (cmb_secim.SelectedIndex == 1)
                {
                    frm_Bilgi bilgi = new frm_Bilgi();
                    bilgi.Show();
                }
            }
        }

        #region Sol Menüdeki Butonlar
        public void ButonOlusturucu()
        {
            int i = 0;
            foreach (var a in DosyaUzantisi.uzantilar)
            {
                MoveFile.tiklananKategori = a.Key;
                class_movefile.KategoriyeGore(false);
                if (MoveFile.dosyaismi.Count > 0)
                {
                    Button btn = new Button();
                    btn.BackColor = Color.FromArgb(255, Color.FromArgb(DosyaUzantisi.renkler[i]));

                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.Font = new Font("", 9f, FontStyle.Regular);
                    btn.Name = i.ToString();
                    btn.Text = a.Key;
                    btn.Size = new Size(163, 45);
                    btn.Margin = new Padding(0);
                    btn.FlatStyle = FlatStyle.Flat;
                    flp_Butonlar.Controls.Add(btn);
                    btn.Click += new EventHandler(this.btnKategori_Click);                    
                }   i++;
            }

            if (System.IO.Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)).Length > 0)
            {
                Button btnKlasor = new Button();
                btnKlasor.BackColor = Color.FromArgb(255,Color.FromArgb(0xffeb3b));
                btnKlasor.ForeColor = Color.White;
                btnKlasor.FlatAppearance.BorderSize = 0;
                btnKlasor.Font = new Font("", 9f, FontStyle.Regular);
                btnKlasor.Name = i.ToString();
                btnKlasor.Text = "Klasörler";
                btnKlasor.Size = new Size(163, 45);
                btnKlasor.Margin = new Padding(0);
                btnKlasor.FlatStyle = FlatStyle.Flat;
                flp_Butonlar.Controls.Add(btnKlasor);
                //i++;
                btnKlasor.Click += BtnKlasor_Click;
            }

        }

        private void BtnKlasor_Click(object sender, EventArgs e)
        {
                ImageList prog_ikonlar = new ImageList();
                prog_ikonlar.ImageSize = new System.Drawing.Size(32, 32);
                prog_ikonlar.ColorDepth = ColorDepth.Depth32Bit;
                    int x = 0;
                    lsv_Icerik.Items.Clear();
                    foreach (var item in System.IO.Directory.GetDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop)))
                    {
                        Icon ico = GetFolderIcon(IconSize.Large, FolderType.Open, Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + item.Substring(item.LastIndexOf('\\') + 1));
                        prog_ikonlar.Images.Add(ico);
                        lsv_Icerik.Items.Add(item.Substring(item.LastIndexOf('\\') + 1), x);
                        x++;
                    }
                    lsv_Icerik.SmallImageList = prog_ikonlar;
            //btn_SonTiklananButonAdi = (sender as Button).Text; // Ok resminin hangi butonda kalacağını anlamak için
            lbl_ToplamBoyut.Text = "Klasör Sayısı : " + lsv_Icerik.Items.Count.ToString();
            btnKategori_ImageOrNot(sender, e);          // Butona ok resmi eklenecekmi yoksa eklenmeyecekmi

        }

        private void btnKategori_Click(object sender, EventArgs e)
        {
            Button btnKategori = (sender as Button);
            ListViewDoldurucu(btnKategori, btnKategori.Text, Convert.ToInt32(btnKategori.Name));
            btn_SonTiklananButonAdi = btnKategori.Text; // Ok resminin hangi butonda kalacağını anlamak için
                      // Butona ok resmi eklenecekmi yoksa eklenmeyecekmi
            lbl_ToplamBoyut.Text = btnKategori.Text+" Sayısı : " + lsv_Icerik.Items.Count.ToString();
            btnKategori_ImageOrNot(sender, e);
        }
        public void ListViewDoldurucu(Button btn, string neyeGore, int resimNo)
        {
            if (lsv_Icerik.Items.Count != 0)        // ListView içini temizlemenin en iyi yolu...
            {
                //    for (int i = lsv_Icerik.Items.Count; i > 0; i--)
                //    {
                //        lsv_Icerik.Items.RemoveAt(i - 1);
                //    }
                lsv_Icerik.Items.Clear();
            }
            ImageList prog_ikonlar = new ImageList();
            prog_ikonlar.ImageSize = new System.Drawing.Size(32, 32);
            prog_ikonlar.ColorDepth = ColorDepth.Depth32Bit;
            MoveFile.tiklananKategori = neyeGore;
            class_movefile.KategoriyeGore(false);
            if (!(MoveFile.dosyaismi.Count <= 0))
            {
                int x = 0;
                foreach (string a in MoveFile.dosyaismi)
                {
                    prog_ikonlar.Images.Add(Icon.ExtractAssociatedIcon(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + a).ToBitmap()); //Eğer ikonu yoksa msiexec 
                    lsv_Icerik.Items.Add(a,x);
                    x++;
                }
                lsv_Icerik.SmallImageList = prog_ikonlar;
                lbl_ToplamBoyut.Text = btn.Text + " Sayısı : " + lsv_Icerik.Items.Count.ToString();
            }
            else
            {
                if(neyeGore != "Tümü")
                    btn.Dispose();
            }
        }
        private void btnKategori_ImageOrNot(object sender, EventArgs e)
        {
            Button btnKategori = (sender as Button);    // DinamikButton'lara ulaşmak için
            foreach (var a in flp_Butonlar.Controls)    // FlowLoyautPanel içerisindeki tüm Butonlar
            {
                (a as Button).Image = null;   // Diğer butonların resmini kaldırır
            }
            btnKategori.Image = Properties.Resources.arrow; // Tıklanan Butona ok resmini koyar
            btnKategori.ImageAlign = ContentAlignment.MiddleRight; // Resmin nerede görüneceğini belirler
            lbl_ToplamBoyut.Text = btnKategori.Text+" Sayısı : " + lsv_Icerik.Items.Count.ToString();

        }
        #endregion

        private void bgw_YukAzaltici_DoWork(object sender, DoWorkEventArgs e)
        {
            Adimla();
        }

        private void bgw_YukAzaltici_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            //progressBar1.Value = e.ProgressPercentage;
        }

        private void bgw_YukAzaltici_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            //MessageBox.Show("Bitti");
        }

        private void btnAyarlar_MouseEnter(object sender, EventArgs e)
        {
            btnAyarlar.BackgroundImage = Properties.Resources.settings_hover;
        }

        private void btnAyarlar_MouseLeave(object sender, EventArgs e)
        {
            btnAyarlar.BackgroundImage = Properties.Resources.settings;
        }

        private void btnAyarlar_Click(object sender, EventArgs e)
        {
            frm_Ayarlar ayarlar = new frm_Ayarlar();
            ayarlar.ShowDialog();
        }

        private void frm_AnaForm_Load(object sender, EventArgs e)
        {
            SetWindowTheme(this.lsv_Icerik.Handle, "Explorer", null); //OS temasını alır
            SetWindowTheme(this.cmb_secim.Handle, "Explorer", null); //OS temasını alır
            if (flp_Butonlar.Controls.Count > 0)
            {
                (flp_Butonlar.Controls[0] as Button).PerformClick();
                lbl_ToplamBoyut.Text = (flp_Butonlar.Controls[0] as Button).Text + " Sayısı : " + lsv_Icerik.Items.Count.ToString();
            }
            
        }

        private void lsv_Icerik_SelectedIndexChanged(object sender, EventArgs e)
        {
            lsv_Icerik.DoDragDrop(lsv_Icerik.SelectedItems, DragDropEffects.Move);
        }

        #region ComboBox çizdirme
        private void cmb_secim_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Font font = new Font("Microsoft Sans Serif", 10f, FontStyle.Regular);
            StringFormat sf = new StringFormat();
            sf.LineAlignment = StringAlignment.Center;
            sf.Alignment = StringAlignment.Center;
            cmb = new string[2];
            cmb[0] = "Kategoriye göre";
            cmb[1] = "Tarihe göre";
            e.Graphics.DrawString(cmb[e.Index], font, Brushes.White, e.Bounds, sf);
            e.DrawFocusRectangle();
        }
        private void cmb_secim_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            switch (e.Index)
            {
                case 0:
                    e.ItemHeight = 23;
                    break;
                case 1:
                    e.ItemHeight = 23;
                    break;
            }
            e.ItemWidth = 130;
        }
        #endregion

        #region Button Click Olayları
        private void btn_uygula_Click(object sender, EventArgs e)
        {
            adim++;
            Adimla();
        }
        private void btn_Sirala_Click(object sender, EventArgs e)
        {
            if (lsv_Icerik.Sorting == SortOrder.Ascending)
            {
                lsv_Icerik.Sorting = SortOrder.Descending;
                btn_Sirala.Text = "A - Z";
            }
            else
            {
                lsv_Icerik.Sorting = SortOrder.Ascending;
                btn_Sirala.Text = "Z - A";
            }
        }
        private void btn_Tumu_Click(object sender, EventArgs e)
        {
            ListViewDoldurucu((sender as Button),"Tümü", 8);
            foreach (var item in flp_Butonlar.Controls)
            {
                (item as Button).Image = null;
            }
        }
        private void btn_Yenile_Click(object sender, EventArgs e)
        {
            lsv_Icerik.Items.Clear();
            foreach (var item in flp_Butonlar.Controls)
            {
                if((item as Button).Image != null)
                {
                    (item as Button).PerformClick();
                }
            }
        }

        #endregion

        private void lsv_Icerik_DoubleClick(object sender, EventArgs e)
        {
            if (lsv_Icerik.SelectedItems.Count == 1)
            {
                try
                {
                    System.Diagnostics.Process.Start(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\" + lsv_Icerik.SelectedItems[0].Text);
                }
                catch
                {

                }       
            }

        }

        private void lsv_Icerik_Resize(object sender, EventArgs e)
        {
            try
            {
                lsv_Icerik.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize); //Kolon boyutunu ayarla
            }
            catch { }
        }

        private void btn_klasorYenile_Click(object sender, EventArgs e)
        {
            flp_Butonlar.Controls.Clear();
            ButonOlusturucu();
            if (flp_Butonlar.Controls.Count > 0)
            {
                (flp_Butonlar.Controls[0] as Button).PerformClick();
            }
        }

        private void frm_AnaForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F && e.Modifiers == (Keys.Control))
            {
                AcAraKutusu();
            }
        }

        void AcAraKutusu()
        {
            try
                {
                System.Diagnostics.Process[] control = System.Diagnostics.Process.GetProcessesByName("masaustuara");
                if (control.Length > 0)
                {
                    foreach (var item in control)
                    {
                        item.Kill();
                    }
                }
                System.Diagnostics.Process.Start("masaustuara");
            }
                catch { }
        }
        private void sc_BolmeliKutu_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btn_ara_Click(object sender, EventArgs e)
        {
            AcAraKutusu();
        }
    }
}
