namespace GymManagement
{
    partial class AddMemberForm
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
            this.grpUyeBilgileri = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.txtAd = new System.Windows.Forms.TextBox();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.lblDogumTarihi = new System.Windows.Forms.Label();
            this.dtpDogumTarihi = new System.Windows.Forms.DateTimePicker();
            this.grpUyelikBilgileri = new System.Windows.Forms.GroupBox();
            this.lblBaslangicTarihi = new System.Windows.Forms.Label();
            this.dtpBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblSure = new System.Windows.Forms.Label();
            this.cmbSure = new System.Windows.Forms.ComboBox();
            this.lblBitisTarihi = new System.Windows.Forms.Label();
            this.lblBitisTarihiDeger = new System.Windows.Forms.Label();
            this.lblUcret = new System.Windows.Forms.Label();
            this.lblUcretDeger = new System.Windows.Forms.Label();
            this.lblUyelikTipi = new System.Windows.Forms.Label();
            this.cmbUyelikTipi = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpUyeBilgileri.SuspendLayout();
            this.grpUyelikBilgileri.SuspendLayout();
            this.SuspendLayout();
            this.grpUyeBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpUyeBilgileri.Location = new System.Drawing.Point(15, 15);
            this.grpUyeBilgileri.Name = "grpUyeBilgileri";
            this.grpUyeBilgileri.Size = new System.Drawing.Size(460, 285);
            this.grpUyeBilgileri.Text = "Üye Bilgileri";
            this.grpUyeBilgileri.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAd, this.txtAd,
                this.lblSoyad, this.txtSoyad,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail, this.txtEmail,
                this.lblCinsiyet, this.cmbCinsiyet,
                this.lblDogumTarihi, this.dtpDogumTarihi });
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(15, 35);
            this.lblAd.Text = "Ad: *";
            this.txtAd.Location = new System.Drawing.Point(150, 32);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(290, 25);
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(15, 72);
            this.lblSoyad.Text = "Soyad: *";
            this.txtSoyad.Location = new System.Drawing.Point(150, 69);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(290, 25);
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(15, 109);
            this.lblTelefon.Text = "Telefon:";
            this.txtTelefon.Location = new System.Drawing.Point(150, 106);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(290, 25);
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(15, 146);
            this.lblEmail.Text = "E-posta:";
            this.txtEmail.Location = new System.Drawing.Point(150, 143);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(290, 25);
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(15, 183);
            this.lblCinsiyet.Text = "Cinsiyet: *";
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.Items.AddRange(new object[] { "Erkek", "Kadın" });
            this.cmbCinsiyet.Location = new System.Drawing.Point(150, 180);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(290, 25);
            this.lblDogumTarihi.AutoSize = true;
            this.lblDogumTarihi.Location = new System.Drawing.Point(15, 220);
            this.lblDogumTarihi.Text = "Doğum Tarihi:";
            this.dtpDogumTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDogumTarihi.Location = new System.Drawing.Point(150, 217);
            this.dtpDogumTarihi.Name = "dtpDogumTarihi";
            this.dtpDogumTarihi.Size = new System.Drawing.Size(290, 25);
            this.dtpDogumTarihi.Value = DateTime.Now.AddYears(-20);
            this.grpUyelikBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpUyelikBilgileri.Location = new System.Drawing.Point(15, 315);
            this.grpUyelikBilgileri.Name = "grpUyelikBilgileri";
            this.grpUyelikBilgileri.Size = new System.Drawing.Size(460, 215);
            this.grpUyelikBilgileri.Text = "Üyelik Bilgileri";
            this.grpUyelikBilgileri.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBaslangicTarihi, this.dtpBaslangic,
                this.lblSure, this.cmbSure,
                this.lblBitisTarihi, this.lblBitisTarihiDeger,
                this.lblUcret, this.lblUcretDeger,
                this.lblUyelikTipi, this.cmbUyelikTipi });
            this.lblBaslangicTarihi.AutoSize = true;
            this.lblBaslangicTarihi.Location = new System.Drawing.Point(15, 35);
            this.lblBaslangicTarihi.Text = "Başlangıç Tarihi: *";
            this.dtpBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpBaslangic.Location = new System.Drawing.Point(170, 32);
            this.dtpBaslangic.Name = "dtpBaslangic";
            this.dtpBaslangic.Size = new System.Drawing.Size(270, 25);
            this.dtpBaslangic.ValueChanged += new System.EventHandler(this.UyelikAlanlariGuncelle);
            this.lblSure.AutoSize = true;
            this.lblSure.Location = new System.Drawing.Point(15, 72);
            this.lblSure.Text = "Süre: *";
            this.cmbSure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSure.Items.AddRange(new object[] { "1 Ay", "3 Ay", "6 Ay", "1 Yıl" });
            this.cmbSure.Location = new System.Drawing.Point(170, 69);
            this.cmbSure.Name = "cmbSure";
            this.cmbSure.Size = new System.Drawing.Size(270, 25);
            this.cmbSure.SelectedIndexChanged += new System.EventHandler(this.UyelikAlanlariGuncelle);
            this.lblBitisTarihi.AutoSize = true;
            this.lblBitisTarihi.Location = new System.Drawing.Point(15, 109);
            this.lblBitisTarihi.Text = "Bitiş Tarihi:";
            this.lblBitisTarihiDeger.AutoSize = true;
            this.lblBitisTarihiDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblBitisTarihiDeger.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblBitisTarihiDeger.Location = new System.Drawing.Point(170, 109);
            this.lblBitisTarihiDeger.Name = "lblBitisTarihiDeger";
            this.lblBitisTarihiDeger.Text = "—";
            this.lblUcret.AutoSize = true;
            this.lblUcret.Location = new System.Drawing.Point(15, 146);
            this.lblUcret.Text = "Ücret:";
            this.lblUcretDeger.AutoSize = true;
            this.lblUcretDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUcretDeger.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblUcretDeger.Location = new System.Drawing.Point(170, 146);
            this.lblUcretDeger.Name = "lblUcretDeger";
            this.lblUcretDeger.Text = "—";
            this.lblUyelikTipi.AutoSize = true;
            this.lblUyelikTipi.Location = new System.Drawing.Point(15, 183);
            this.lblUyelikTipi.Text = "Üyelik Tipi:";
            this.cmbUyelikTipi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUyelikTipi.Items.AddRange(new object[] { "Standart", "VIP" });
            this.cmbUyelikTipi.Location = new System.Drawing.Point(170, 180);
            this.cmbUyelikTipi.Name = "cmbUyelikTipi";
            this.cmbUyelikTipi.Size = new System.Drawing.Size(270, 25);
            this.cmbUyelikTipi.SelectedIndex = 0;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKaydet.Location = new System.Drawing.Point(15, 548);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 38);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnTemizle.Location = new System.Drawing.Point(165, 548);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(140, 38);
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKapat.Location = new System.Drawing.Point(315, 548);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(140, 38);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 602);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpUyeBilgileri,
                this.grpUyelikBilgileri,
                this.btnKaydet,
                this.btnTemizle,
                this.btnKapat });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Yeni Üye Ekle";
            this.grpUyeBilgileri.ResumeLayout(false);
            this.grpUyeBilgileri.PerformLayout();
            this.grpUyelikBilgileri.ResumeLayout(false);
            this.grpUyelikBilgileri.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpUyeBilgileri;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Label lblDogumTarihi;
        private System.Windows.Forms.DateTimePicker dtpDogumTarihi;
        private System.Windows.Forms.GroupBox grpUyelikBilgileri;
        private System.Windows.Forms.Label lblBaslangicTarihi;
        private System.Windows.Forms.DateTimePicker dtpBaslangic;
        private System.Windows.Forms.Label lblSure;
        private System.Windows.Forms.ComboBox cmbSure;
        private System.Windows.Forms.Label lblBitisTarihi;
        private System.Windows.Forms.Label lblBitisTarihiDeger;
        private System.Windows.Forms.Label lblUcret;
        private System.Windows.Forms.Label lblUcretDeger;
        private System.Windows.Forms.Label lblUyelikTipi;
        private System.Windows.Forms.ComboBox cmbUyelikTipi;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Button btnKapat;
    }
}
