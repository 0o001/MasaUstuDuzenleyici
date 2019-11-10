using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MasaUstuDuzenleyici
{
    public partial class frm_Ayarlar : Form
    {
        
        public frm_Ayarlar()
        {
            InitializeComponent();
        }
        private void frm_Ayarlar_Load(object sender, EventArgs e)
        {
            chk_Eminmisiniz.Checked = Ayarlar.Default.eminmisiniz;
            chk_baslangic.Checked = Ayarlar.Default.baslangic;
            chk_sagtik.Checked = Ayarlar.Default.sagtik;
        }

        private void chk_Eminmisiniz_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_Eminmisiniz.Checked)
            {
                Ayarlar.Default.eminmisiniz = true;
            }
            else
            {
                Ayarlar.Default.eminmisiniz = false; 
            }
                
        }

        private void chk_baslangic_CheckedChanged(object sender, EventArgs e)
        {
           
            //if(chk_baslangic.Checked)
            //{

            //}
            //else
            //{

            //}
        }

        private void chk_sagtik_CheckedChanged(object sender, EventArgs e)
        {
            
            //if (chk_sagtik.Checked)
            //{

            //}
            //else
            //{

            //}
        }

        private void chk_sagtik_Click(object sender, EventArgs e)
        {
            chk_sagtik.Checked = false;
            MessageBox.Show("Bu özelliğe sahip olmak için uygulamayı tam sürüme yükseltmeniz gerekmektedir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void chk_baslangic_Click(object sender, EventArgs e)
        {
            chk_baslangic.Checked = false;
            MessageBox.Show("Bu özelliğe sahip olmak için uygulamayı tam sürüme yükseltmeniz gerekmektedir.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
