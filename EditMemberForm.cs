using GymManagement.Data;
using GymManagement.Models;
using System.Text.RegularExpressions;

using GymManagement.UI;

namespace GymManagement
{
    public partial class EditMemberForm : Form
    {
        private readonly int _memberId;
        private readonly MemberRepository _memberRepo = new();
        private Member? _currentMember;

        public EditMemberForm(int memberId)
        {
            _memberId = memberId;
            InitializeComponent();
            ThemeManager.ApplyTheme(this);
        }

        private void EditMemberForm_Load(object sender, EventArgs e)
        {
            _currentMember = _memberRepo.GetById(_memberId);
            if (_currentMember == null)
            {
                MessageBox.Show("Üye bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            txtAd.Text = _currentMember.FirstName;
            txtSoyad.Text = _currentMember.LastName;
            txtTelefon.Text = _currentMember.Phone;
            txtEmail.Text = _currentMember.Email;
            
            if (!string.IsNullOrEmpty(_currentMember.Gender))
                cmbCinsiyet.SelectedItem = _currentMember.Gender;
                
            dtpDogumTarihi.Value = _currentMember.BirthDate;
            chkAktifMi.Checked = _currentMember.IsActive;
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (_currentMember == null) return;
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
            if (!Regex.IsMatch(phone, @"^\d{10,11}$"))
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
            _currentMember.FirstName = txtAd.Text.Trim();
            _currentMember.LastName = txtSoyad.Text.Trim();
            _currentMember.Phone = phone;
            _currentMember.Email = email;
            _currentMember.Gender = cmbCinsiyet.SelectedItem!.ToString()!;
            _currentMember.BirthDate = dtpDogumTarihi.Value.Date;
            _currentMember.IsActive = chkAktifMi.Checked;

            try
            {
                _memberRepo.Update(_currentMember);
                MessageBox.Show("Üye bilgileri başarıyla güncellendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Güncelleme sırasında hata oluştu:\n{ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKapat_Click(object sender, EventArgs e) => this.Close();
    }
}
