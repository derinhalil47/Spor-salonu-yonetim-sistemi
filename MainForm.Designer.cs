namespace GymManagement
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dosyaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeEkleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uyeListesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odemelerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.odemeAlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUyeEkle = new System.Windows.Forms.Button();
            this.btnUyeListesi = new System.Windows.Forms.Button();
            this.btnOdemeler = new System.Windows.Forms.Button();
            this.btnPersonalTraining = new System.Windows.Forms.Button();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblBilgi = new System.Windows.Forms.Label();
            this.grpIstatistik = new System.Windows.Forms.GroupBox();
            this.lblToplamUye = new System.Windows.Forms.Label();
            this.lblToplamUyeDeger = new System.Windows.Forms.Label();
            this.lblAktifUye = new System.Windows.Forms.Label();
            this.lblAktifUyeDeger = new System.Windows.Forms.Label();
            this.lblSuresiBiten = new System.Windows.Forms.Label();
            this.lblSuresiBitenDeger = new System.Windows.Forms.Label();
            this.lblAylikGelir = new System.Windows.Forms.Label();
            this.lblAylikGelirDeger = new System.Windows.Forms.Label();
            this.lblToplamBorc = new System.Windows.Forms.Label();
            this.lblToplamBorcDeger = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.grpIstatistik.SuspendLayout();
            this.SuspendLayout();
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.dosyaToolStripMenuItem, this.uyelerToolStripMenuItem, this.odemelerToolStripMenuItem });
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.dosyaToolStripMenuItem.DropDownItems.Add(this.cikisToolStripMenuItem);
            this.dosyaToolStripMenuItem.Text = "Dosya";
            this.cikisToolStripMenuItem.Text = "Çıkış";
            this.cikisToolStripMenuItem.Click += new System.EventHandler(this.cikisToolStripMenuItem_Click);
            this.uyelerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.uyeEkleToolStripMenuItem, this.uyeListesiToolStripMenuItem });
            this.uyelerToolStripMenuItem.Text = "Üyeler";
            this.uyeEkleToolStripMenuItem.Text = "Üye Ekle";
            this.uyeEkleToolStripMenuItem.Click += new System.EventHandler(this.uyeEkleToolStripMenuItem_Click);
            this.uyeListesiToolStripMenuItem.Text = "Üye Listesi";
            this.uyeListesiToolStripMenuItem.Click += new System.EventHandler(this.uyeListesiToolStripMenuItem_Click);
            this.odemelerToolStripMenuItem.DropDownItems.Add(this.odemeAlToolStripMenuItem);
            this.odemelerToolStripMenuItem.Text = "Ödemeler";
            this.odemeAlToolStripMenuItem.Text = "Ödeme Al";
            this.odemeAlToolStripMenuItem.Click += new System.EventHandler(this.btnOdemeler_Click);
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(74, 40);
            this.lblBaslik.Text = "Spor Salonu Yönetim Sistemi";
            this.grpIstatistik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpIstatistik.Location = new System.Drawing.Point(80, 85);
            this.grpIstatistik.Size = new System.Drawing.Size(620, 100);
            this.grpIstatistik.Text = "Dashboard";
            this.grpIstatistik.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblToplamUye, this.lblToplamUyeDeger,
                this.lblAktifUye, this.lblAktifUyeDeger,
                this.lblSuresiBiten, this.lblSuresiBitenDeger,
                this.lblAylikGelir, this.lblAylikGelirDeger,
                this.lblToplamBorc, this.lblToplamBorcDeger });

            int col1 = 15, col2 = 140, col3 = 270, col4 = 400, col5 = 510;
            int row1 = 30, row2 = 60;

            this.lblToplamUye.AutoSize = true; this.lblToplamUye.Location = new System.Drawing.Point(col1, row1); this.lblToplamUye.Text = "Toplam Üye:";
            this.lblToplamUyeDeger.AutoSize = true; this.lblToplamUyeDeger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblToplamUyeDeger.Location = new System.Drawing.Point(col1, row2); this.lblToplamUyeDeger.Text = "0";

            this.lblAktifUye.AutoSize = true; this.lblAktifUye.Location = new System.Drawing.Point(col2, row1); this.lblAktifUye.Text = "Aktif Üyeler:";
            this.lblAktifUyeDeger.AutoSize = true; this.lblAktifUyeDeger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblAktifUyeDeger.ForeColor = System.Drawing.Color.DarkGreen; this.lblAktifUyeDeger.Location = new System.Drawing.Point(col2, row2); this.lblAktifUyeDeger.Text = "0";

            this.lblSuresiBiten.AutoSize = true; this.lblSuresiBiten.Location = new System.Drawing.Point(col3, row1); this.lblSuresiBiten.Text = "Süresi Biten:";
            this.lblSuresiBitenDeger.AutoSize = true; this.lblSuresiBitenDeger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblSuresiBitenDeger.ForeColor = System.Drawing.Color.Red; this.lblSuresiBitenDeger.Location = new System.Drawing.Point(col3, row2); this.lblSuresiBitenDeger.Text = "0";

            this.lblAylikGelir.AutoSize = true; this.lblAylikGelir.Location = new System.Drawing.Point(col4, row1); this.lblAylikGelir.Text = "Bu Ay Gelir:";
            this.lblAylikGelirDeger.AutoSize = true; this.lblAylikGelirDeger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblAylikGelirDeger.ForeColor = System.Drawing.Color.DarkBlue; this.lblAylikGelirDeger.Location = new System.Drawing.Point(col4, row2); this.lblAylikGelirDeger.Text = "₺0";

            this.lblToplamBorc.AutoSize = true; this.lblToplamBorc.Location = new System.Drawing.Point(col5, row1); this.lblToplamBorc.Text = "Toplam Borç:";
            this.lblToplamBorcDeger.AutoSize = true; this.lblToplamBorcDeger.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold); this.lblToplamBorcDeger.ForeColor = System.Drawing.Color.OrangeRed; this.lblToplamBorcDeger.Location = new System.Drawing.Point(col5, row2); this.lblToplamBorcDeger.Text = "₺0";
            this.btnUyeEkle.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUyeEkle.Location = new System.Drawing.Point(80, 210);
            this.btnUyeEkle.Size = new System.Drawing.Size(180, 80);
            this.btnUyeEkle.Text = "Üye Ekle";
            this.btnUyeEkle.UseVisualStyleBackColor = true;
            this.btnUyeEkle.Click += new System.EventHandler(this.btnUyeEkle_Click);

            this.btnUyeListesi.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnUyeListesi.Location = new System.Drawing.Point(300, 210);
            this.btnUyeListesi.Size = new System.Drawing.Size(180, 80);
            this.btnUyeListesi.Text = "Üye Listesi";
            this.btnUyeListesi.UseVisualStyleBackColor = true;
            this.btnUyeListesi.Click += new System.EventHandler(this.btnUyeListesi_Click);

            this.btnOdemeler.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnOdemeler.Location = new System.Drawing.Point(520, 210);
            this.btnOdemeler.Size = new System.Drawing.Size(180, 80);
            this.btnOdemeler.Text = "Ödemeler";
            this.btnOdemeler.UseVisualStyleBackColor = true;
            this.btnOdemeler.Click += new System.EventHandler(this.btnOdemeler_Click);

            this.btnPersonalTraining.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnPersonalTraining.Location = new System.Drawing.Point(80, 310);
            this.btnPersonalTraining.Size = new System.Drawing.Size(180, 50);
            this.btnPersonalTraining.Text = "Personal Training";
            this.btnPersonalTraining.UseVisualStyleBackColor = true;
            this.btnPersonalTraining.Click += new System.EventHandler(this.btnPersonalTraining_Click);
            this.lblBilgi.AutoSize = true;
            this.lblBilgi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblBilgi.Location = new System.Drawing.Point(300, 325);
            this.lblBilgi.Text = "";
            this.statusStrip1.Items.Add(this.toolStripStatusLabel1);
            this.toolStripStatusLabel1.Text = "Hazır";
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 400);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBilgi, this.statusStrip1, this.grpIstatistik,
                this.lblBaslik, this.btnOdemeler, this.btnUyeListesi,
                this.btnUyeEkle, this.btnPersonalTraining, this.menuStrip1 });
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FitTrack - Spor Salonu Yönetim Sistemi";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.grpIstatistik.ResumeLayout(false);
            this.grpIstatistik.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dosyaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeEkleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uyeListesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odemelerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem odemeAlToolStripMenuItem;
        private System.Windows.Forms.Button btnUyeEkle;
        private System.Windows.Forms.Button btnUyeListesi;
        private System.Windows.Forms.Button btnOdemeler;
        private System.Windows.Forms.Button btnPersonalTraining;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lblBilgi;
        private System.Windows.Forms.GroupBox grpIstatistik;
        private System.Windows.Forms.Label lblToplamUye, lblToplamUyeDeger;
        private System.Windows.Forms.Label lblAktifUye, lblAktifUyeDeger;
        private System.Windows.Forms.Label lblSuresiBiten, lblSuresiBitenDeger;
        private System.Windows.Forms.Label lblAylikGelir, lblAylikGelirDeger;
        private System.Windows.Forms.Label lblToplamBorc, lblToplamBorcDeger;
    }
}
