using DevExpress.XtraBars;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StokTakipOtomasyonu
{
    public partial class frmAnaForm : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmAnaForm()
        {
            InitializeComponent();
        }

        frmKategori kategoriForm;
        frmMarka markaForm;
        frmMusteriEkle musteriEkleForm;
        frmMusteriListele musteriListeleForm;
        frmSatis satisForm;
        frmSatisListele satisListeleForm;
        frmUrunEkle urunEkleForm;
        frmUrunListele urunListeleForm;
        

        private void btnMarkaEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (markaForm == null || markaForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                markaForm = new frmMarka();
                markaForm.MdiParent = this;
                markaForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnUrunSatinAl_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (satisForm == null || satisForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                satisForm = new frmSatis();
                satisForm.MdiParent = this;
                satisForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnSatisListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (satisListeleForm == null || satisListeleForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                satisListeleForm = new frmSatisListele();
                satisListeleForm.MdiParent = this;
                satisListeleForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnMusteriEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            frmMusteriEkle musteriEkleForm = new frmMusteriEkle();
            musteriEkleForm.ShowDialog();
        }

        private void btnMusteriListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (musteriListeleForm == null || musteriListeleForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                musteriListeleForm = new frmMusteriListele();
                musteriListeleForm.MdiParent = this;
                musteriListeleForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnUrunEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (urunEkleForm == null || urunEkleForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                urunEkleForm = new frmUrunEkle();
                urunEkleForm.MdiParent = this;
                urunEkleForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnUrunListesi_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (urunListeleForm == null || urunListeleForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                urunListeleForm = new frmUrunListele();
                urunListeleForm.MdiParent = this;
                urunListeleForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }

        private void btnKategoriEkle_ItemClick(object sender, ItemClickEventArgs e)
        {
            //her basıldığın açık olan formu sürekli açmayı engelleme
            if (kategoriForm == null || kategoriForm.IsDisposed)
            {
                //ana forma başka bir form çağrıldı
                kategoriForm = new frmKategori();
                kategoriForm.MdiParent = this;
                kategoriForm.Show();
            }

            //her basıldığın hedeflenen formu açmayı engelleme bitti
        }
    }
}