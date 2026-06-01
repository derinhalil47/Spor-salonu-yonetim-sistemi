namespace GymManagement
{
    partial class MemberDetailForm
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
            this.grpKisisel = new System.Windows.Forms.GroupBox();
            this.lblAd = new System.Windows.Forms.Label();
            this.lblAdDeger = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblSoyadDeger = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblTelefonDeger = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblEmailDeger = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.lblCinsiyetDeger = new System.Windows.Forms.Label();
            this.lblKayitTarihi = new System.Windows.Forms.Label();
            this.lblKayitTarihiDeger = new System.Windows.Forms.Label();
            this.grpUyelik = new System.Windows.Forms.GroupBox();
            this.lblUyelikTipi = new System.Windows.Forms.Label();
            this.lblUyelikTipiDeger = new System.Windows.Forms.Label();
            this.lblBaslangic = new System.Windows.Forms.Label();
            this.lblBaslangicDeger = new System.Windows.Forms.Label();
            this.lblBitis = new System.Windows.Forms.Label();
            this.lblBitisDeger = new System.Windows.Forms.Label();
            this.lblKalanGun = new System.Windows.Forms.Label();
            this.lblKalanGunDeger = new System.Windows.Forms.Label();
            this.grpOdeme = new System.Windows.Forms.GroupBox();
            this.lblToplamUcret = new System.Windows.Forms.Label();
            this.lblToplamUcretDeger = new System.Windows.Forms.Label();
            this.lblOdenen = new System.Windows.Forms.Label();
            this.lblOdenenDeger = new System.Windows.Forms.Label();
            this.lblBorc = new System.Windows.Forms.Label();
            this.lblBorcDeger = new System.Windows.Forms.Label();
            this.grpOdemeGecmisi = new System.Windows.Forms.GroupBox();
            this.dgvOdemeler = new System.Windows.Forms.DataGridView();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpKisisel.SuspendLayout();
            this.grpUyelik.SuspendLayout();
            this.grpOdeme.SuspendLayout();
            this.grpOdemeGecmisi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).BeginInit();
            this.SuspendLayout();
            this.grpKisisel.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpKisisel.Location = new System.Drawing.Point(15, 15);
            this.grpKisisel.Size = new System.Drawing.Size(340, 210);
            this.grpKisisel.Text = "Kişisel Bilgiler";
            this.grpKisisel.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblAd, this.lblAdDeger, this.lblSoyad, this.lblSoyadDeger,
                this.lblTelefon, this.lblTelefonDeger, this.lblEmail, this.lblEmailDeger,
                this.lblCinsiyet, this.lblCinsiyetDeger, this.lblKayitTarihi, this.lblKayitTarihiDeger });

            int y = 30; int gap = 30;
            this.lblAd.AutoSize = true; this.lblAd.Location = new System.Drawing.Point(15, y); this.lblAd.Text = "Ad:";
            this.lblAdDeger.AutoSize = true; this.lblAdDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblAdDeger.Location = new System.Drawing.Point(130, y); this.lblAdDeger.Text = "—";
            y += gap;
            this.lblSoyad.AutoSize = true; this.lblSoyad.Location = new System.Drawing.Point(15, y); this.lblSoyad.Text = "Soyad:";
            this.lblSoyadDeger.AutoSize = true; this.lblSoyadDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblSoyadDeger.Location = new System.Drawing.Point(130, y); this.lblSoyadDeger.Text = "—";
            y += gap;
            this.lblTelefon.AutoSize = true; this.lblTelefon.Location = new System.Drawing.Point(15, y); this.lblTelefon.Text = "Telefon:";
            this.lblTelefonDeger.AutoSize = true; this.lblTelefonDeger.Location = new System.Drawing.Point(130, y); this.lblTelefonDeger.Text = "—";
            y += gap;
            this.lblEmail.AutoSize = true; this.lblEmail.Location = new System.Drawing.Point(15, y); this.lblEmail.Text = "E-posta:";
            this.lblEmailDeger.AutoSize = true; this.lblEmailDeger.Location = new System.Drawing.Point(130, y); this.lblEmailDeger.Text = "—";
            y += gap;
            this.lblCinsiyet.AutoSize = true; this.lblCinsiyet.Location = new System.Drawing.Point(15, y); this.lblCinsiyet.Text = "Cinsiyet:";
            this.lblCinsiyetDeger.AutoSize = true; this.lblCinsiyetDeger.Location = new System.Drawing.Point(130, y); this.lblCinsiyetDeger.Text = "—";
            y += gap;
            this.lblKayitTarihi.AutoSize = true; this.lblKayitTarihi.Location = new System.Drawing.Point(15, y); this.lblKayitTarihi.Text = "Kayıt Tarihi:";
            this.lblKayitTarihiDeger.AutoSize = true; this.lblKayitTarihiDeger.Location = new System.Drawing.Point(130, y); this.lblKayitTarihiDeger.Text = "—";
            this.grpUyelik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpUyelik.Location = new System.Drawing.Point(370, 15);
            this.grpUyelik.Size = new System.Drawing.Size(320, 155);
            this.grpUyelik.Text = "Üyelik Durumu";
            this.grpUyelik.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUyelikTipi, this.lblUyelikTipiDeger,
                this.lblBaslangic, this.lblBaslangicDeger,
                this.lblBitis, this.lblBitisDeger,
                this.lblKalanGun, this.lblKalanGunDeger });

            y = 30;
            this.lblUyelikTipi.AutoSize = true; this.lblUyelikTipi.Location = new System.Drawing.Point(15, y); this.lblUyelikTipi.Text = "Üyelik Tipi:";
            this.lblUyelikTipiDeger.AutoSize = true; this.lblUyelikTipiDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblUyelikTipiDeger.Location = new System.Drawing.Point(130, y); this.lblUyelikTipiDeger.Text = "—";
            y += gap;
            this.lblBaslangic.AutoSize = true; this.lblBaslangic.Location = new System.Drawing.Point(15, y); this.lblBaslangic.Text = "Başlangıç:";
            this.lblBaslangicDeger.AutoSize = true; this.lblBaslangicDeger.Location = new System.Drawing.Point(130, y); this.lblBaslangicDeger.Text = "—";
            y += gap;
            this.lblBitis.AutoSize = true; this.lblBitis.Location = new System.Drawing.Point(15, y); this.lblBitis.Text = "Bitiş:";
            this.lblBitisDeger.AutoSize = true; this.lblBitisDeger.Location = new System.Drawing.Point(130, y); this.lblBitisDeger.Text = "—";
            y += gap;
            this.lblKalanGun.AutoSize = true; this.lblKalanGun.Location = new System.Drawing.Point(15, y); this.lblKalanGun.Text = "Kalan Gün:";
            this.lblKalanGunDeger.AutoSize = true; this.lblKalanGunDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblKalanGunDeger.Location = new System.Drawing.Point(130, y); this.lblKalanGunDeger.Text = "—";
            this.grpOdeme.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOdeme.Location = new System.Drawing.Point(370, 180);
            this.grpOdeme.Size = new System.Drawing.Size(320, 120);
            this.grpOdeme.Text = "Ödeme Özeti";
            this.grpOdeme.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblToplamUcret, this.lblToplamUcretDeger,
                this.lblOdenen, this.lblOdenenDeger,
                this.lblBorc, this.lblBorcDeger });

            y = 30;
            this.lblToplamUcret.AutoSize = true; this.lblToplamUcret.Location = new System.Drawing.Point(15, y); this.lblToplamUcret.Text = "Toplam Ücret:";
            this.lblToplamUcretDeger.AutoSize = true; this.lblToplamUcretDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblToplamUcretDeger.Location = new System.Drawing.Point(140, y); this.lblToplamUcretDeger.Text = "—";
            y += gap;
            this.lblOdenen.AutoSize = true; this.lblOdenen.Location = new System.Drawing.Point(15, y); this.lblOdenen.Text = "Ödenen:";
            this.lblOdenenDeger.AutoSize = true; this.lblOdenenDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold); this.lblOdenenDeger.ForeColor = System.Drawing.Color.DarkGreen; this.lblOdenenDeger.Location = new System.Drawing.Point(140, y); this.lblOdenenDeger.Text = "—";
            y += gap;
            this.lblBorc.AutoSize = true; this.lblBorc.Location = new System.Drawing.Point(15, y); this.lblBorc.Text = "Kalan Borç:";
            this.lblBorcDeger.AutoSize = true; this.lblBorcDeger.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold); this.lblBorcDeger.ForeColor = System.Drawing.Color.Red; this.lblBorcDeger.Location = new System.Drawing.Point(140, y); this.lblBorcDeger.Text = "—";
            this.grpOdemeGecmisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpOdemeGecmisi.Location = new System.Drawing.Point(15, 235);
            this.grpOdemeGecmisi.Size = new System.Drawing.Size(340, 190);
            this.grpOdemeGecmisi.Text = "Ödeme Geçmişi";
            this.grpOdemeGecmisi.Controls.Add(this.dgvOdemeler);

            this.dgvOdemeler.AllowUserToAddRows = false;
            this.dgvOdemeler.AllowUserToDeleteRows = false;
            this.dgvOdemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOdemeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOdemeler.ReadOnly = true;
            this.dgvOdemeler.RowHeadersVisible = false;
            this.dgvOdemeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKapat.Location = new System.Drawing.Point(555, 320);
            this.btnKapat.Size = new System.Drawing.Size(130, 38);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 440);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpKisisel, this.grpUyelik, this.grpOdeme,
                this.grpOdemeGecmisi, this.btnKapat });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MemberDetailForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Detayı";
            this.Load += new System.EventHandler(this.MemberDetailForm_Load);
            this.grpKisisel.ResumeLayout(false);
            this.grpKisisel.PerformLayout();
            this.grpUyelik.ResumeLayout(false);
            this.grpUyelik.PerformLayout();
            this.grpOdeme.ResumeLayout(false);
            this.grpOdeme.PerformLayout();
            this.grpOdemeGecmisi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOdemeler)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpKisisel;
        private System.Windows.Forms.Label lblAd, lblAdDeger, lblSoyad, lblSoyadDeger;
        private System.Windows.Forms.Label lblTelefon, lblTelefonDeger, lblEmail, lblEmailDeger;
        private System.Windows.Forms.Label lblCinsiyet, lblCinsiyetDeger, lblKayitTarihi, lblKayitTarihiDeger;
        private System.Windows.Forms.GroupBox grpUyelik;
        private System.Windows.Forms.Label lblUyelikTipi, lblUyelikTipiDeger;
        private System.Windows.Forms.Label lblBaslangic, lblBaslangicDeger, lblBitis, lblBitisDeger;
        private System.Windows.Forms.Label lblKalanGun, lblKalanGunDeger;
        private System.Windows.Forms.GroupBox grpOdeme;
        private System.Windows.Forms.Label lblToplamUcret, lblToplamUcretDeger;
        private System.Windows.Forms.Label lblOdenen, lblOdenenDeger;
        private System.Windows.Forms.Label lblBorc, lblBorcDeger;
        private System.Windows.Forms.GroupBox grpOdemeGecmisi;
        private System.Windows.Forms.DataGridView dgvOdemeler;
        private System.Windows.Forms.Button btnKapat;
    }
}
