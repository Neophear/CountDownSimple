namespace CountDownSimple
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.ctlblTimer = new CountDownSimple.clickThroughLabel();
            this.ctlblBottom = new CountDownSimple.clickThroughLabel();
            this.SuspendLayout();
            // 
            // ctlblTimer
            // 
            this.ctlblTimer.BackColor = System.Drawing.Color.Transparent;
            this.ctlblTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ctlblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctlblTimer.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ctlblTimer.ForeColor = System.Drawing.Color.White;
            this.ctlblTimer.Location = new System.Drawing.Point(0, 0);
            this.ctlblTimer.Name = "ctlblTimer";
            this.ctlblTimer.Size = new System.Drawing.Size(500, 75);
            this.ctlblTimer.TabIndex = 0;
            this.ctlblTimer.Text = "F1 for indstillinger";
            this.ctlblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ctlblBottom
            // 
            this.ctlblBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctlblBottom.ForeColor = System.Drawing.Color.White;
            this.ctlblBottom.Location = new System.Drawing.Point(0, 75);
            this.ctlblBottom.Name = "ctlblBottom";
            this.ctlblBottom.Size = new System.Drawing.Size(500, 25);
            this.ctlblBottom.TabIndex = 1;
            this.ctlblBottom.Text = "F1 for indstillinger. ESC for at lukke.";
            this.ctlblBottom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(500, 100);
            this.Controls.Add(this.ctlblTimer);
            this.Controls.Add(this.ctlblBottom);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(100, 25);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Countdown";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.HelpRequested += new System.Windows.Forms.HelpEventHandler(this.Form1_HelpRequested);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.Form1_PreviewKeyDown);
            this.ResumeLayout(false);

        }

        #endregion

        private clickThroughLabel ctlblTimer;
        private clickThroughLabel ctlblBottom;
    }
}

