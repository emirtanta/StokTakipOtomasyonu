using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmUrunEkle : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        public frmUrunEkle()
        {
            InitializeComponent();
        }

        bool durum;

        /// <summary>
        /// aynı barkod no değerinden barkod eklenmesini önler
        /// </summary>
        private void BarkodKontrol()
        {
            durum = true;

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblUrun", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (txtMevcutUrunBarkodNo.Text == dr["BarkodNo"].ToString() || txtMevcutUrunBarkodNo.Text=="")
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }

        /// <summary>
        /// kategorileri getirir
        /// </summary>
        private void KategoriGetir()
        {
            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblKategori", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbYeniUrunKategori.Properties.Items.Add(dr["Kategori"]).ToString();
            }

            baglanti.Close();
        }


        private void frmUrunEkle_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        /// <summary>
        /// kategoriye bağlı markayı getirir
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbYeniUrunKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbYeniUrunMarka.Properties.Items.Clear();
            cmbYeniUrunMarka.Text = "";


            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblMarka where Kategori=@kategori", baglanti);
            command.Parameters.AddWithValue("@kategori",cmbYeniUrunKategori.SelectedItem);//seçilen kategoriye göre markayı getirir
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbYeniUrunMarka.Properties.Items.Add(dr["Marka"]).ToString();
            }

            baglanti.Close();
        }

        private void btnYeniUrunEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();

            if (durum==true)
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Insert Into TblUrun (BarkodNo,Kategori,Marka,UrunAdi,Miktari,AlisFiyati,SatisFiyati,Tarih) values(@barkodNo,@kategori,@marka,@urunAdi,@miktari,@alisFiyati,@satisFiyati,@tarih)", baglanti);
                command.Parameters.AddWithValue("@barkodNo", txtYeniUrunBarkodNo.Text);
                command.Parameters.AddWithValue("@kategori", cmbYeniUrunKategori.Text);
                command.Parameters.AddWithValue("@marka", cmbYeniUrunMarka.Text);
                command.Parameters.AddWithValue("@urunAdi", txtYeniUrunAdi.Text);
                command.Parameters.AddWithValue("@miktari", int.Parse(txtYeniUrunMiktar.Text));
                command.Parameters.AddWithValue("@alisFiyati", decimal.Parse(txtYeniUrunAlisFiyat.Text));
                command.Parameters.AddWithValue("@satisFiyati", decimal.Parse(txtYeniUrunSatisFiyat.Text));
                command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());


                command.ExecuteNonQuery();

                baglanti.Close();

                XtraMessageBox.Show("Ürün eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                XtraMessageBox.Show("Böyle bir barkod bulunmaktadır", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            cmbYeniUrunMarka.Properties.Items.Clear();

            //nesnelerin içerisini temizler
            foreach (Control item in groupControl1.Controls)
            {
                if (item is TextEdit)
                {
                    item.Text = "";
                }

                if (item is ComboBoxEdit)
                {
                    item.Text = "";
                }
            }
        }

        //barkod numarası girildiğinde o numaraya ait bilgileri hedef nesnelere getirilmesi için tanımlandı
        private void txtMevcutUrunBarkodNo_EditValueChanged(object sender, EventArgs e)
        {
            //mevcut barkod no alanı boşsa nesnelerin içerisini temizler
            if (txtMevcutUrunBarkodNo.Text=="")
            {
                lblMiktari.Text = "";

                foreach (Control item in groupControl2.Controls)
                {
                    if (item is TextEdit)
                    {
                        item.Text = "";
                    }
                }
            }

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * from TblUrun where BarkodNo Like '" + txtMevcutUrunBarkodNo.Text + "'", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtMevcutUrunKategori.Text = dr["Kategori"].ToString();
                txtMevcutUrunMarka.Text = dr["Marka"].ToString();
                txtMevcutUrunAdi.Text = dr["UrunAdi"].ToString();
                lblMiktari.Text = dr["Miktari"].ToString();
                txtMevcutUrunAlisFiyat.Text = dr["AlisFiyati"].ToString();
                txtMevcutUrunSatisFiyat.Text = dr["SatisFiyati"].ToString();
            }

            baglanti.Close();
        }

        private void btnMevcutUrunEkle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command = new SqlCommand("Update TblUrun Set Miktari=miktari+@miktari where BarkodNo=@barkodNo", baglanti);
            command.Parameters.AddWithValue("@miktari", int.Parse(txtMevcutUrunMiktar.Text));
            command.Parameters.AddWithValue("@barkodNo", txtMevcutUrunBarkodNo.Text);

            command.ExecuteNonQuery();

            baglanti.Close();

            foreach (Control item in groupControl2.Controls)
            {
                if (item is TextEdit)
                {
                    item.Text = "";
                }
            }

            XtraMessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}