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
    public partial class frmUrunListele : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        public frmUrunListele()
        {
            InitializeComponent();
        }

        DataSet daset = new DataSet();

        /// <summary>
        /// ürünleri getirir
        /// </summary>
        private void UrunListele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblUrun", baglanti);
            da.Fill(daset, "TblUrun");

            gridControlUrunListesi.DataSource = daset.Tables["TblUrun"];

            baglanti.Close();
        }

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

        private void MarkaGetir()
        {
        }

        private void frmUrunListele_Load(object sender, EventArgs e)
        {
            UrunListele();

            KategoriGetir();
        }

        //gridview nesnesinde satıra çift tıklandığında verileri hedef nesnelere getirir
        private void gridViewUrunListesi_DoubleClick(object sender, EventArgs e)
        {
            // GridView'da çift tıklanan satırı al
            var hitInfo = gridViewUrunListesi.CalcHitInfo(gridControlUrunListesi.PointToClient(Control.MousePosition));

            //seçili satırdaki verileri alır
            int selectedRowHandle = hitInfo.RowHandle;
            txtBarkodNo.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "BarkodNo").ToString();
            txtKategori.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "Kategori").ToString();
            txtMarka.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "Marka").ToString();
            txtUrunAdi.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "UrunAdi").ToString();
            txtMiktari.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "Miktari").ToString();
            txtAlisFiyati.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "AlisFiyati").ToString();
            txtSatisFiyati.Text = gridViewUrunListesi.GetRowCellValue(selectedRowHandle, "SatisFiyati").ToString();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command = new SqlCommand("Update TblUrun Set UrunAdi=@urunAdi,Miktari=@miktari,AlisFiyati=@alisFiyati,SatisFiyati=@satisFiyati,Tarih=@tarih Where BarkodNo=@barkodNo", baglanti);
            command.Parameters.AddWithValue("@urunAdi",txtUrunAdi.Text);
            command.Parameters.AddWithValue("@miktari",int.Parse(txtMiktari.Text));
            command.Parameters.AddWithValue("@alisFiyati",decimal.Parse(txtAlisFiyati.Text));
            command.Parameters.AddWithValue("@satisFiyati",decimal.Parse(txtSatisFiyati.Text));
            command.Parameters.AddWithValue("@tarih",DateTime.Now.ToString());
            command.Parameters.AddWithValue("@barkodNo",txtBarkodNo.Text);

            command.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["TblUrun"].Clear();

            UrunListele();

            XtraMessageBox.Show("Ürün güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            foreach (Control item in groupControl2.Controls)
            {
                if (item is TextEdit)
                {
                    item.Text = "";
                }
            }
        }

        private void btnMarkaKategoriGuncelle_Click(object sender, EventArgs e)
        {
            if (txtBarkodNo.Text!="")
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Update TblUrun Set Kategori=@kategori,Marka=@marka Where BarkodNo=@barkodNo", baglanti);
                command.Parameters.AddWithValue("@kategori", cmbKategori.Text);
                command.Parameters.AddWithValue("@marka", cmbMarka.Text);
                command.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);

                command.ExecuteNonQuery();

                baglanti.Close();

                daset.Tables["TblUrun"].Clear();

                UrunListele();

                XtraMessageBox.Show("Ürün kategori ve markası güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                XtraMessageBox.Show("Barkod numarası seçili değil!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            foreach (Control item in groupControl2.Controls)
            {
                if (item is ComboBoxEdit)
                {
                    item.Text = "";
                }
            }
        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbMarka.Properties.Items.Clear();


            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblMarka where Kategori=@kategori", baglanti);
            command.Parameters.AddWithValue("@kategori", cmbKategori.SelectedItem);//seçilen kategoriye göre markayı getirir
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbMarka.Properties.Items.Add(dr["Marka"]).ToString();
            }

            baglanti.Close();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sqlCommand = new SqlCommand("Delete From TblUrun Where BarkodNo=@barkodNo", baglanti);
            sqlCommand.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);

            sqlCommand.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["TblUrun"].Clear();

            UrunListele();

            XtraMessageBox.Show("Ürün Kaydı Silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //arama kısmında girilen barkod değerine göre griview içersinde arama yapar
        private void txtBarkodNoAra_EditValueChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();

            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblUrun Where BarkodNo Like '%"+txtBarkodNo.Text+"%'", baglanti);
            da.Fill(dt);

            gridControlUrunListesi.DataSource = dt;

            baglanti.Close();
        }
    }
}