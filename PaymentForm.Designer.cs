namespace GymManagement
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grpOdemeYap = new System.Windows.Forms.GroupBox();
            this.lblUyeSec = new System.Windows.Forms.Label();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblToplamUcretDeger = new System.Windows.Forms.Label();
            this.lblOdenenToplam = new System.Windows.Forms.Label();
            this.lblOdenenToplamDeger = new System.Windows.Forms.Label();
            this.lblKalanBorc = new System.Windows.Forms.Label();
            this.lblKalanBorcDeger = new System.Windows.Forms.Label();
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.lblOdemeYontemi = new System.Windows.Forms.Label();
            this.cmbOdemeYontemi = new System.Windows.Forms.ComboBox();
            this.lblOdemeTarihi = new System.Windows.Forms.Label();
            this.dtpOdemeTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpOdemeGecmisi = new System.Windows.Forms.GroupBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.grpOdemeYap.SuspendLayout();
            this.grpOdemeGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            this.grpOdemeYap.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOdemeYap.Location = new System.Drawing.Point(15, 15);
            this.grpOdemeYap.Name = "grpOdemeYap";
            this.grpOdemeYap.Size = new System.Drawing.Size(460, 320);
            this.grpOdemeYap.Text = "Ödeme Yap";
            this.grpOdemeYap.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUyeSec, this.cmbUye,
                this.lblToplamUcret, this.lblToplamUcretDeger,
                this.lblOdenenToplam, this.lblOdenenToplamDeger,
                this.lblKalanBorc, this.lblKalanBorcDeger,
                this.lblTutar, this.txtTutar,
                this.lblOdemeYontemi, this.cmbOdemeYontemi,
                this.lblOdemeTarihi, this.dtpOdemeTarihi });
            this.lblUyeSec.AutoSize = true;
            this.lblUyeSec.Location = new System.Drawing.Point(15, 35);
            this.lblUyeSec.Text = "Üye Seç: *";
            this.cmbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUye.Location = new System.Drawing.Point(155, 32);
            this.cmbUye.Name = "cmbUye";
            this.cmbUye.Size = new System.Drawing.Size(285, 25);
            this.cmbUye.SelectedIndexChanged += new System.EventHandler(this.cmbUye_SelectedIndexChanged);
            this.lblToplamUcret.AutoSize = true;
            this.lblToplamUcret.Location = new System.Drawing.Point(15, 75);
            this.lblToplamUcret.Text = "Toplam Üyelik Ücreti:";
            this.lblToplamUcretDeger.AutoSize = true;
            this.lblToplamUcretDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblToplamUcretDeger.Location = new System.Drawing.Point(155, 75);
            this.lblToplamUcretDeger.Name = "lblToplamUcretDeger";
            this.lblToplamUcretDeger.Text = "—";
            this.lblOdenenToplam.AutoSize = true;
            this.lblOdenenToplam.Location = new System.Drawing.Point(15, 105);
            this.lblOdenenToplam.Text = "Ödenen Toplam:";
            this.lblOdenenToplamDeger.AutoSize = true;
            this.lblOdenenToplamDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblOdenenToplamDeger.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblOdenenToplamDeger.Location = new System.Drawing.Point(155, 105);
            this.lblOdenenToplamDeger.Name = "lblOdenenToplamDeger";
            this.lblOdenenToplamDeger.Text = "—";
            this.lblKalanBorc.AutoSize = true;
            this.lblKalanBorc.Location = new System.Drawing.Point(15, 135);
            this.lblKalanBorc.Text = "Kalan Borç:";
            this.lblKalanBorcDeger.AutoSize = true;
            this.lblKalanBorcDeger.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.lblKalanBorcDeger.ForeColor = System.Drawing.Color.Red;
            this.lblKalanBorcDeger.Location = new System.Drawing.Point(155, 133);
            this.lblKalanBorcDeger.Name = "lblKalanBorcDeger";
            this.lblKalanBorcDeger.Text = "—";
            this.lblTutar.AutoSize = true;
            this.lblTutar.Location = new System.Drawing.Point(15, 180);
            this.lblTutar.Text = "Ödenecek Tutar: *";
            this.txtTutar.Location = new System.Drawing.Point(155, 177);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(285, 25);
            this.lblOdemeYontemi.AutoSize = true;
            this.lblOdemeYontemi.Location = new System.Drawing.Point(15, 217);
            this.lblOdemeYontemi.Text = "Ödeme Yöntemi:";
            this.cmbOdemeYontemi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbOdemeYontemi.Items.AddRange(new object[] { "Nakit", "Kredi Kartı", "Havale" });
            this.cmbOdemeYontemi.Location = new System.Drawing.Point(155, 214);
            this.cmbOdemeYontemi.Name = "cmbOdemeYontemi";
            this.cmbOdemeYontemi.Size = new System.Drawing.Size(285, 25);
            this.cmbOdemeYontemi.SelectedIndex = 0;
            this.lblOdemeTarihi.AutoSize = true;
            this.lblOdemeTarihi.Location = new System.Drawing.Point(15, 254);
            this.lblOdemeTarihi.Text = "Ödeme Tarihi:";
            this.dtpOdemeTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOdemeTarihi.Location = new System.Drawing.Point(155, 251);
            this.dtpOdemeTarihi.Name = "dtpOdemeTarihi";
            this.dtpOdemeTarihi.Size = new System.Drawing.Size(285, 25);
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKaydet.Location = new System.Drawing.Point(15, 348);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 38);
            this.btnKaydet.Text = "Ödeme Al";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTemizle.Location = new System.Drawing.Point(165, 348);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 38);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKapat.Location = new System.Drawing.Point(315, 348);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(140, 38);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.grpOdemeGecmisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOdemeGecmisi.Location = new System.Drawing.Point(490, 15);
            this.grpOdemeGecmisi.Name = "grpOdemeGecmisi";
            this.grpOdemeGecmisi.Size = new System.Drawing.Size(390, 372);
            this.grpOdemeGecmisi.Text = "Ödeme Geçmişi";
            this.grpOdemeGecmisi.Controls.Add(this.dgvOdemeler);

            this.dgvOdemeler.AllowUserToAddRows = false;
            this.dgvOdemeler.AllowUserToDeleteRows = false;
            this.dgvOdemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdemeler.MultiSelect = false;
            this.dgvOdemeler.Name = "dgvOdemeler";
            this.dgvOdemeler.ReadOnly = true;
            this.dgvOdemeler.RowHeadersVisible = false;
            this.dgvOdemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 402);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpOdemeYap, this.grpOdemeGecmisi,
                this.btnKaydet, this.btnTemizle, this.btnKapat });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaymentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ödeme İşlemleri";
            this.Load += new System.EventHandler(this.PaymentForm_Load);
            this.grpOdemeYap.ResumeLayout(false);
            this.grpOdemeYap.PerformLayout();
            this.grpOdemeGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpOdemeYap;
        private System.Windows.Forms.Label lblUyeSec;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.Label lblToplamUcret;
        private System.Windows.Forms.Label lblToplamUcretDeger;
        private System.Windows.Forms.Label lblOdenenToplam;
        private System.Windows.Forms.Label lblOdenenToplamDeger;
        private System.Windows.Forms.Label lblKalanBorc;
        private System.Windows.Forms.Label lblKalanBorcDeger;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.Label lblOdemeYontemi;
        private System.Windows.Forms.ComboBox cmbOdemeYontemi;
        private System.Windows.Forms.Label lblOdemeTarihi;
        private System.Windows.Forms.DateTimePicker dtpOdemeTarihi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox grpOdemeGecmisi;
        private System.Windows.Forms.DataGridView dgvOdemeler;
    }
}
