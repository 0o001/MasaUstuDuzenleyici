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
    public partial class frm_Bilgi : Form
    {
        public frm_Bilgi()
        {
            InitializeComponent();
            time_OpeningEffect.Start();
        }

        private void frm_Bilgi_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void time_OpeningEffect_Tick(object sender, EventArgs e)
        {
            this.Opacity += 0.1;
            if (Opacity == 1)
            {
                time_OpeningEffect.Stop();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
