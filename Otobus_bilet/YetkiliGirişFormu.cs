using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Otobus_bilet
{
    public partial class YetkiliGirişFormu : Form
    {
        public YetkiliGirişFormu()
        {
            InitializeComponent();
        }

        private void btnBaglan_Click(object sender, EventArgs e)
        {
            string _server = txtSunucu.Text;
            string _dbname = txtdbname.Text;
            string _user = txtuserName.Text;
            string _password = txtPass.Text;

            string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

            if(string.IsNullOrEmpty(txtSunucu.Text)==true || string.IsNullOrEmpty(txtdbname.Text)==true || string.IsNullOrEmpty(txtuserName.Text)==true || string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Alanlar Boş Bırakılamaz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                using (var baglan = new MySqlConnection(MySQLbaglanti))
                {
                    try
                    {
                        baglan.Open();
                        lblHataMesajı.Text = "Veritabanına Bağlandı...";
                        lblHataMesajı.ForeColor = Color.Green;

                        BiletAlmaFormu baf = new BiletAlmaFormu();
                        
                        baf.Show();
                        this.Hide();
                        baglan.Close();

                    }
                    catch (Exception hata)
                    {
                        MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(),"Hata :"+hata.Message,MessageBoxButtons.OK,MessageBoxIcon.Error);
                        
                    }

                }
            }

        }

        private void YetkiliGirişFormu_Shown(object sender, EventArgs e)
        {

        }

        private void txtSunucu_TextChanged(object sender, EventArgs e)
        {
            txtSunucu.Focus();
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void YetkiliGirişFormu_Load(object sender, EventArgs e)
        {

        }
    }
}
