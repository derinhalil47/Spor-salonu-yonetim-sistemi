using GymManagement.Data;
using GymManagement.Models;
using GymManagement.UI;

namespace GymManagement
{
    public partial class MemberListForm : Form
    {
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();
        private List<Member> _tumUyeler = new();

        public MemberListForm()
        {
            InitializeComponent();
            SutunlariOlustur();
            ThemeManager.ApplyTheme(this);
        }

        private void MemberListForm_Load(object sender, EventArgs e)
        {
            UyeleriYukle();
        }

        private void SutunlariOlustur()
        {
            dgvUyeler.Columns.Clear();
            dgvUyeler.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Id",             HeaderText = "No",          FillWeight = 6  },
                new DataGridViewTextBoxColumn { Name = "FirstName",      HeaderText = "Ad",          FillWeight = 13 },
                new DataGridViewTextBoxColumn { Name = "LastName",       HeaderText = "Soyad",       FillWeight = 13 },
                new DataGridViewTextBoxColumn { Name = "Phone",          HeaderText = "Telefon",     FillWeight = 12 },
                new DataGridViewTextBoxColumn { Name = "Gender",         HeaderText = "Cinsiyet",    FillWeight = 8  },
                new DataGridViewTextBoxColumn { Name = "MembershipType", HeaderText = "Üyelik Tipi", FillWeight = 10 },
                new DataGridViewTextBoxColumn { Name = "StartDate",      HeaderText = "Başlangıç",   FillWeight = 10 },
                new DataGridViewTextBoxColumn { Name = "EndDate",        HeaderText = "Bitiş",       FillWeight = 10 },
                new DataGridViewTextBoxColumn { Name = "RemainingDays",  HeaderText = "Kalan Gün",   FillWeight = 9  },
                new DataGridViewTextBoxColumn { Name = "TotalFee",       HeaderText = "Ücret",       FillWeight = 9  },
            });
        }

        private void UyeleriYukle()
        {
            try
            {
                _tumUyeler = _memberRepo.GetAll();
                FiltreUygula();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Üyeler yüklenirken hata oluştu:\n{ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FiltreUygula()
        {
            var keyword = txtArama.Text.Trim().ToLower();
            var filtre = cmbFiltre.SelectedItem?.ToString() ?? "Tümü";

            var sonuc = new List<(Member m, Membership? ms)>();

            foreach (var m in _tumUyeler)
            {
                if (!string.IsNullOrEmpty(keyword))
                {
                    bool eslesme = m.FirstName.ToLower().Contains(keyword)
                                || m.LastName.ToLower().Contains(keyword)
                                || (m.Phone ?? "").Contains(keyword);
                    if (!eslesme) continue;
                }

                var ms = _membershipRepo.GetLatestByMemberId(m.Id);
                switch (filtre)
                {
                    case "Aktif":
                        if (ms == null || ms.IsExpired) continue;
                        break;
                    case "Süresi Biten":
                        if (ms == null || !ms.IsExpired) continue;
                        break;
                    case "Bu Hafta Bitiyor":
                        if (ms == null || !ms.IsExpiringSoon) continue;
                        break;
                }

                sonuc.Add((m, ms));
            }

            TabloGuncelle(sonuc);
        }

        private void TabloGuncelle(List<(Member m, Membership? ms)> liste)
        {
            dgvUyeler.Rows.Clear();

            foreach (var (m, ms) in liste)
            {
                int kalanGun = ms?.RemainingDays ?? -999;
                string basStr = ms?.StartDate.ToString("dd.MM.yyyy") ?? "—";
                string bitStr = ms?.EndDate.ToString("dd.MM.yyyy") ?? "—";
                string kalanStr = ms != null ? (kalanGun < 0 ? $"{kalanGun} (Bitti)" : kalanGun.ToString()) : "—";
                string ucretStr = ms != null ? $"₺{ms.TotalFee:N0}" : "—";
                string tip = ms?.MembershipType ?? "—";

                int rowIndex = dgvUyeler.Rows.Add(
                    m.Id, m.FirstName, m.LastName, m.Phone,
                    m.Gender, tip, basStr, bitStr, kalanStr, ucretStr);

                var row = dgvUyeler.Rows[rowIndex];
                if (ms == null)
                    row.DefaultCellStyle.BackColor = Color.FromArgb(40, 40, 40);
                else if (ms.IsExpired)
                    { row.DefaultCellStyle.BackColor = Color.FromArgb(80, 20, 20); row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 120, 120); }
                else if (ms.IsExpiringSoon)
                    { row.DefaultCellStyle.BackColor = Color.FromArgb(80, 70, 10); row.DefaultCellStyle.ForeColor = Color.FromArgb(255, 230, 100); }
            }

            lblToplam.Text = $"Toplam: {liste.Count} üye";
        }

        private void txtArama_TextChanged(object sender, EventArgs e) => FiltreUygula();
        private void cmbFiltre_SelectedIndexChanged(object sender, EventArgs e) => FiltreUygula();

        private void btnYenile_Click(object sender, EventArgs e)
        {
            txtArama.Clear();
            cmbFiltre.SelectedIndex = 0;
            UyeleriYukle();
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz üyeyi seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int memberId = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["Id"].Value);
            var frm = new EditMemberForm(memberId);
            frm.ShowDialog();
            UyeleriYukle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek istediğiniz üyeyi seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            var row = dgvUyeler.SelectedRows[0];
            int id = Convert.ToInt32(row.Cells["Id"].Value);
            string name = $"{row.Cells["FirstName"].Value} {row.Cells["LastName"].Value}";

            if (MessageBox.Show($"'{name}' adlı üyeyi silmek istediğinize emin misiniz?",
                "Silme Onayı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    _memberRepo.Delete(id);
                    MessageBox.Show("Üye başarıyla silindi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    UyeleriYukle();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Silme sırasında hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnUyelikYenile_Click(object sender, EventArgs e)
        {
            if (dgvUyeler.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen üyeliğini yenilemek istediğiniz üyeyi seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            int memberId = Convert.ToInt32(dgvUyeler.SelectedRows[0].Cells["Id"].Value);
            var frm = new MembershipRenewalForm(memberId);
            frm.ShowDialog();
            UyeleriYukle();
        }

        private void dgvUyeler_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            int memberId = Convert.ToInt32(dgvUyeler.Rows[e.RowIndex].Cells["Id"].Value);
            var frm = new MemberDetailForm(memberId);
            frm.ShowDialog();
            UyeleriYukle();
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
