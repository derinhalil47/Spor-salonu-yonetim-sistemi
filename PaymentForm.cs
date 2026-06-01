using GymManagement.Data;
using GymManagement.Models;

using GymManagement.UI;

namespace GymManagement
{
    public partial class PaymentForm : Form
    {
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();
        private readonly PaymentRepository _paymentRepo = new();

        private List<Member> _members = new();

        public PaymentForm()
        {
            InitializeComponent();
            OdemeGecmisiSutunlariOlustur();
            ThemeManager.ApplyTheme(this);
        }

        private void PaymentForm_Load(object sender, EventArgs e)
        {
            UyeleriYukle();
        }

        private void UyeleriYukle()
        {
            _members = _memberRepo.GetAll();
            cmbUye.Items.Clear();
            foreach (var m in _members)
            {
                cmbUye.Items.Add($"{m.Id} - {m.FullName}");
            }
        }

        private void OdemeGecmisiSutunlariOlustur()
        {
            dgvOdemeler.Columns.Clear();
            dgvOdemeler.Columns.AddRange(new DataGridViewColumn[]
            {
                new DataGridViewTextBoxColumn { Name = "Tarih",    HeaderText = "Tarih",     FillWeight = 25 },
                new DataGridViewTextBoxColumn { Name = "Tutar",    HeaderText = "Tutar",     FillWeight = 25 },
                new DataGridViewTextBoxColumn { Name = "Yontem",   HeaderText = "Yöntem",    FillWeight = 25 },
            });
        }

        private void cmbUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex < 0 || cmbUye.SelectedIndex >= _members.Count) return;

            var member = _members[cmbUye.SelectedIndex];
            var memberships = _membershipRepo.GetByMemberId(member.Id);
            decimal toplamUcret = 0;
            foreach (var ms in memberships)
                toplamUcret += ms.TotalFee;
            decimal odenen = _paymentRepo.GetTotalPaidByMemberId(member.Id);
            decimal kalanBorc = toplamUcret - odenen;

            lblToplamUcretDeger.Text = $"₺{toplamUcret:N0}";
            lblOdenenToplamDeger.Text = $"₺{odenen:N0}";

            if (kalanBorc <= 0)
            {
                lblKalanBorcDeger.Text = "₺0 (Borç Yok)";
                lblKalanBorcDeger.ForeColor = Color.FromArgb(100, 255, 100);
            }
            else
            {
                lblKalanBorcDeger.Text = $"₺{kalanBorc:N0}";
                lblKalanBorcDeger.ForeColor = Color.FromArgb(255, 120, 120);
            }
            OdemeGecmisiYukle(member.Id);
        }

        private void OdemeGecmisiYukle(int memberId)
        {
            dgvOdemeler.Rows.Clear();
            var payments = _paymentRepo.GetByMemberId(memberId);
            foreach (var p in payments)
            {
                dgvOdemeler.Rows.Add(
                    p.PaymentDate.ToString("dd.MM.yyyy"),
                    $"₺{p.Amount:N0}",
                    p.PaymentMethod
                );
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir üye seçiniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                cmbUye.Focus(); return;
            }

            if (string.IsNullOrWhiteSpace(txtTutar.Text) || !decimal.TryParse(txtTutar.Text, out decimal tutar) || tutar <= 0)
            {
                MessageBox.Show("Lütfen geçerli bir tutar giriniz.", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtTutar.Focus(); return;
            }

            var member = _members[cmbUye.SelectedIndex];
            var latestMs = _membershipRepo.GetLatestByMemberId(member.Id);

            var payment = new Payment
            {
                MemberId = member.Id,
                MembershipId = latestMs?.Id,
                Amount = tutar,
                PaymentDate = dtpOdemeTarihi.Value.Date,
                PaymentMethod = cmbOdemeYontemi.SelectedItem?.ToString() ?? "Nakit",
            };

            try
            {
                _paymentRepo.Add(payment);
                MessageBox.Show(
                    $"Ödeme başarıyla kaydedildi!\n\n" +
                    $"Üye: {member.FullName}\n" +
                    $"Tutar: ₺{tutar:N0}\n" +
                    $"Yöntem: {payment.PaymentMethod}",
                    "Ödeme Başarılı",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                txtTutar.Clear();
                cmbUye_SelectedIndexChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödeme kaydedilirken hata oluştu:\n{ex.Message}", "Hata",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbUye.SelectedIndex = -1;
            txtTutar.Clear();
            cmbOdemeYontemi.SelectedIndex = 0;
            dtpOdemeTarihi.Value = DateTime.Today;
            lblToplamUcretDeger.Text = "—";
            lblOdenenToplamDeger.Text = "—";
            lblKalanBorcDeger.Text = "—";
            dgvOdemeler.Rows.Clear();
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
