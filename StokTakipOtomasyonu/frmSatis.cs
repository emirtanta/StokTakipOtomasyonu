using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace StokTakipOtomasyonu
{
    public partial class frmSatis : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        DataSet daset = new DataSet();

        /// <summary>
        /// sepetteki kayıtları getirir
        /// </summary>
        private void SepetListele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblSepet", baglanti);
            da.Fill(daset, "TblSepet");

            gridControl1.DataSource = daset.Tables["TblSepet"];
            gridView1.Columns[0].Visible = false; //0 indeks sütunu gizler (opsiyonel)
            gridView1.Columns[1].Visible = false; //1 indeks sütunu gizler (opsiyonel)
            gridView1.Columns[2].Visible = false; //2 indeks sütunu gizler (opsiyonel)


            baglanti.Close();
        }

        public frmSatis()
        {
            InitializeComponent();
        }

        private void btnMusteriEklemeSayfasi_Click(object sender, EventArgs e)
        {
            frmMusteriEkle frmMusteriEkle = new frmMusteriEkle();
            frmMusteriEkle.ShowDialog();
        }

        private void btnMusteriListelemeSayfasi_Click(object sender, EventArgs e)
        {
            frmMusteriListele frmMusteriListele = new frmMusteriListele();
            frmMusteriListele.ShowDialog();
        }

        private void btnUrunEklemeSayfasi_Click(object sender, EventArgs e)
        {
            frmUrunEkle frmUrunEkle = new frmUrunEkle();
            frmUrunEkle.ShowDialog();
        }

        private void btnMarkaEklemeSayfasi_Click(object sender, EventArgs e)
        {
            frmMarka frmMarka = new frmMarka();
            frmMarka.ShowDialog();
        }

        private void btnKategoriEklemeSayfasi_Click(object sender, EventArgs e)
        {
            frmKategori frmKategori = new frmKategori();
            frmKategori.ShowDialog();
        }

        private void btnUrunListelemeSayfasi_Click(object sender, EventArgs e)
        {
            frmUrunListele frmUrunListele = new frmUrunListele();
            frmUrunListele.ShowDialog();
        }

        private void Hesapla()
        {
            try
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Select SUM(ToplamFiyati) From TblSepet", baglanti);

                lblGenelToplam.Text = command.ExecuteScalar() + " ₺";

                baglanti.Close();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void frmSatis_Load(object sender, EventArgs e)
        {
            SepetListele();
            groupControl4.Visible = false;
        }

        private void txtTC_EditValueChanged(object sender, EventArgs e)
        {
            if (txtTC.Text == "")
            {
                txtAdSoyad.Text = "";
                txtTelefon.Text = "";
            }

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblMusteri Where TC Like '" + txtTC.Text + "'", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtAdSoyad.Text = dr["AdSoyad"].ToString();
                txtTelefon.Text = dr["Telefon"].ToString();
            }

            baglanti.Close();
        }

        private void txtBarkodNo_EditValueChanged(object sender, EventArgs e)
        {
            Temizle();

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblUrun Where BarkodNo Like '" + txtBarkodNo.Text + "'", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                txtUrunAdi.Text = dr["UrunAdi"].ToString();
                txtSatisFiyat.Text = dr["SatisFiyati"].ToString();
            }

            baglanti.Close();
        }

        private void Temizle()
        {
            if (txtBarkodNo.Text == "")
            {
                foreach (Control item in groupControl3.Controls)
                {
                    if (item is TextEdit)
                    {
                        if (item != txtMiktari)
                        {
                            item.Text = "";
                        }
                    }
                }
            }
        }

        bool durum;
        /// <summary>
        /// aynı barkod numaralı ürün sepette varsa sepete eklenen ürünün miktar değerini ekleyerek septte aynı barkod değerini alt alta getirmez
        /// </summary>
        private void BarkodKontrol()
        {
            durum = true;

            baglanti.Open();

            SqlCommand command = new SqlCommand("Select * From TblSepet", baglanti);
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                if (txtBarkodNo.Text == dr["BarkodNo"].ToString())
                {
                    durum = false;
                }
            }


            baglanti.Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            BarkodKontrol();

            if (durum == true)
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Insert Into TblSepet (TC,AdSoyad,Telefon,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@tc,@adSoyad,@telefon,@barkodNo,@urunAdi,@miktari,@satisFiyati,@toplamFiyati,@tarih)", baglanti);
                command.Parameters.AddWithValue("@tc", txtTC.Text);
                command.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                command.Parameters.AddWithValue("@barkodNo", txtBarkodNo.Text);
                command.Parameters.AddWithValue("@urunAdi", txtUrunAdi.Text);
                command.Parameters.AddWithValue("@miktari", int.Parse(txtMiktari.Text));
                command.Parameters.AddWithValue("@satisFiyati", decimal.Parse(txtSatisFiyat.Text));
                command.Parameters.AddWithValue("@toplamFiyati", decimal.Parse(txtToplamFiyat.Text));
                command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                command.ExecuteNonQuery();

                baglanti.Close();
            }

            else
            {
                baglanti.Open();

                SqlCommand command2 = new SqlCommand("Update TblSepet Set Miktari=Miktari+'" + int.Parse(txtMiktari.Text) + "' Where BarkodNo='" + txtBarkodNo.Text + "'", baglanti);
                command2.ExecuteNonQuery();

                SqlCommand command3 = new SqlCommand("Update TblSepet Set ToplamFiyati=Miktari*SatisFiyati Where BarkodNo='" + txtBarkodNo.Text + "'", baglanti);
                command3.ExecuteNonQuery();

                baglanti.Close();
            }

            

            txtMiktari.Text = "1";

            daset.Tables["TblSepet"].Clear();

            SepetListele();

            Hesapla();

            foreach (Control item in groupControl3.Controls)
            {
                if (item is TextEdit)
                {
                    if (item != txtMiktari)
                    {
                        item.Text = "";
                    }
                }
            }
        }

        private void txtMiktari_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void txtSatisFiyat_EditValueChanged(object sender, EventArgs e)
        {
            try
            {
                txtToplamFiyat.Text = (double.Parse(txtMiktari.Text) * double.Parse(txtSatisFiyat.Text)).ToString();
            }
            catch (Exception)
            {

                ;
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand command = new SqlCommand("Delete from TblSepet Where BarkodNo='" + gridView1.GetRowCellValue(gridView1.FocusedRowHandle,"BarkodNo").ToString() + "'", baglanti);
            command.ExecuteNonQuery();

            baglanti.Close();

            

            XtraMessageBox.Show("Ürün sepetten çıkartıldı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            daset.Tables["TblSepet"].Clear();

            SepetListele();

            Hesapla();

        }

        private void btnSatisIptal_Click(object sender, EventArgs e)
        {

            baglanti.Open();

            SqlCommand command = new SqlCommand("delete From TblSepet", baglanti);
            command.ExecuteNonQuery();

            baglanti.Close();

            XtraMessageBox.Show("Ürünler sepetten çıkarıldı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            daset.Tables["TblSepet"].Clear();

            Hesapla();

            SepetListele();
        }

        private void btnSatisListelemeSayfasi_Click(object sender, EventArgs e)
        {
            frmSatisListele frmSatisListele = new frmSatisListele();
            frmSatisListele.ShowDialog();
        }

        private void btnSatisYap_Click(object sender, EventArgs e)
        {
            int rowCount = gridView1.RowCount;

            for (int i = 0; i < rowCount; i++)
            {
                baglanti.Open();

                SqlCommand command = new SqlCommand("Insert Into TblSatis (TC,AdSoyad,Telefon,BarkodNo,UrunAdi,Miktari,SatisFiyati,ToplamFiyati,Tarih) values(@tc,@adSoyad,@telefon,@barkodNo,@urunAdi,@miktari,@satisFiyati,@toplamFiyati,@tarih)", baglanti);
                command.Parameters.AddWithValue("@tc", txtTC.Text);
                command.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
                command.Parameters.AddWithValue("@telefon", txtTelefon.Text);
                command.Parameters.AddWithValue("@barkodNo", gridView1.GetRowCellValue(i, "BarkodNo").ToString());
                command.Parameters.AddWithValue("@urunAdi", gridView1.GetRowCellValue(i, "UrunAdi").ToString());
                command.Parameters.AddWithValue("@miktari", int.Parse(gridView1.GetRowCellValue(i, "Miktari").ToString()));
                command.Parameters.AddWithValue("@satisFiyati", decimal.Parse(gridView1.GetRowCellValue(i, "SatisFiyati").ToString()));
                command.Parameters.AddWithValue("@toplamFiyati", decimal.Parse(gridView1.GetRowCellValue(i, "ToplamFiyati").ToString()));
                command.Parameters.AddWithValue("@tarih", DateTime.Now.ToString());

                command.ExecuteNonQuery();

                #region stoktan düşme işlemi

                SqlCommand command2 = new SqlCommand("Update TblUrun Set Miktari=miktari-@miktari where BarkodNo=@barkodNo", baglanti);
                command2.Parameters.AddWithValue("@miktari", int.Parse(gridView1.GetRowCellValue(i, "Miktari").ToString()));
                command2.Parameters.AddWithValue("@barkodNo", gridView1.GetRowCellValue(i, "BarkodNo").ToString());

                command2.ExecuteNonQuery();

                #endregion

                baglanti.Close();

                
            }


            baglanti.Open();

            SqlCommand command3 = new SqlCommand("delete From TblSepet", baglanti);
            command3.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["TblSepet"].Clear();

            SepetListele();

            Hesapla();

            XtraMessageBox.Show("Satış işlemi gerçekleştirildi.","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
