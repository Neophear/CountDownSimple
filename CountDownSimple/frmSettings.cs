using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CountDownSimple
{
    public partial class frmSettings : Form
    {
        Form1 frm;
        public frmSettings(Form1 f)
        {
            InitializeComponent();
            frm = f;

            lblVersion.Text = String.Format("Made by Stiig Gade - stiiggade@gmail.com - Version {0}", ProductVersion);
            dtpDate.Value = frm.settings.TargetDate;
            mtxtTime.Text = frm.settings.TargetDate.ToShortTimeString();
            txtFormat.Text = frm.settings.TextFormat.Replace("\n", Environment.NewLine);

            fdTextFont.Font = frm.settings.TextFont;
            chkbxShowInfoText.Checked = frm.settings.ShowBottomText;
            chkbxAlwaysOnTop.Checked = frm.settings.AlwaysOnTop;

            cdFontColor.Color = frm.settings.ForeColor;
            cdBackgroundColor.Color = frm.settings.BackgroundColor;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DateTime pickedTime = dtpDate.Value.Date;
            if (ValidateTime())
            {
                pickedTime = pickedTime.AddHours(int.Parse(mtxtTime.Text.Substring(0, 2)));
                pickedTime = pickedTime.AddMinutes(int.Parse(mtxtTime.Text.Substring(2, 2)));
            }
            frm.settings.TargetDate = pickedTime;
            frm.settings.ShowBottomText = chkbxShowInfoText.Checked;
            frm.settings.AlwaysOnTop = chkbxAlwaysOnTop.Checked;
            frm.settings.TextFont = fdTextFont.Font;
            frm.settings.BackgroundColor = cdBackgroundColor.Color;
            frm.settings.ForeColor = cdFontColor.Color;
            frm.settings.TextFormat = txtFormat.Text;

            DialogResult = DialogResult.OK;
        }

        private bool ValidateTime()
        {
            if (mtxtTime.Text != String.Empty)
            {
                Regex checkDigits = new Regex(@"\d{4}");
                if (checkDigits.IsMatch(mtxtTime.Text))
                {
                    int hourPart = int.Parse(mtxtTime.Text.Substring(0, 2));
                    int minutePart = int.Parse(mtxtTime.Text.Substring(2, 2));
                    if (hourPart > 23 || minutePart > 59)
                        return false;
                }
            }

            return true;
        }

        private void btnChangeFont_Click(object sender, EventArgs e)
        {
            fdTextFont.ShowDialog();
        }

        private void btnFontColor_Click(object sender, EventArgs e)
        {
            cdFontColor.ShowDialog();
        }

        private void btnBackgroundColor_Click(object sender, EventArgs e)
        {
            cdBackgroundColor.ShowDialog();
        }
    }
}
