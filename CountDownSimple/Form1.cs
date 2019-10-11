using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CountDownSimple
{
    public partial class Form1 : Form
    {
        public Settings settings = Settings.Deserialize();
        private DetailedTimer timer = new DetailedTimer();

        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            this.SetStyle(ControlStyles.ResizeRedraw, true);

            LoadSettings();

            timer.OnSecondChange += Timer_OnSecondChange;
        }

        private void Timer_OnSecondChange(object sender, EventArgs e)
        {
            RefreshLabel();
        }

        private void LoadSettings(bool setWindow = true)
        {
            if (setWindow && settings.Location != Point.Empty)
                this.Location = settings.Location;

            if (setWindow && settings.WindowSize != Size.Empty)
                this.Size = settings.WindowSize;

            if (settings.TextFont != null)
                ctlblTimer.Font = settings.TextFont;

            if (settings.BackgroundColor != Color.Empty)
                this.BackColor = settings.BackgroundColor;

            if (settings.ForeColor != Color.Empty)
                ctlblTimer.ForeColor = ctlblBottom.ForeColor = settings.ForeColor;

            if (settings.TargetDate != null)
                timer.Start(settings.TargetDate);

            this.TopMost = settings.AlwaysOnTop;
            ctlblBottom.Visible = settings.ShowBottomText;
        }

        private void RefreshLabel()
        {
            ctlblTimer.Text = GetFriendlyTime();
            this.Text = GetFriendlyTime("[D]:[H]:[M]:[S]");
        }

        private void Form1_HelpRequested(object sender, HelpEventArgs hlpevent)
        {
            if (this.Focused)
            {
                frmSettings frm = new frmSettings(this);
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadSettings(false);
                    timer.Start(settings.TargetDate);
                }
            }
        }

        private void Form1_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.Close();
        }

        private const int cGrip = 4;      // Grip size

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {  // Trap WM_NCHITTEST
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = this.PointToClient(pos);

                if (pos.X <= cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)13; // HTTOPLEFT
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y <= cGrip)
                {
                    m.Result = (IntPtr)14; // HTTOPRIGHT
                    return;
                }
                if (pos.X <= cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)16; // HTBOTTOMLEFT
                    return;
                }
                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17; // HTBOTTOMRIGHT
                    return;
                }

                m.Result = (IntPtr)2;  // HTCAPTION
                return;
            }
            base.WndProc(ref m);
        }

        /// <summary>
        /// Returns a more userfriendly time.
        /// </summary>
        /// <param name="time">The DateTime to modify</param>
        /// <returns></returns>
        public string GetFriendlyTime(string format = "")
        {
            if (String.IsNullOrEmpty(format))
                format = settings.TextFormat;

            format = format.Replace("[D]", timer.Days.ToString());
            format = format.Replace("[DT]", (timer.Days == 1 ? "dag" : "dage"));
            format = format.Replace("[H]", timer.Hours.ToString());
            format = format.Replace("[HT]", (timer.Hours == 1 ? "time" : "timer"));
            format = format.Replace("[M]", timer.Minutes.ToString());
            format = format.Replace("[MT]", (timer.Minutes == 1 ? "minut" : "minutter"));
            format = format.Replace("[S]", timer.Seconds.ToString());
            format = format.Replace("[ST]", (timer.Seconds == 1 ? "sekund" : "sekunder"));
            format = format.Replace("[LOVE]", "❤️ Henriette ❤️");

            return format;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settings.Location = this.Location;
            settings.WindowSize = this.Size;
            Settings.Serialize(settings);
        }
    }
}