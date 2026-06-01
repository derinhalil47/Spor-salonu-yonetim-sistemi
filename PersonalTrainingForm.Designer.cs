namespace GymManagement
{
    partial class PersonalTrainingForm
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
            this.pnlUst = new System.Windows.Forms.Panel();
            this.lblUyeSec = new System.Windows.Forms.Label();
            this.cmbUye = new System.Windows.Forms.ComboBox();
            this.btnKapat = new System.Windows.Forms.Button();
            this.grpVeriGirisi = new System.Windows.Forms.GroupBox();
            this.lblBoy = new System.Windows.Forms.Label();
            this.txtBoy = new System.Windows.Forms.TextBox();
            this.lblKilo = new System.Windows.Forms.Label();
            this.txtKilo = new System.Windows.Forms.TextBox();
            this.lblYagOrani = new System.Windows.Forms.Label();
            this.txtYagOrani = new System.Windows.Forms.TextBox();
            this.btnIstatistikKaydet = new System.Windows.Forms.Button();
            this.lblVKISonuc = new System.Windows.Forms.Label();
            this.grpKisiselProgram = new System.Windows.Forms.GroupBox();
            this.dgvProgram = new System.Windows.Forms.DataGridView();
            this.btnProgramiKaydet = new System.Windows.Forms.Button();
            this.btnEgzersizCikar = new System.Windows.Forms.Button();
            this.grpEgzersizHavuzu = new System.Windows.Forms.GroupBox();
            this.tcKategoriler = new System.Windows.Forms.TabControl();
            
            this.pnlUst.SuspendLayout();
            this.grpVeriGirisi.SuspendLayout();
            this.grpKisiselProgram.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).BeginInit();
            this.grpEgzersizHavuzu.SuspendLayout();
            this.SuspendLayout();
            this.pnlUst.Controls.Add(this.lblUyeSec);
            this.pnlUst.Controls.Add(this.cmbUye);
            this.pnlUst.Controls.Add(this.btnKapat);
            this.pnlUst.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUst.Height = 50;

            this.lblUyeSec.AutoSize = true;
            this.lblUyeSec.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblUyeSec.Location = new System.Drawing.Point(12, 15);
            this.lblUyeSec.Text = "Üye Seçin:";

            this.cmbUye.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUye.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbUye.Location = new System.Drawing.Point(90, 12);
            this.cmbUye.Size = new System.Drawing.Size(250, 25);
            this.cmbUye.SelectedIndexChanged += new System.EventHandler(this.cmbUye_SelectedIndexChanged);

            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.Location = new System.Drawing.Point(880, 10);
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.Text = "Kapat";
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.grpVeriGirisi.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblBoy, this.txtBoy,
                this.lblKilo, this.txtKilo,
                this.lblYagOrani, this.txtYagOrani,
                this.btnIstatistikKaydet, this.lblVKISonuc });
            this.grpVeriGirisi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpVeriGirisi.Location = new System.Drawing.Point(12, 60);
            this.grpVeriGirisi.Size = new System.Drawing.Size(330, 240);
            this.grpVeriGirisi.Text = "Fiziksel İstatistik (Anlık/Geçmiş)";

            this.lblBoy.AutoSize = true; this.lblBoy.Location = new System.Drawing.Point(15, 35); this.lblBoy.Text = "Boy (cm):";
            this.txtBoy.Location = new System.Drawing.Point(120, 32); this.txtBoy.Size = new System.Drawing.Size(180, 25);

            this.lblKilo.AutoSize = true; this.lblKilo.Location = new System.Drawing.Point(15, 75); this.lblKilo.Text = "Kilo (kg):";
            this.txtKilo.Location = new System.Drawing.Point(120, 72); this.txtKilo.Size = new System.Drawing.Size(180, 25);

            this.lblYagOrani.AutoSize = true; this.lblYagOrani.Location = new System.Drawing.Point(15, 115); this.lblYagOrani.Text = "Yağ Oranı (%):";
            this.txtYagOrani.Location = new System.Drawing.Point(120, 112); this.txtYagOrani.Size = new System.Drawing.Size(180, 25);

            this.btnIstatistikKaydet.Location = new System.Drawing.Point(120, 155);
            this.btnIstatistikKaydet.Size = new System.Drawing.Size(180, 35);
            this.btnIstatistikKaydet.Text = "Ölçümleri Kaydet";
            this.btnIstatistikKaydet.Click += new System.EventHandler(this.btnIstatistikKaydet_Click);

            this.lblVKISonuc.AutoSize = true;
            this.lblVKISonuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblVKISonuc.Location = new System.Drawing.Point(15, 205);
            this.lblVKISonuc.Text = "VKİ: -";
            this.grpKisiselProgram.Controls.Add(this.dgvProgram);
            this.grpKisiselProgram.Controls.Add(this.btnProgramiKaydet);
            this.grpKisiselProgram.Controls.Add(this.btnEgzersizCikar);
            this.grpKisiselProgram.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpKisiselProgram.Location = new System.Drawing.Point(360, 60);
            this.grpKisiselProgram.Size = new System.Drawing.Size(610, 240);
            this.grpKisiselProgram.Text = "Üyenin Kişisel Antrenman Programı";
            this.grpKisiselProgram.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.dgvProgram.AllowUserToAddRows = false;
            this.dgvProgram.AllowUserToDeleteRows = false;
            this.dgvProgram.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProgram.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProgram.Location = new System.Drawing.Point(10, 30);
            this.dgvProgram.Size = new System.Drawing.Size(590, 160);
            this.dgvProgram.ReadOnly = false;
            this.dgvProgram.RowHeadersVisible = false;
            this.dgvProgram.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            this.btnEgzersizCikar.Location = new System.Drawing.Point(10, 200);
            this.btnEgzersizCikar.Size = new System.Drawing.Size(120, 30);
            this.btnEgzersizCikar.Text = "Seçiliyi Çıkar";
            this.btnEgzersizCikar.Click += new System.EventHandler(this.btnEgzersizCikar_Click);

            this.btnProgramiKaydet.Location = new System.Drawing.Point(400, 200);
            this.btnProgramiKaydet.Size = new System.Drawing.Size(200, 30);
            this.btnProgramiKaydet.Text = "Programı Veritabanına Kaydet";
            this.btnProgramiKaydet.Click += new System.EventHandler(this.btnProgramiKaydet_Click);
            this.btnProgramiKaydet.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.grpEgzersizHavuzu.Controls.Add(this.tcKategoriler);
            this.grpEgzersizHavuzu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.grpEgzersizHavuzu.Location = new System.Drawing.Point(12, 310);
            this.grpEgzersizHavuzu.Size = new System.Drawing.Size(958, 340);
            this.grpEgzersizHavuzu.Text = "Tüm Egzersizler (Ekleme Havuzu)";
            this.grpEgzersizHavuzu.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;

            this.tcKategoriler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tcKategoriler.Location = new System.Drawing.Point(3, 21);
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.grpEgzersizHavuzu);
            this.Controls.Add(this.grpKisiselProgram);
            this.Controls.Add(this.grpVeriGirisi);
            this.Controls.Add(this.pnlUst);
            this.MinimumSize = new System.Drawing.Size(900, 600);
            this.Name = "PersonalTrainingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personal Training & Manuel Program Oluşturma";
            this.Load += new System.EventHandler(this.PersonalTrainingForm_Load);
            this.pnlUst.ResumeLayout(false);
            this.pnlUst.PerformLayout();
            this.grpVeriGirisi.ResumeLayout(false);
            this.grpVeriGirisi.PerformLayout();
            this.grpKisiselProgram.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProgram)).EndInit();
            this.grpEgzersizHavuzu.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel pnlUst;
        private System.Windows.Forms.Label lblUyeSec;
        private System.Windows.Forms.ComboBox cmbUye;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.GroupBox grpVeriGirisi;
        private System.Windows.Forms.Label lblBoy;
        private System.Windows.Forms.TextBox txtBoy;
        private System.Windows.Forms.Label lblKilo;
        private System.Windows.Forms.TextBox txtKilo;
        private System.Windows.Forms.Label lblYagOrani;
        private System.Windows.Forms.TextBox txtYagOrani;
        private System.Windows.Forms.Button btnIstatistikKaydet;
        private System.Windows.Forms.Label lblVKISonuc;
        private System.Windows.Forms.GroupBox grpKisiselProgram;
        private System.Windows.Forms.DataGridView dgvProgram;
        private System.Windows.Forms.Button btnEgzersizCikar;
        private System.Windows.Forms.Button btnProgramiKaydet;
        private System.Windows.Forms.GroupBox grpEgzersizHavuzu;
        private System.Windows.Forms.TabControl tcKategoriler;
    }
}
