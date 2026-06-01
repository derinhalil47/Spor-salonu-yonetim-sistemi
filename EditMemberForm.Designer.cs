namespace GymManagement
{
    partial class EditMemberForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
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
            this.chkAktifMi = new System.Windows.Forms.CheckBox();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpUyeBilgileri.SuspendLayout();
            this.SuspendLayout();
            this.grpUyeBilgileri.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpUyeBilgileri.Location = new System.Drawing.Point(15, 15);
            this.grpUyeBilgileri.Name = "grpUyeBilgileri";
            this.grpUyeBilgileri.Size = new System.Drawing.Size(460, 300);
            this.grpUyeBilgileri.Text = "Üye Bilgileri";
            this.grpUyeBilgileri.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAd, this.txtAd,
                this.lblSoyad, this.txtSoyad,
                this.lblTelefon, this.txtTelefon,
                this.lblEmail, this.txtEmail,
                this.lblCinsiyet, this.cmbCinsiyet,
                this.lblDogumTarihi, this.dtpDogumTarihi,
                this.chkAktifMi });
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
            this.lblTelefon.Text = "Telefon: *";
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
            this.chkAktifMi.AutoSize = true;
            this.chkAktifMi.Location = new System.Drawing.Point(150, 255);
            this.chkAktifMi.Text = "Üye Aktif";
            this.chkAktifMi.Name = "chkAktifMi";
            this.chkAktifMi.Size = new System.Drawing.Size(100, 23);
            this.btnGuncelle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnGuncelle.Location = new System.Drawing.Point(15, 330);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 38);
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKapat.Location = new System.Drawing.Point(275, 330);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 38);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 390);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpUyeBilgileri,
                this.btnGuncelle,
                this.btnKapat });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditMemberForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Düzenle";
            this.Load += new System.EventHandler(this.EditMemberForm_Load);
            this.grpUyeBilgileri.ResumeLayout(false);
            this.grpUyeBilgileri.PerformLayout();
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
        private System.Windows.Forms.CheckBox chkAktifMi;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Button btnKapat;
    }
}
