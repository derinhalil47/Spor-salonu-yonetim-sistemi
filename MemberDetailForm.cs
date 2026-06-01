using GymManagement.Data;
using GymManagement.Models;
using GymManagement.UI;

namespace GymManagement
{
    public partial class MemberDetailForm : Form
    {
        private readonly int _memberId;
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();
        private readonly PaymentRepository _paymentRepo = new();

        public MemberDetailForm(int memberId)
        {
            _memberId = memberId;
            InitializeComponent();
            OdemeGecmisiSutunlariOlustur();
            ThemeManager.ApplyTheme(this);
        }

        private void MemberDetailForm_Load(object sender, EventArgs e)
        {
            BilgileriYukle();
        }

        private void OdemeGecmisiSutunlariOlustur()
        {
            dgvOdemeler.Columns.Clear();
            dgvOdemeler.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Tarih",  HeaderText = "Tarih",  FillWeight = 30 },
                new DataGridViewTextBoxColumn { Name = "Tutar",  HeaderText = "Tutar",  FillWeight = 30 },
                new DataGridViewTextBoxColumn { Name = "Yontem", HeaderText = "Yöntem", FillWeight = 30 },
            });
        }

        private void BilgileriYukle()
        {
            var member = _memberRepo.GetById(_memberId);
            if (member == null)
            {
                MessageBox.Show("Üye bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            this.Text = $"Üye Detayı — {member.FullName}";
            lblAdDeger.Text = member.FirstName;
            lblSoyadDeger.Text = member.LastName;
            lblTelefonDeger.Text = string.IsNullOrEmpty(member.Phone) ? "—" : member.Phone;
            lblEmailDeger.Text = string.IsNullOrEmpty(member.Email) ? "—" : member.Email;
            lblCinsiyetDeger.Text = string.IsNullOrEmpty(member.Gender) ? "—" : member.Gender;
            lblKayitTarihiDeger.Text = member.RegistrationDate.ToString("dd.MM.yyyy");
            var ms = _membershipRepo.GetLatestByMemberId(_memberId);
            if (ms != null)
            {
                lblUyelikTipiDeger.Text = ms.MembershipType;
                lblBaslangicDeger.Text = ms.StartDate.ToString("dd.MM.yyyy");
                lblBitisDeger.Text = ms.EndDate.ToString("dd.MM.yyyy");

                int kalan = ms.RemainingDays;
                if (kalan <= 0)
                {
                    lblKalanGunDeger.Text = $"{kalan} (Süresi Bitti)";
                    lblKalanGunDeger.ForeColor = Color.FromArgb(255, 120, 120);
                }
                else if (kalan < 7)
                {
                    lblKalanGunDeger.Text = $"{kalan} gün (Az Kaldı!)";
                    lblKalanGunDeger.ForeColor = Color.FromArgb(255, 230, 100);
                }
                else
                {
                    lblKalanGunDeger.Text = $"{kalan} gün";
                    lblKalanGunDeger.ForeColor = Color.FromArgb(100, 255, 100);
                }
            }
            else
            {
                lblUyelikTipiDeger.Text = "Kayıt Yok";
                lblBaslangicDeger.Text = "—";
                lblBitisDeger.Text = "—";
                lblKalanGunDeger.Text = "—";
            }
            var allMemberships = _membershipRepo.GetByMemberId(_memberId);
            decimal toplamUcret = 0;
            foreach (var m in allMemberships)
                toplamUcret += m.TotalFee;

            decimal odenen = _paymentRepo.GetTotalPaidByMemberId(_memberId);
            decimal borc = toplamUcret - odenen;

            lblToplamUcretDeger.Text = $"₺{toplamUcret:N0}";
            lblOdenenDeger.Text = $"₺{odenen:N0}";

            if (borc <= 0)
            {
                lblBorcDeger.Text = "₺0 (Borç Yok)";
                lblBorcDeger.ForeColor = Color.FromArgb(100, 255, 100);
            }
            else
            {
                lblBorcDeger.Text = $"₺{borc:N0}";
                lblBorcDeger.ForeColor = Color.FromArgb(255, 120, 120);
            }
            dgvOdemeler.Rows.Clear();
            var payments = _paymentRepo.GetByMemberId(_memberId);
            foreach (var p in payments)
            {
                dgvOdemeler.Rows.Add(
                    p.PaymentDate.ToString("dd.MM.yyyy"),
                    $"₺{p.Amount:N0}",
                    p.PaymentMethod
                );
            }
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
