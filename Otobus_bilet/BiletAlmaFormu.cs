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
    public partial class BiletAlmaFormu : Form
    {
        MySqlDataAdapter da;
        MySqlCommand komut;
        MySqlConnection baglan;
        string cinsiyetdb;
        String koltukNo2;

        public BiletAlmaFormu()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            txtBiletNo.Text = "";
            txtAd.Text = "";
            txtSoyad.Text = "";
            txtTelefon.Text = "";
            cmbNereden.Text = "";
            cmbNereye.Text = "";
            dtpTarih.Text = "";
            txtFiyat.Text = "";
        }
        private void btnCıkıs_Click(object sender, EventArgs e)
        {
            this.Hide();
            AnaSayfaFormu asf = new AnaSayfaFormu();
            asf.ShowDialog();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtBiletNo.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtAd.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtTelefon.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            cmbNereden.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cmbNereye.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            dtpTarih.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txtFiyat.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
        }

        private void cmbOtobus_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbOtobus.Text)
            {
                case "Travego":
                    KoltukDoldur(8, false);
                    break;
                case "Setra":
                    KoltukDoldur(12, true);
                    break;
                case "Neoplan":
                    KoltukDoldur(10, false);
                    break;
                default:
                    break;
            }
        }

        void KoltukDoldur(int sira, bool arkaBesliMi)
        {
        yavaslat:
            foreach (Control ctrl in this.Controls)
            {
                if (ctrl is Button)
                {
                    Button btn = ctrl as Button;

                    if (btn.Text == "Kaydet")
                    {
                        continue;
                    }
                    else
                    {
                        this.Controls.Remove(ctrl);
                        goto yavaslat;
                    }
                }
            }

            int koltukNo = 1;
            for (int i = 0; i < sira; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == sira / 2 && j > 2)
                    {
                        continue;
                    }
                    if (arkaBesliMi == true)
                    {
                        if (i != sira - 1 && j == 2)
                        {
                            continue;
                        }
                    }
                    else
                    {
                        if (j == 2)
                            continue;
                    }

                    Button koltuk = new Button();
                    koltuk.Height = koltuk.Width = 45;
                    koltuk.Top = 30 + (i * 45);
                    koltuk.Left = 5 + (j * 45);
                    koltuk.Text = koltukNo.ToString();
                    koltukNo++;
                    koltuk.ContextMenuStrip = contextMenuStrip1;
                    koltuk.MouseDown += koltuk_MouseDown;
                    this.Controls.Add(koltuk);
                }
            }
        }
        Button tiklanan;
        void koltuk_MouseDown(object sender, MouseEventArgs e)
        {
            tiklanan = sender as Button;
            koltukNo2 = tiklanan.Text;
        }

        private void rezerveEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cmbOtobus.SelectedIndex == -1 || cmbNereden.SelectedIndex == -1 || cmbNereye.SelectedIndex == -1 || txtAd.Text==""|| txtSoyad.Text==""||txtTelefon.Text=="")
            {
                MessageBox.Show("Lütfen Gerekli Alanları Doldurunuz!");
                return;
            }

                if (rdbErkek.Checked)
                {
                    cinsiyetdb = "Erkek";
                    tiklanan.BackColor = Color.Aqua;
                }
                if (rdbKadın.Checked)
                {
                    cinsiyetdb = "Kadın";
                    tiklanan.BackColor = Color.Pink;
                }

        }



        void musteriGetir()
        {
            string _server = "localhost";
            string _dbname = "kuleliturizm";
            string _user = "root";
            string _password = "Kuleli172@";

            string MySQLbaglanti = $"SERVER={_server};DATABASE={_dbname};UID={_user};PWD={_password}";

            using ( baglan = new MySqlConnection(MySQLbaglanti))
            {
                try
                {
                    baglan.Open();
                    da = new MySqlDataAdapter("SELECT *FROM satılan_bilet", baglan);
                    DataTable tablo = new DataTable();
                    da.Fill(tablo);
                    dataGridView1.DataSource = tablo;
                    baglan.Close();

                }
                catch (Exception hata)
                {
                    MessageBox.Show("Bağlantı Yapılamadı... Nedeni: \n" + hata.ToString(), "Hata :" + hata.Message, MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }

        }

        private void BiletAlmaFormu_Load(object sender, EventArgs e)
        {
            musteriGetir();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;

            string sorgu = "INSERT INTO satılan_bilet(idsatılan_bilet,ad,soyad,telefon_no,cinsiyet,nereden,nereye,koltuk_no,tarih,fiyat) VALUES" +
                " (@idsatılan_bilet,@ad,@soyad,@telefon_no,@cinsiyet,@nereden,@nereye,@koltuk_no,@tarih,@fiyat)";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@idsatılan_bilet", txtBiletNo.Text);
            komut.Parameters.AddWithValue("@ad",txtAd.Text);
            komut.Parameters.AddWithValue("@soyad",txtSoyad.Text);
            komut.Parameters.AddWithValue("@telefon_no",txtTelefon.Text);
            komut.Parameters.AddWithValue("@cinsiyet", cinsiyetdb);
            komut.Parameters.AddWithValue("@nereden", cmbNereden.Text);
            komut.Parameters.AddWithValue("@nereye", cmbNereye.Text);
            komut.Parameters.AddWithValue("@koltuk_no", koltukNo2);
            komut.Parameters.AddWithValue("@tarih", dtpTarih.Value);
            komut.Parameters.AddWithValue("@fiyat", txtFiyat.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            musteriGetir();

        }

        private void btnIptal_Click_1(object sender, EventArgs e)
        {
            
        }

        private void btnSil_Click(object sender, EventArgs e)
        {

        }


        private void btnSil_Click_1(object sender, EventArgs e)
        {
            String sorgu = "DELETE FROM satılan_bilet WHERE idsatılan_bilet=@idsatılan_bilet";
            komut = new MySqlCommand(sorgu, baglan);
            komut.Parameters.AddWithValue("@idsatılan_bilet", txtBiletNo.Text);
            baglan.Open();
            komut.ExecuteNonQuery();
            baglan.Close();
            musteriGetir();
        }


    }
}
