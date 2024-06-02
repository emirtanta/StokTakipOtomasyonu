namespace StokTakipOtomasyonu
{
    partial class frmMusteriListele
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMusteriListele));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.gridContMusteriListesi = new DevExpress.XtraGrid.GridControl();
            this.gridViewMusteriListesi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnMusteriSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnMusteriGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.memoAdres = new DevExpress.XtraEditors.MemoEdit();
            this.txtEmail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtTelefon = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtAdSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridContMusteriListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusteriListesi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdres.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.gridContMusteriListesi);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl1.Location = new System.Drawing.Point(277, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(584, 414);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Müşteri Listesi";
            // 
            // gridContMusteriListesi
            // 
            this.gridContMusteriListesi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridContMusteriListesi.Location = new System.Drawing.Point(2, 23);
            this.gridContMusteriListesi.MainView = this.gridViewMusteriListesi;
            this.gridContMusteriListesi.Name = "gridContMusteriListesi";
            this.gridContMusteriListesi.Size = new System.Drawing.Size(580, 389);
            this.gridContMusteriListesi.TabIndex = 0;
            this.gridContMusteriListesi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewMusteriListesi});
            // 
            // gridViewMusteriListesi
            // 
            this.gridViewMusteriListesi.GridControl = this.gridContMusteriListesi;
            this.gridViewMusteriListesi.Name = "gridViewMusteriListesi";
            this.gridViewMusteriListesi.OptionsView.ShowGroupPanel = false;
            this.gridViewMusteriListesi.DoubleClick += new System.EventHandler(this.gridViewMusteriListesi_DoubleClick);
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnMusteriSil);
            this.groupControl2.Controls.Add(this.btnMusteriGuncelle);
            this.groupControl2.Controls.Add(this.memoAdres);
            this.groupControl2.Controls.Add(this.txtEmail);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.txtTelefon);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.txtAdSoyad);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Controls.Add(this.txtTC);
            this.groupControl2.Controls.Add(this.labelControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl2.Location = new System.Drawing.Point(0, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(271, 414);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Müşteri Bilgileri";
            // 
            // btnMusteriSil
            // 
            this.btnMusteriSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriSil.ImageOptions.Image")));
            this.btnMusteriSil.Location = new System.Drawing.Point(93, 347);
            this.btnMusteriSil.Name = "btnMusteriSil";
            this.btnMusteriSil.Size = new System.Drawing.Size(75, 42);
            this.btnMusteriSil.TabIndex = 3;
            this.btnMusteriSil.Text = "Sil";
            this.btnMusteriSil.Click += new System.EventHandler(this.btnMusteriSil_Click);
            // 
            // btnMusteriGuncelle
            // 
            this.btnMusteriGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnMusteriGuncelle.ImageOptions.Image")));
            this.btnMusteriGuncelle.Location = new System.Drawing.Point(174, 347);
            this.btnMusteriGuncelle.Name = "btnMusteriGuncelle";
            this.btnMusteriGuncelle.Size = new System.Drawing.Size(83, 42);
            this.btnMusteriGuncelle.TabIndex = 3;
            this.btnMusteriGuncelle.Text = "Güncelle";
            this.btnMusteriGuncelle.Click += new System.EventHandler(this.btnMusteriGuncelle_Click);
            // 
            // memoAdres
            // 
            this.memoAdres.Location = new System.Drawing.Point(13, 161);
            this.memoAdres.Name = "memoAdres";
            this.memoAdres.Size = new System.Drawing.Size(244, 180);
            this.memoAdres.TabIndex = 2;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(116, 111);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(141, 20);
            this.txtEmail.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(13, 142);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(28, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Adres";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(13, 111);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(24, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Email";
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(116, 85);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(141, 20);
            this.txtTelefon.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(13, 85);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Telefon";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(116, 59);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(141, 20);
            this.txtAdSoyad.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(13, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(46, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Ad Soyad";
            // 
            // txtTC
            // 
            this.txtTC.Location = new System.Drawing.Point(116, 33);
            this.txtTC.Name = "txtTC";
            this.txtTC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtTC.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtTC.Properties.MaskSettings.Set("mask", "d");
            this.txtTC.Properties.MaxLength = 11;
            this.txtTC.Size = new System.Drawing.Size(141, 20);
            this.txtTC.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 33);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(13, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TC";
            // 
            // frmMusteriListele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 414);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMusteriListele";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Müşteri Listeleme Formu";
            this.Load += new System.EventHandler(this.frmMusteriListele_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridContMusteriListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewMusteriListesi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoAdres.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtEmail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTelefon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAdSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTC.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraGrid.GridControl gridContMusteriListesi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewMusteriListesi;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnMusteriGuncelle;
        private DevExpress.XtraEditors.MemoEdit memoAdres;
        private DevExpress.XtraEditors.TextEdit txtEmail;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtTelefon;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtTC;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnMusteriSil;
    }
}