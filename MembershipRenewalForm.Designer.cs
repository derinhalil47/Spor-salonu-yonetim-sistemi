namespace GymManagement
{
    partial class MembershipRenewalForm
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
            this.grpMevcutDurum = new System.Windows.Forms.GroupBox();
            this.lblUyeAdiDeger = new System.Windows.Forms.Label();
            this.lblUyeAdi = new System.Windows.Forms.Label();
            this.lblMevcutBaslangicDeger = new System.Windows.Forms.Label();
            this.lblMevcutBaslangic = new System.Windows.Forms.Label();
            this.lblMevcutBitisDeger = new System.Windows.Forms.Label();
            this.lblMevcutBitis = new System.Windows.Forms.Label();
            this.lblKalanGunDeger = new System.Windows.Forms.Label();
            this.lblKalanGun = new System.Windows.Forms.Label();
            this.grpYeniUyelik = new System.Windows.Forms.GroupBox();
            this.lblYeniBaslangic = new System.Windows.Forms.Label();
            this.dtpYeniBaslangic = new System.Windows.Forms.DateTimePicker();
            this.lblYeniSure = new System.Windows.Forms.Label();
            this.cmbYeniSure = new System.Windows.Forms.ComboBox();
            this.lblYeniBitis = new System.Windows.Forms.Label();
            this.lblYeniBitisDeger = new System.Windows.Forms.Label();
            this.lblYeniUcret = new System.Windows.Forms.Label();
            this.lblYeniUcretDeger = new System.Windows.Forms.Label();
            this.lblYeniTip = new System.Windows.Forms.Label();
            this.cmbYeniTip = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpMevcutDurum.SuspendLayout();
            this.grpYeniUyelik.SuspendLayout();
            this.SuspendLayout();
            this.grpMevcutDurum.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpMevcutDurum.Location = new System.Drawing.Point(15, 15);
            this.grpMevcutDurum.Name = "grpMevcutDurum";
            this.grpMevcutDurum.Size = new System.Drawing.Size(440, 160);
            this.grpMevcutDurum.Text = "Mevcut Üyelik Durumu";
            this.grpMevcutDurum.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblUyeAdi, this.lblUyeAdiDeger,
                this.lblMevcutBaslangic, this.lblMevcutBaslangicDeger,
                this.lblMevcutBitis, this.lblMevcutBitisDeger,
                this.lblKalanGun, this.lblKalanGunDeger });
            this.lblUyeAdi.AutoSize = true;
            this.lblUyeAdi.Location = new System.Drawing.Point(15, 35);
            this.lblUyeAdi.Text = "Üye:";
            this.lblUyeAdiDeger.AutoSize = true;
            this.lblUyeAdiDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblUyeAdiDeger.Location = new System.Drawing.Point(170, 35);
            this.lblUyeAdiDeger.Name = "lblUyeAdiDeger";
            this.lblUyeAdiDeger.Text = "—";
            this.lblMevcutBaslangic.AutoSize = true;
            this.lblMevcutBaslangic.Location = new System.Drawing.Point(15, 70);
            this.lblMevcutBaslangic.Text = "Mevcut Başlangıç:";
            this.lblMevcutBaslangicDeger.AutoSize = true;
            this.lblMevcutBaslangicDeger.Location = new System.Drawing.Point(170, 70);
            this.lblMevcutBaslangicDeger.Name = "lblMevcutBaslangicDeger";
            this.lblMevcutBaslangicDeger.Text = "—";
            this.lblMevcutBitis.AutoSize = true;
            this.lblMevcutBitis.Location = new System.Drawing.Point(15, 100);
            this.lblMevcutBitis.Text = "Mevcut Bitiş:";
            this.lblMevcutBitisDeger.AutoSize = true;
            this.lblMevcutBitisDeger.Location = new System.Drawing.Point(170, 100);
            this.lblMevcutBitisDeger.Name = "lblMevcutBitisDeger";
            this.lblMevcutBitisDeger.Text = "—";
            this.lblKalanGun.AutoSize = true;
            this.lblKalanGun.Location = new System.Drawing.Point(15, 130);
            this.lblKalanGun.Text = "Kalan Gün:";
            this.lblKalanGunDeger.AutoSize = true;
            this.lblKalanGunDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblKalanGunDeger.Location = new System.Drawing.Point(170, 130);
            this.lblKalanGunDeger.Name = "lblKalanGunDeger";
            this.lblKalanGunDeger.Text = "—";
            this.grpYeniUyelik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpYeniUyelik.Location = new System.Drawing.Point(15, 190);
            this.grpYeniUyelik.Name = "grpYeniUyelik";
            this.grpYeniUyelik.Size = new System.Drawing.Size(440, 210);
            this.grpYeniUyelik.Text = "Yeni Üyelik Bilgileri";
            this.grpYeniUyelik.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblYeniBaslangic, this.dtpYeniBaslangic,
                this.lblYeniSure, this.cmbYeniSure,
                this.lblYeniBitis, this.lblYeniBitisDeger,
                this.lblYeniUcret, this.lblYeniUcretDeger,
                this.lblYeniTip, this.cmbYeniTip });
            this.lblYeniBaslangic.AutoSize = true;
            this.lblYeniBaslangic.Location = new System.Drawing.Point(15, 35);
            this.lblYeniBaslangic.Text = "Başlangıç Tarihi: *";
            this.dtpYeniBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpYeniBaslangic.Location = new System.Drawing.Point(170, 32);
            this.dtpYeniBaslangic.Name = "dtpYeniBaslangic";
            this.dtpYeniBaslangic.Size = new System.Drawing.Size(250, 25);
            this.dtpYeniBaslangic.ValueChanged += new System.EventHandler(this.AlanlariGuncelle);
            this.lblYeniSure.AutoSize = true;
            this.lblYeniSure.Location = new System.Drawing.Point(15, 72);
            this.lblYeniSure.Text = "Süre: *";
            this.cmbYeniSure.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYeniSure.Items.AddRange(new object[] { "1 Ay", "3 Ay", "6 Ay", "1 Yıl" });
            this.cmbYeniSure.Location = new System.Drawing.Point(170, 69);
            this.cmbYeniSure.Name = "cmbYeniSure";
            this.cmbYeniSure.Size = new System.Drawing.Size(250, 25);
            this.cmbYeniSure.SelectedIndexChanged += new System.EventHandler(this.AlanlariGuncelle);
            this.lblYeniBitis.AutoSize = true;
            this.lblYeniBitis.Location = new System.Drawing.Point(15, 109);
            this.lblYeniBitis.Text = "Bitiş Tarihi:";
            this.lblYeniBitisDeger.AutoSize = true;
            this.lblYeniBitisDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYeniBitisDeger.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblYeniBitisDeger.Location = new System.Drawing.Point(170, 109);
            this.lblYeniBitisDeger.Name = "lblYeniBitisDeger";
            this.lblYeniBitisDeger.Text = "—";
            this.lblYeniUcret.AutoSize = true;
            this.lblYeniUcret.Location = new System.Drawing.Point(15, 146);
            this.lblYeniUcret.Text = "Ücret:";
            this.lblYeniUcretDeger.AutoSize = true;
            this.lblYeniUcretDeger.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblYeniUcretDeger.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblYeniUcretDeger.Location = new System.Drawing.Point(170, 146);
            this.lblYeniUcretDeger.Name = "lblYeniUcretDeger";
            this.lblYeniUcretDeger.Text = "—";
            this.lblYeniTip.AutoSize = true;
            this.lblYeniTip.Location = new System.Drawing.Point(15, 180);
            this.lblYeniTip.Text = "Üyelik Tipi:";
            this.cmbYeniTip.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYeniTip.Items.AddRange(new object[] { "Standart", "VIP" });
            this.cmbYeniTip.Location = new System.Drawing.Point(170, 177);
            this.cmbYeniTip.Name = "cmbYeniTip";
            this.cmbYeniTip.Size = new System.Drawing.Size(250, 25);
            this.cmbYeniTip.SelectedIndex = 0;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKaydet.Location = new System.Drawing.Point(15, 418);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(200, 38);
            this.btnKaydet.Text = "Üyeliği Yenile";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnKapat.Location = new System.Drawing.Point(255, 418);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(200, 38);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 474);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.grpMevcutDurum, this.grpYeniUyelik,
                this.btnKaydet, this.btnKapat });
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MembershipRenewalForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üyelik Yenile";
            this.Load += new System.EventHandler(this.MembershipRenewalForm_Load);
            this.grpMevcutDurum.ResumeLayout(false);
            this.grpMevcutDurum.PerformLayout();
            this.grpYeniUyelik.ResumeLayout(false);
            this.grpYeniUyelik.PerformLayout();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox grpMevcutDurum;
        private System.Windows.Forms.Label lblUyeAdi;
        private System.Windows.Forms.Label lblUyeAdiDeger;
        private System.Windows.Forms.Label lblMevcutBaslangic;
        private System.Windows.Forms.Label lblMevcutBaslangicDeger;
        private System.Windows.Forms.Label lblMevcutBitis;
        private System.Windows.Forms.Label lblMevcutBitisDeger;
        private System.Windows.Forms.Label lblKalanGun;
        private System.Windows.Forms.Label lblKalanGunDeger;
        private System.Windows.Forms.GroupBox grpYeniUyelik;
        private System.Windows.Forms.Label lblYeniBaslangic;
        private System.Windows.Forms.DateTimePicker dtpYeniBaslangic;
        private System.Windows.Forms.Label lblYeniSure;
        private System.Windows.Forms.ComboBox cmbYeniSure;
        private System.Windows.Forms.Label lblYeniBitis;
        private System.Windows.Forms.Label lblYeniBitisDeger;
        private System.Windows.Forms.Label lblYeniUcret;
        private System.Windows.Forms.Label lblYeniUcretDeger;
        private System.Windows.Forms.Label lblYeniTip;
        private System.Windows.Forms.ComboBox cmbYeniTip;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
    }
}
