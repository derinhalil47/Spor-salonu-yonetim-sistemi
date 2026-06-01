using GymManagement.Data;

using GymManagement.UI;

namespace GymManagement
{
    public partial class MainForm : Form
    {
        private readonly MemberRepository _memberRepo = new();
        private readonly MembershipRepository _membershipRepo = new();
        private readonly PaymentRepository _paymentRepo = new();

        public MainForm()
        {
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GuncelleIstatistik();
        }

        private void GuncelleIstatistik()
        {
            try
            {
                int toplam = _memberRepo.GetTotalCount();
                int aktifUyelik = _membershipRepo.GetActiveCount();
                int suresiBiten = _membershipRepo.GetExpiredCount();
                decimal aylikGelir = _paymentRepo.GetTotalPaidThisMonth();
                decimal toplamBorc = 0;
                var members = _memberRepo.GetAll();
                foreach (var m in members)
                {
                    var memberships = _membershipRepo.GetByMemberId(m.Id);
                    decimal ucret = 0;
                    foreach (var ms in memberships) ucret += ms.TotalFee;
                    decimal odenen = _paymentRepo.GetTotalPaidByMemberId(m.Id);
                    decimal borc = ucret - odenen;
                    if (borc > 0) toplamBorc += borc;
                }
                lblToplamUyeDeger.Text = toplam.ToString();
                lblAktifUyeDeger.Text = aktifUyelik.ToString();
                lblSuresiBitenDeger.Text = suresiBiten.ToString();
                lblAylikGelirDeger.Text = $"₺{aylikGelir:N0}";
                lblToplamBorcDeger.Text = $"₺{toplamBorc:N0}";

                lblBilgi.Text = $"Tarih: {DateTime.Now:dd.MM.yyyy HH:mm}";
                toolStripStatusLabel1.Text = $"Toplam {toplam} üye  |  Bu ay gelir: ₺{aylikGelir:N0}  |  Borç: ₺{toplamBorc:N0}";
            }
            catch
            {
                toolStripStatusLabel1.Text = "Hazır";
            }
        }

        private void btnUyeEkle_Click(object sender, EventArgs e)
        {
            var frm = new AddMemberForm();
            frm.ShowDialog();
            GuncelleIstatistik();
        }

        private void btnUyeListesi_Click(object sender, EventArgs e)
        {
            var frm = new MemberListForm();
            frm.ShowDialog();
            GuncelleIstatistik();
        }

        private void btnOdemeler_Click(object sender, EventArgs e)
        {
            var frm = new PaymentForm();
            frm.ShowDialog();
            GuncelleIstatistik();
        }

        private void btnPersonalTraining_Click(object sender, EventArgs e)
        {
            var frm = new PersonalTrainingForm();
            frm.ShowDialog();
            GuncelleIstatistik();
        }

        private void uyeEkleToolStripMenuItem_Click(object sender, EventArgs e) => btnUyeEkle_Click(sender, e);
        private void uyeListesiToolStripMenuItem_Click(object sender, EventArgs e) => btnUyeListesi_Click(sender, e);
        private void cikisToolStripMenuItem_Click(object sender, EventArgs e) => Application.Exit();
    }
}
