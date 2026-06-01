using GymManagement.Data;
using GymManagement.Models;

using GymManagement.UI;

namespace GymManagement
{
    public partial class AddMemberForm : Form
    {
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();
        private readonly Dictionary<string, (int Months, decimal Fee)> _sureTablosu = new()
        {
            { "1 Ay",   (1,  500m) },
            { "3 Ay",   (3, 1350m) },
            { "6 Ay",   (6, 2500m) },
            { "1 Yıl",  (12,4500m) },
        };

        public AddMemberForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }
        private void UyelikAlanlariGuncelle(object? sender, EventArgs e)
        {
            if (cmbSure.SelectedItem == null) return;

            string sure = cmbSure.SelectedItem.ToString()!;
            if (!_sureTablosu.TryGetValue(sure, out var bilgi)) return;

            DateTime bitis = dtpBaslangic.Value.AddMonths(bilgi.Months);
            lblBitisTarihiDeger.Text = bitis.ToString("dd.MM.yyyy");
            lblUcretDeger.Text = $"₺{bilgi.Fee:N0}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAd.Text))
            {
                MessageBox.Show("Lütfen üye adını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtAd.Focus(); return;
            }
            if (string.IsNullOrWhiteSpace(txtSoyad.Text))
            {
                MessageBox.Show("Lütfen üye soyadını giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtSoyad.Focus(); return;
            }
            if (cmbCinsiyet.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen cinsiyet seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbCinsiyet.Focus(); return;
            }
            string phone = txtTelefon.Text.Trim();
            if (string.IsNullOrWhiteSpace(phone))
            {
                MessageBox.Show("Lütfen telefon numarası giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTelefon.Focus(); return;
            }
            if (!System.Text.RegularExpressions.Regex.IsMatch(phone, @"^\d{10,11}$"))
            {
                MessageBox.Show("Telefon numarası sadece rakamlardan oluşmalı ve 10 veya 11 haneli olmalıdır.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTelefon.Focus(); return;
            }
            string email = txtEmail.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email))
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Lütfen geçerli bir e-posta adresi giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail.Focus(); return;
                }
            }
            if (dtpDogumTarihi.Value.Date > DateTime.Today)
            {
                MessageBox.Show("Doğum tarihi gelecekteki bir tarih olamaz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dtpDogumTarihi.Focus(); return;
            }

            if (cmbSure.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen üyelik süresi seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbSure.Focus(); return;
            }

            string seciliSure = cmbSure.SelectedItem!.ToString()!;
            var (months, fee) = _sureTablosu[seciliSure];
            DateTime bitis = dtpBaslangic.Value.AddMonths(months);
            var member = new Member
            {
                FirstName = txtAd.Text.Trim(),
                LastName = txtSoyad.Text.Trim(),
                Phone = txtTelefon.Text.Trim(),
                Email = txtEmail.Text.Trim(),
                Gender = cmbCinsiyet.SelectedItem!.ToString()!,
                BirthDate = dtpDogumTarihi.Value,
                RegistrationDate = DateTime.Now,
                IsActive = true,
            };
            try
            {
                int memberId = _memberRepo.Add(member);

                var membership = new Membership
                {
                    MemberId = memberId,
                    StartDate = dtpBaslangic.Value.Date,
                    EndDate = bitis.Date,
                    DurationMonths = months,
                    TotalFee = fee,
                    MembershipType = cmbUyelikTipi.SelectedItem?.ToString() ?? "Standart",
                };
                _membershipRepo.Add(membership);

                MessageBox.Show(
                    $"Üye başarıyla kaydedildi!\n\n" +
                    $"Üye No: {memberId}\n" +
                    $"Ad Soyad: {member.FullName}\n" +
                    $"Üyelik Bitiş: {bitis:dd.MM.yyyy}\n" +
                    $"Ücret: ₺{fee:N0}",
                    "Kayıt Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                FormuTemizle();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında hata oluştu:\n{ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e) => FormuTemizle();

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();

        private void FormuTemizle()
        {
            txtAd.Clear();
            txtSoyad.Clear();
            txtTelefon.Clear();
            txtEmail.Clear();
            cmbCinsiyet.SelectedIndex = -1;
            dtpDogumTarihi.Value = DateTime.Now.AddYears(-20);
            dtpBaslangic.Value = DateTime.Today;
            cmbSure.SelectedIndex = -1;
            cmbUyelikTipi.SelectedIndex = 0;
            lblBitisTarihiDeger.Text = "—";
            lblUcretDeger.Text = "—";
            txtAd.Focus();
        }
    }
}
