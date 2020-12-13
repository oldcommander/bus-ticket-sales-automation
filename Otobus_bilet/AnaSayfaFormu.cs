using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Otobus_bilet
{
    public partial class AnaSayfaFormu : DevExpress.XtraEditors.XtraForm
    {
        public AnaSayfaFormu()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnyetkiliGiris_Click(object sender, EventArgs e)
        {
            YetkiliGirişFormu ygm = new YetkiliGirişFormu();
            ygm.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
