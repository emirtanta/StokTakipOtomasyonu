using DevExpress.ClipboardSource.SpreadsheetML;
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
    public partial class frmMarka : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");


        bool durum;

        /// <summary>
        /// aynı marka adından marka eklenmesini önler
        /// </summary>
        private void MarkaKontrol()
        {
            durum = true;

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblMarka", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (cmbKategori.Text==dr["Kategori"].ToString() && txtMarkaAdi.Text == dr["Kategori"].ToString() || txtMarkaAdi.Text == "" || cmbKategori.Text=="")
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }


        public frmMarka()
        {
            InitializeComponent();
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
                cmbKategori.Properties.Items.Add(dr["Kategori"]).ToString();
            }

            baglanti.Close();
        }

        private void frmMarka_Load(object sender, EventArgs e)
        {
            KategoriGetir();
        }

        

        private void btnMarkaEkle_Click(object sender, EventArgs e)
        {
            MarkaKontrol();

            if (durum==true)
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("Insert Into TblMarka (Kategori,Marka) values(@kategori,@markaAdi)", baglanti);
                sqlCommand.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                sqlCommand.Parameters.AddWithValue("@kategori", txtMarkaAdi.Text);

                sqlCommand.ExecuteNonQuery();

                baglanti.Close();

                XtraMessageBox.Show("Marka Eklendi");
            }

            else
            {
                XtraMessageBox.Show("Bu marka ve kategori zaten var");
            }

            cmbKategori.Text = "";
            txtMarkaAdi.Text = "";
        }
    }
}