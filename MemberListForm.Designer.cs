namespace GymManagement
{
    partial class MemberListForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            this.dgvUyeler = new System.Windows.Forms.DataGridView();
            this.txtArama = new System.Windows.Forms.TextBox();
            this.lblArama = new System.Windows.Forms.Label();
            this.cmbFiltre = new System.Windows.Forms.ComboBox();
            this.lblFiltre = new System.Windows.Forms.Label();
            this.btnYenile = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnUyelikYenile = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            this.lblToplam = new System.Windows.Forms.Label();
            this.pnlUst = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).BeginInit();
            this.pnlUst.SuspendLayout();
            this.SuspendLayout();
            this.pnlUst.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblArama, this.txtArama, this.lblFiltre, this.cmbFiltre,
                this.btnYenile, this.btnDuzenle, this.btnSil, this.btnUyelikYenile,
                this.btnKapat, this.lblToplam });
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Height = 55;
            this.lblArama.AutoSize = true;
            this.lblArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblArama.Location = new System.Drawing.Point(10, 17);
            this.lblArama.Text = "Ara:";
            this.txtArama.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtArama.Location = new System.Drawing.Point(40, 14);
            this.txtArama.Size = new System.Drawing.Size(180, 25);
            this.txtArama.PlaceholderText = "Ad, soyad, telefon...";
            this.txtArama.TextChanged += new System.EventHandler(this.txtArama_TextChanged);
            this.lblFiltre.AutoSize = true;
            this.lblFiltre.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblFiltre.Location = new System.Drawing.Point(230, 17);
            this.lblFiltre.Text = "Filtre:";
            this.cmbFiltre.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbFiltre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltre.Items.AddRange(new object[] { "Tümü", "Aktif", "Süresi Biten", "Bu Hafta Bitiyor" });
            this.cmbFiltre.Location = new System.Drawing.Point(275, 14);
            this.cmbFiltre.Size = new System.Drawing.Size(140, 25);
            this.cmbFiltre.SelectedIndex = 0;
            this.cmbFiltre.SelectedIndexChanged += new System.EventHandler(this.cmbFiltre_SelectedIndexChanged);
            this.btnYenile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenile.Location = new System.Drawing.Point(430, 12);
            this.btnYenile.Size = new System.Drawing.Size(75, 30);
            this.btnYenile.Text = "Yenile";
            this.btnYenile.UseVisualStyleBackColor = true;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);

            this.btnDuzenle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnDuzenle.Location = new System.Drawing.Point(515, 12);
            this.btnDuzenle.Size = new System.Drawing.Size(75, 30);
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            this.btnSil.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSil.Location = new System.Drawing.Point(600, 12);
            this.btnSil.Size = new System.Drawing.Size(75, 30);
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            this.btnUyelikYenile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUyelikYenile.Location = new System.Drawing.Point(685, 12);
            this.btnUyelikYenile.Size = new System.Drawing.Size(100, 30);
            this.btnUyelikYenile.Text = "Üyelik Yenile";
            this.btnUyelikYenile.UseVisualStyleBackColor = true;
            this.btnUyelikYenile.Click += new System.EventHandler(this.btnUyelikYenile_Click);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.Location = new System.Drawing.Point(795, 12);
            this.btnKapat.Size = new System.Drawing.Size(75, 30);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.UseVisualStyleBackColor = true;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            this.lblToplam.AutoSize = true;
            this.lblToplam.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblToplam.Location = new System.Drawing.Point(890, 19);
            this.lblToplam.Text = "Toplam: 0 üye";
            this.dgvUyeler.AllowUserToAddRows = false;
            this.dgvUyeler.AllowUserToDeleteRows = false;
            this.dgvUyeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUyeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUyeler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUyeler.MultiSelect = false;
            this.dgvUyeler.ReadOnly = true;
            this.dgvUyeler.RowHeadersVisible = false;
            this.dgvUyeler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUyeler.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUyeler_CellDoubleClick);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 520);
            this.Controls.Add(this.dgvUyeler);
            this.Controls.Add(this.pnlUst);
            this.MinimumSize = new System.Drawing.Size(900, 400);
            this.Name = "MemberListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Üye Listesi";
            this.Load += new System.EventHandler(this.MemberListForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUyeler)).EndInit();
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.ResumeLayout(false);
        }
        #endregion

        private System.Windows.Forms.DataGridView dgvUyeler;
        private System.Windows.Forms.TextBox txtArama;
        private System.Windows.Forms.Label lblArama;
        private System.Windows.Forms.ComboBox cmbFiltre;
        private System.Windows.Forms.Label lblFiltre;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnUyelikYenile;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.Label lblToplam;
        private System.Windows.Forms.Panel pnlUst;
    }
}
