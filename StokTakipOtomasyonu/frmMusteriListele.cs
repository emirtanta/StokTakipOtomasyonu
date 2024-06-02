using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
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
    public partial class frmMusteriListele : DevExpress.XtraEditors.XtraForm
    {

        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        DataSet daset = new DataSet();

        public frmMusteriListele()
        {
            InitializeComponent();
        }

        private void KayitGoster()
        {
            baglanti.Open();

            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("Select * from TblMusteri", baglanti);
            sqlDataAdapter.Fill(daset, "TblMusteri");

            gridContMusteriListesi.DataSource = daset.Tables["TblMusteri"];

            baglanti.Close();
        }

        private void frmMusteriListele_Load(object sender, EventArgs e)
        {
            KayitGoster();
        }

        private void gridViewMusteriListesi_DoubleClick(object sender, EventArgs e)
        {
            // GridView'da çift tıklanan satırı al
            var hitInfo = gridViewMusteriListesi.CalcHitInfo(gridContMusteriListesi.PointToClient(Control.MousePosition));

            //seçili satırdaki verileri alır
            int selectedRowHandle= hitInfo.RowHandle; 
            txtTC.Text = gridViewMusteriListesi.GetRowCellValue(selectedRowHandle, "TC").ToString();
            txtAdSoyad.Text = gridViewMusteriListesi.GetRowCellValue(selectedRowHandle, "AdSoyad").ToString();
            txtTelefon.Text = gridViewMusteriListesi.GetRowCellValue(selectedRowHandle, "Telefon").ToString();
            txtEmail.Text = gridViewMusteriListesi.GetRowCellValue(selectedRowHandle, "Email").ToString();
            memoAdres.Text = gridViewMusteriListesi.GetRowCellValue(selectedRowHandle, "Adres").ToString();

                
        }

        private void btnMusteriGuncelle_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sqlCommand = new SqlCommand("Update TblMusteri Set AdSoyad=@adSoyad,Telefon=@telefon,Email=@email,Adres=@adres Where TC=@tc", baglanti);
            sqlCommand.Parameters.AddWithValue("@adSoyad", txtAdSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
            sqlCommand.Parameters.AddWithValue("@adres", memoAdres.Text);
            sqlCommand.Parameters.AddWithValue("@tc", txtTC.Text);


            sqlCommand.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["TblMusteri"].Clear();

            KayitGoster();

            XtraMessageBox.Show("Müşteri Kaydı Güncellendi");
        }

        private void btnMusteriSil_Click(object sender, EventArgs e)
        {
            baglanti.Open();

            SqlCommand sqlCommand = new SqlCommand("Delete From TblMusteri Where TC=@tc", baglanti);
            sqlCommand.Parameters.AddWithValue("@tc", txtTC.Text);

            sqlCommand.ExecuteNonQuery();

            baglanti.Close();

            daset.Tables["TblMusteri"].Clear();

            KayitGoster();

            XtraMessageBox.Show("Müşteri Kaydı Silindi","Bilgi",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}