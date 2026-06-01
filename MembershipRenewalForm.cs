using GymManagement.Data;
using GymManagement.Models;
using GymManagement.UI;

namespace GymManagement
{
    public partial class MembershipRenewalForm : Form
    {
        private readonly int _memberId;
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();

        private readonly Dictionary<string, (int Months, decimal Fee)> _sureTablosu = new()
        {
            { "1 Ay",  (1,   500m) },
            { "3 Ay",  (3,  1350m) },
            { "6 Ay",  (6,  2500m) },
            { "1 Yıl", (12, 4500m) },
        };

        public MembershipRenewalForm(int memberId)
        {
            _memberId = memberId;
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void MembershipRenewalForm_Load(object sender, EventArgs e)
        {
            MevcutBilgileriGoster();
        }

        private void MevcutBilgileriGoster()
        {
            var member = _memberRepo.GetById(_memberId);
            if (member == null)
            {
                MessageBox.Show("Üye bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblUyeAdiDeger.Text = member.FullName;

            var ms = _membershipRepo.GetLatestByMemberId(_memberId);
            if (ms != null)
            {
                lblMevcutBaslangicDeger.Text = ms.StartDate.ToString("dd.MM.yyyy");
                lblMevcutBitisDeger.Text = ms.EndDate.ToString("dd.MM.yyyy");

                int kalan = ms.RemainingDays;
                lblKalanGunDeger.Text = kalan <= 0 ? $"{kalan} (Süresi Bitti)" : $"{kalan} gün";
                lblKalanGunDeger.ForeColor = kalan <= 0 ? Color.FromArgb(255, 120, 120) :
                                             kalan < 7  ? Color.FromArgb(255, 230, 100) : Color.FromArgb(100, 255, 100);
            }
            else
            {
                lblMevcutBaslangicDeger.Text = "Kayıt Yok";
                lblMevcutBitisDeger.Text     = "Kayıt Yok";
                lblKalanGunDeger.Text        = "—";
            }
        }

        private void AlanlariGuncelle(object? sender, EventArgs e)
        {
            if (cmbYeniSure.SelectedItem == null) return;

            string sure = cmbYeniSure.SelectedItem.ToString()!;
            if (!_sureTablosu.TryGetValue(sure, out var bilgi)) return;

            DateTime bitis = dtpYeniBaslangic.Value.AddMonths(bilgi.Months);
            lblYeniBitisDeger.Text  = bitis.ToString("dd.MM.yyyy");
            lblYeniUcretDeger.Text  = $"₺{bilgi.Fee:N0}";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbYeniSure.SelectedIndex == -1)
            {
                MessageBox.Show("Lütfen yeni üyelik süresi seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbYeniSure.Focus();
                return;
            }

            string sure = cmbYeniSure.SelectedItem!.ToString()!;
            var (months, fee) = _sureTablosu[sure];
            DateTime bitis = dtpYeniBaslangic.Value.AddMonths(months);

            var yeniMs = new Membership
            {
                MemberId       = _memberId,
                StartDate      = dtpYeniBaslangic.Value.Date,
                EndDate        = bitis.Date,
                DurationMonths = months,
                TotalFee       = fee,
                MembershipType = cmbYeniTip.SelectedItem?.ToString() ?? "Standart",
            };

            try
            {
                _membershipRepo.Add(yeniMs);
                MessageBox.Show(
                    $"Üyelik başarıyla yenilendi!\n\n" +
                    $"Yeni Bitiş: {bitis:dd.MM.yyyy}\n" +
                    $"Ücret: ₺{fee:N0}",
                    "Yenileme Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Yenileme sırasında hata oluştu:\n{ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
