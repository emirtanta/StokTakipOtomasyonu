namespace StokTakipOtomasyonu
{
    partial class frmAnaForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAnaForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnMarkaEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnKategoriEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnUrunListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnMusteriEkle = new DevExpress.XtraBars.BarButtonItem();
            this.btnMusteriListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage5 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnUrunSatinAl = new DevExpress.XtraBars.BarButtonItem();
            this.btnSatisListesi = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage6 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.btnAnaSayfa = new DevExpress.XtraBars.BarButtonItem();
            this.xtraTabbedMdiManager1 = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.btnMarkaEkle,
            this.btnKategoriEkle,
            this.btnUrunEkle,
            this.btnUrunListesi,
            this.btnMusteriEkle,
            this.btnMusteriListesi,
            this.btnUrunSatinAl,
            this.btnSatisListesi,
            this.btnAnaSayfa});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 10;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage6,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4,
            this.ribbonPage1,
            this.ribbonPage5});
            this.ribbon.Size = new System.Drawing.Size(998, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 805);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(998, 24);
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Marka İşlemleri";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.btnMarkaEkle);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Kategori İşlemleri";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.ItemLinks.Add(this.btnKategoriEkle);
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Ürün İşlemleri";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUrunEkle);
            this.ribbonPageGroup4.ItemLinks.Add(this.btnUrunListesi);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            // 
            // btnMarkaEkle
            // 
            this.btnMarkaEkle.Caption = "Marka Ekle";
            this.btnMarkaEkle.Id = 1;
            this.btnMarkaEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMarkaEkle.ImageOptions.Image")));
            this.btnMarkaEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMarkaEkle.ImageOptions.LargeImage")));
            this.btnMarkaEkle.Name = "btnMarkaEkle";
            this.btnMarkaEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMarkaEkle_ItemClick);
            // 
            // btnKategoriEkle
            // 
            this.btnKategoriEkle.Caption = "Kategori Ekle";
            this.btnKategoriEkle.Id = 2;
            this.btnKategoriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnKategoriEkle.ImageOptions.Image")));
            this.btnKategoriEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKategoriEkle.ImageOptions.LargeImage")));
            this.btnKategoriEkle.Name = "btnKategoriEkle";
            this.btnKategoriEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnKategoriEkle_ItemClick);
            // 
            // btnUrunEkle
            // 
            this.btnUrunEkle.Caption = "Ürün Ekle";
            this.btnUrunEkle.Id = 3;
            this.btnUrunEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.Image")));
            this.btnUrunEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunEkle.ImageOptions.LargeImage")));
            this.btnUrunEkle.Name = "btnUrunEkle";
            this.btnUrunEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunEkle_ItemClick);
            // 
            // btnUrunListesi
            // 
            this.btnUrunListesi.Caption = "Ürün Listesi";
            this.btnUrunListesi.Id = 4;
            this.btnUrunListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunListesi.ImageOptions.Image")));
            this.btnUrunListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunListesi.ImageOptions.LargeImage")));
            this.btnUrunListesi.Name = "btnUrunListesi";
            this.btnUrunListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunListesi_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Müşteri İşlemleri";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriEkle);
            this.ribbonPageGroup1.ItemLinks.Add(this.btnMusteriListesi);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            // 
            // btnMusteriEkle
            // 
            this.btnMusteriEkle.Caption = "Müşteri Ekle";
            this.btnMusteriEkle.Id = 5;
            this.btnMusteriEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.ImageOptions.Image")));
            this.btnMusteriEkle.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriEkle.ImageOptions.LargeImage")));
            this.btnMusteriEkle.Name = "btnMusteriEkle";
            this.btnMusteriEkle.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriEkle_ItemClick);
            // 
            // btnMusteriListesi
            // 
            this.btnMusteriListesi.Caption = "Müşteri Listesi";
            this.btnMusteriListesi.Id = 6;
            this.btnMusteriListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriListesi.ImageOptions.Image")));
            this.btnMusteriListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMusteriListesi.ImageOptions.LargeImage")));
            this.btnMusteriListesi.Name = "btnMusteriListesi";
            this.btnMusteriListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnMusteriListesi_ItemClick);
            // 
            // ribbonPage5
            // 
            this.ribbonPage5.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup5});
            this.ribbonPage5.Name = "ribbonPage5";
            this.ribbonPage5.Text = "Satış İşlemleri";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.btnUrunSatinAl);
            this.ribbonPageGroup5.ItemLinks.Add(this.btnSatisListesi);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            // 
            // btnUrunSatinAl
            // 
            this.btnUrunSatinAl.Caption = "Ürün Satın Al";
            this.btnUrunSatinAl.Id = 7;
            this.btnUrunSatinAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnUrunSatinAl.ImageOptions.Image")));
            this.btnUrunSatinAl.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnUrunSatinAl.ImageOptions.LargeImage")));
            this.btnUrunSatinAl.Name = "btnUrunSatinAl";
            this.btnUrunSatinAl.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnUrunSatinAl_ItemClick);
            // 
            // btnSatisListesi
            // 
            this.btnSatisListesi.Caption = "Satış Listesi";
            this.btnSatisListesi.Id = 8;
            this.btnSatisListesi.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSatisListesi.ImageOptions.Image")));
            this.btnSatisListesi.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnSatisListesi.ImageOptions.LargeImage")));
            this.btnSatisListesi.Name = "btnSatisListesi";
            this.btnSatisListesi.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnSatisListesi_ItemClick);
            // 
            // ribbonPage6
            // 
            this.ribbonPage6.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup6});
            this.ribbonPage6.Name = "ribbonPage6";
            this.ribbonPage6.Text = "Ana Sayfa";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.btnAnaSayfa);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            // 
            // btnAnaSayfa
            // 
            this.btnAnaSayfa.Caption = "Ana Sayfa";
            this.btnAnaSayfa.Id = 9;
            this.btnAnaSayfa.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.Image")));
            this.btnAnaSayfa.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnAnaSayfa.ImageOptions.LargeImage")));
            this.btnAnaSayfa.Name = "btnAnaSayfa";
            // 
            // xtraTabbedMdiManager1
            // 
            this.xtraTabbedMdiManager1.MdiParent = this;
            // 
            // frmAnaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(998, 829);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "frmAnaForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Ana Form";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabbedMdiManager1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem btnMarkaEkle;
        private DevExpress.XtraBars.BarButtonItem btnKategoriEkle;
        private DevExpress.XtraBars.BarButtonItem btnUrunEkle;
        private DevExpress.XtraBars.BarButtonItem btnUrunListesi;
        private DevExpress.XtraBars.BarButtonItem btnMusteriEkle;
        private DevExpress.XtraBars.BarButtonItem btnMusteriListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.BarButtonItem btnUrunSatinAl;
        private DevExpress.XtraBars.BarButtonItem btnSatisListesi;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.BarButtonItem btnAnaSayfa;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager xtraTabbedMdiManager1;
    }
}