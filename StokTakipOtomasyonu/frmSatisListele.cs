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
    public partial class frmSatisListele : DevExpress.XtraEditors.XtraForm
    {
        SqlConnection baglanti = new SqlConnection("data source=(localdb)\\MSSQLLocalDB;Initial Catalog=StokTakipOtomasyonDB;User Id=sa;Password=123");

        DataSet daset = new DataSet();

        /// <summary>
        /// satış yapılan kayıtları kayıtları getirir
        /// </summary>
        private void SatisListele()
        {
            baglanti.Open();

            SqlDataAdapter da = new SqlDataAdapter("Select * From TblSatis", baglanti);
            da.Fill(daset, "TblSatis");

            gridControl1.DataSource = daset.Tables["TblSatis"];


            baglanti.Close();
        }

        public frmSatisListele()
        {
            InitializeComponent();
        }

        private void frmSatisListele_Load(object sender, EventArgs e)
        {
            SatisListele();
        }
    }
}