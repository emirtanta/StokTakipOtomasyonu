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
    public partial class frmKategori : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        public frmKategori()
        {
            InitializeComponent();
        }

        bool durum;

        /// <summary>
        /// aynı kategori adından kategori eklenmesini önler
        /// </summary>
        private void KategoriKontrol()
        {
            durum = true;

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblKategori", baglanti);
            SqlDataReader dr=command.ExecuteReader();

            while (dr.Read())
            {
                if (txtKategoriAdi.Text == dr["Kategori"].ToString() || txtKategoriAdi.Text=="")
                {
                    durum = false;
                }
            }

            baglanti.Close();
        }

        private void frmKategori_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            KategoriKontrol();

            if (durum==true)
            {
                baglanti.Open();

                SqlCommand sqlCommand = new SqlCommand("Insert Into TblKategori (Kategori) values(@kategoriAdi)", baglanti);
                sqlCommand.Parameters.AddWithValue("@kategoriAdi", txtKategoriAdi.Text);

                sqlCommand.ExecuteNonQuery();

                baglanti.Close();

                XtraMessageBox.Show("Kategori Eklendi");
            }

            else
            {
                XtraMessageBox.Show("Bu kategori önceden eklenmiştir!");
            }

            txtKategoriAdi.Text = "";
        }
    }
}