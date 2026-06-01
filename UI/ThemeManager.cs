using System.Drawing;
using System.Windows.Forms;

namespace GymManagement.UI
{
    public static class ThemeManager
    {
        public static Color BackgroundColor = Color.FromArgb(18, 18, 18);
        public static Color PanelColor = Color.FromArgb(34, 34, 34);
        public static Color PrimaryColor = Color.FromArgb(250, 204, 21);
        public static Color TextColor = Color.White;
        public static Color MutedTextColor = Color.FromArgb(170, 170, 170);

        public static void ApplyTheme(Form form)
        {
            form.BackColor = BackgroundColor;
            form.ForeColor = TextColor;
            form.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            ApplyToControls(form.Controls);
        }

        private static void ApplyToControls(Control.ControlCollection controls)
        {
            foreach (Control control in controls)
            {
                if (control is Panel panel && panel.GetType() == typeof(Panel))
                {
                    panel.BackColor = PanelColor;
                    panel.ForeColor = TextColor;
                }
                else if (control is GroupBox gb)
                {
                    gb.ForeColor = PrimaryColor;
                    gb.BackColor = BackgroundColor;
                    gb.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    foreach (Control child in gb.Controls)
                    {
                        if (child is Label || child is TextBox || child is ComboBox || child is DateTimePicker)
                        {
                            child.Font = new Font("Segoe UI", 10F, FontStyle.Regular);
                            child.ForeColor = TextColor;
                        }
                    }
                }
                else if (control is Button btn)
                {
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = PrimaryColor;
                    btn.ForeColor = Color.Black;
                    btn.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    btn.Cursor = Cursors.Hand;
                }
                else if (control is TextBox txt)
                {
                    txt.BackColor = PanelColor;
                    txt.ForeColor = TextColor;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (control is ComboBox cmb)
                {
                    cmb.BackColor = PanelColor;
                    cmb.ForeColor = TextColor;
                    cmb.FlatStyle = FlatStyle.Flat;
                }
                else if (control is DataGridView dgv)
                {
                    dgv.BackgroundColor = BackgroundColor;
                    dgv.BorderStyle = BorderStyle.None;
                    dgv.GridColor = Color.FromArgb(64, 64, 64);
                    dgv.DefaultCellStyle.BackColor = PanelColor;
                    dgv.DefaultCellStyle.ForeColor = TextColor;
                    dgv.DefaultCellStyle.SelectionBackColor = PrimaryColor;
                    dgv.DefaultCellStyle.SelectionForeColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = PrimaryColor;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
                    dgv.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
                    dgv.EnableHeadersVisualStyles = false;
                }
                else if (control is MenuStrip menu)
                {
                    menu.BackColor = PanelColor;
                    menu.ForeColor = TextColor;
                }
                else if (control is ToolStrip ts)
                {
                    ts.BackColor = PanelColor;
                    ts.ForeColor = TextColor;
                }
                else if (control is StatusStrip ss)
                {
                    ss.BackColor = PanelColor;
                    ss.ForeColor = TextColor;
                }
                if (control.HasChildren)
                {
                    ApplyToControls(control.Controls);
                }
            }
        }
    }
}
