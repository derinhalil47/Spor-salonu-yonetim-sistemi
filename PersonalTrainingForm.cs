using GymManagement.Data;
using GymManagement.Models;
using System.Diagnostics;
using System.Data;
using GymManagement.UI;

namespace GymManagement
{
    public partial class PersonalTrainingForm : Form
    {
        private readonly MemberRepository _memberRepo = new();
        private readonly PhysicalStatRepository _statRepo = new();
        private readonly PTProgramRepository _programRepo = new();
        private List<Member> _members = new();
        private DataTable _programTable = new();

        public PersonalTrainingForm()
        {
            InitializeComponent();
            ProgramTablosunuHazirla();
            ThemeManager.ApplyTheme(this);
        }

        private void PersonalTrainingForm_Load(object sender, EventArgs e)
        {
            UyeleriYukle();
            EgzersizHavuzunuDoldur();
        }

        private void ProgramTablosunuHazirla()
        {
            _programTable.Columns.Add("Egzersiz", typeof(string));
            _programTable.Columns.Add("Set", typeof(int));
            _programTable.Columns.Add("Tekrar", typeof(int));
            
            dgvProgram.DataSource = _programTable;
            
            dgvProgram.Columns["Egzersiz"].ReadOnly = true;
            dgvProgram.Columns["Egzersiz"].FillWeight = 60;
            dgvProgram.Columns["Set"].FillWeight = 20;
            dgvProgram.Columns["Tekrar"].FillWeight = 20;
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

        private void cmbUye_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex < 0) return;

            var member = _members[cmbUye.SelectedIndex];
            IstatistikGoster(member.Id);
            KayitliProgramiYukle(member.Id);
        }

        private void IstatistikGoster(int memberId)
        {
            var stat = _statRepo.GetLatestByMemberId(memberId);
            if (stat != null)
            {
                txtBoy.Text = stat.Height.ToString();
                txtKilo.Text = stat.Weight.ToString();
                txtYagOrani.Text = stat.BodyFat.ToString();
                lblVKISonuc.Text = $"Son VKİ: {stat.BMI:F1}";
            }
            else
            {
                txtBoy.Clear();
                txtKilo.Clear();
                txtYagOrani.Clear();
                lblVKISonuc.Text = "VKİ: -";
            }
        }

        private void KayitliProgramiYukle(int memberId)
        {
            _programTable.Rows.Clear();
            var savedExercises = _programRepo.GetProgramByMemberId(memberId);
            foreach(var ex in savedExercises)
            {
                _programTable.Rows.Add(ex.ExerciseName, ex.Sets, ex.Reps);
            }
        }

        private void btnIstatistikKaydet_Click(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir üye seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtBoy.Text, out decimal boy) || boy <= 0 ||
                !decimal.TryParse(txtKilo.Text, out decimal kilo) || kilo <= 0 ||
                !decimal.TryParse(txtYagOrani.Text, out decimal yag) || yag < 0)
            {
                MessageBox.Show("Lütfen boy, kilo ve yağ oranını geçerli sayılar olarak giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = _members[cmbUye.SelectedIndex];
            var stat = new PhysicalStat
            {
                MemberId = member.Id,
                Height = boy,
                Weight = kilo,
                BodyFat = yag,
                DateRecorded = DateTime.Now
            };

            try
            {
                _statRepo.Add(stat);
                lblVKISonuc.Text = $"Yeni VKİ: {stat.BMI:F1}";
                MessageBox.Show("Fiziksel istatistik kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt sırasında hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EgzersizHavuzunuDoldur()
        {
            tcKategoriler.TabPages.Clear();
            var allExercises = ExerciseDataStore.GetAllExercises();
            var grouped = allExercises.GroupBy(x => x.Category).ToList();

            foreach (var group in grouped)
            {
                var tabPage = new TabPage(group.Key);
                tabPage.BackColor = ThemeManager.BackgroundColor;
                tabPage.ForeColor = ThemeManager.TextColor;
                
                var flowLayout = new FlowLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    AutoScroll = true,
                    Padding = new Padding(10),
                    BackColor = ThemeManager.BackgroundColor
                };

                foreach (var ex in group)
                {
                    var pnlCard = new Panel
                    {
                        Width = 400,
                        Height = 60,
                        BorderStyle = BorderStyle.FixedSingle,
                        Margin = new Padding(5),
                        BackColor = ThemeManager.PanelColor
                    };

                    var lblName = new Label
                    {
                        Text = ex.Name,
                        Font = new Font("Segoe UI", 10, FontStyle.Bold),
                        Location = new Point(10, 20),
                        AutoSize = true,
                        ForeColor = ThemeManager.TextColor
                    };

                    var btnEkle = new Button
                    {
                        Text = "➕ Ekle",
                        Location = new Point(230, 15),
                        Size = new Size(70, 30),
                        BackColor = ThemeManager.PrimaryColor,
                        ForeColor = Color.Black,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Cursor = Cursors.Hand
                    };
                    btnEkle.FlatAppearance.BorderSize = 0;
                    btnEkle.Click += (s, ev) => EgzersizEkle(ex.Name);

                    var btnVideo = new Button
                    {
                        Text = "🎥 İzle",
                        Location = new Point(310, 15),
                        Size = new Size(70, 30),
                        BackColor = Color.FromArgb(50, 50, 50),
                        ForeColor = ThemeManager.PrimaryColor,
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Segoe UI", 9, FontStyle.Bold),
                        Cursor = Cursors.Hand
                    };
                    btnVideo.FlatAppearance.BorderColor = ThemeManager.PrimaryColor;
                    btnVideo.FlatAppearance.BorderSize = 1;
                    btnVideo.Click += (s, ev) => VideoAc(ex.VideoUrl);

                    pnlCard.Controls.Add(lblName);
                    pnlCard.Controls.Add(btnEkle);
                    pnlCard.Controls.Add(btnVideo);

                    flowLayout.Controls.Add(pnlCard);
                }

                tabPage.Controls.Add(flowLayout);
                tcKategoriler.TabPages.Add(tabPage);
            }
        }

        private void EgzersizEkle(string name)
        {
            _programTable.Rows.Add(name, 3, 10);
        }

        private void VideoAc(string url)
        {
            try
            {
                Process.Start(new ProcessStartInfo
                {
                    FileName = url,
                    UseShellExecute = true
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Video linki açılamadı: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEgzersizCikar_Click(object sender, EventArgs e)
        {
            if (dgvProgram.SelectedRows.Count > 0)
            {
                foreach(DataGridViewRow row in dgvProgram.SelectedRows)
                {
                    if (!row.IsNewRow)
                    {
                        dgvProgram.Rows.Remove(row);
                    }
                }
            }
        }

        private void btnProgramiKaydet_Click(object sender, EventArgs e)
        {
            if (cmbUye.SelectedIndex < 0)
            {
                MessageBox.Show("Lütfen bir üye seçiniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var member = _members[cmbUye.SelectedIndex];
            var exercises = new List<PTProgramExercise>();

            foreach (DataRow row in _programTable.Rows)
            {
                exercises.Add(new PTProgramExercise
                {
                    ExerciseName = row["Egzersiz"].ToString()!,
                    Sets = Convert.ToInt32(row["Set"]),
                    Reps = Convert.ToInt32(row["Tekrar"])
                });
            }

            try
            {
                _programRepo.SaveProgram(member.Id, exercises);
                MessageBox.Show("Program başarıyla kaydedildi!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Program kaydedilirken hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
