namespace CountDownSimple
{
    partial class frmSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSettings));
            this.chkbxAlwaysOnTop = new System.Windows.Forms.CheckBox();
            this.lblVersion = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.lblFormatHelp = new System.Windows.Forms.Label();
            this.lblFormat = new System.Windows.Forms.Label();
            this.txtFormat = new System.Windows.Forms.TextBox();
            this.cdBackgroundColor = new System.Windows.Forms.ColorDialog();
            this.btnBackgroundColor = new System.Windows.Forms.Button();
            this.btnFontColor = new System.Windows.Forms.Button();
            this.btnChangeFont = new System.Windows.Forms.Button();
            this.fdTextFont = new System.Windows.Forms.FontDialog();
            this.cdFontColor = new System.Windows.Forms.ColorDialog();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.mtxtTime = new System.Windows.Forms.MaskedTextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.chkbxShowInfoText = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // chkbxAlwaysOnTop
            // 
            this.chkbxAlwaysOnTop.AutoSize = true;
            this.chkbxAlwaysOnTop.Location = new System.Drawing.Point(238, 57);
            this.chkbxAlwaysOnTop.Name = "chkbxAlwaysOnTop";
            this.chkbxAlwaysOnTop.Size = new System.Drawing.Size(78, 21);
            this.chkbxAlwaysOnTop.TabIndex = 40;
            this.chkbxAlwaysOnTop.Text = "On Top";
            this.chkbxAlwaysOnTop.UseVisualStyleBackColor = true;
            // 
            // lblVersion
            // 
            this.lblVersion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblVersion.AutoSize = true;
            this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVersion.Location = new System.Drawing.Point(9, 374);
            this.lblVersion.Name = "lblVersion";
            this.lblVersion.Size = new System.Drawing.Size(52, 13);
            this.lblVersion.TabIndex = 39;
            this.lblVersion.Text = "lblVersion";
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.Location = new System.Drawing.Point(209, 349);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(107, 23);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Gem";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblFormatHelp
            // 
            this.lblFormatHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFormatHelp.AutoSize = true;
            this.lblFormatHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFormatHelp.Location = new System.Drawing.Point(9, 199);
            this.lblFormatHelp.Name = "lblFormatHelp";
            this.lblFormatHelp.Size = new System.Drawing.Size(284, 156);
            this.lblFormatHelp.TabIndex = 38;
            this.lblFormatHelp.Text = resources.GetString("lblFormatHelp.Text");
            // 
            // lblFormat
            // 
            this.lblFormat.AutoSize = true;
            this.lblFormat.Location = new System.Drawing.Point(12, 111);
            this.lblFormat.Name = "lblFormat";
            this.lblFormat.Size = new System.Drawing.Size(87, 17);
            this.lblFormat.TabIndex = 37;
            this.lblFormat.Text = "Tekst format";
            // 
            // txtFormat
            // 
            this.txtFormat.Location = new System.Drawing.Point(12, 131);
            this.txtFormat.Multiline = true;
            this.txtFormat.Name = "txtFormat";
            this.txtFormat.Size = new System.Drawing.Size(304, 65);
            this.txtFormat.TabIndex = 36;
            // 
            // btnBackgroundColor
            // 
            this.btnBackgroundColor.Location = new System.Drawing.Point(217, 85);
            this.btnBackgroundColor.Name = "btnBackgroundColor";
            this.btnBackgroundColor.Size = new System.Drawing.Size(99, 23);
            this.btnBackgroundColor.TabIndex = 35;
            this.btnBackgroundColor.Text = "Baggrund";
            this.btnBackgroundColor.UseVisualStyleBackColor = true;
            this.btnBackgroundColor.Click += new System.EventHandler(this.btnBackgroundColor_Click);
            // 
            // btnFontColor
            // 
            this.btnFontColor.Location = new System.Drawing.Point(112, 84);
            this.btnFontColor.Name = "btnFontColor";
            this.btnFontColor.Size = new System.Drawing.Size(99, 24);
            this.btnFontColor.TabIndex = 34;
            this.btnFontColor.Text = "Tekst farve";
            this.btnFontColor.UseVisualStyleBackColor = true;
            this.btnFontColor.Click += new System.EventHandler(this.btnFontColor_Click);
            // 
            // btnChangeFont
            // 
            this.btnChangeFont.Location = new System.Drawing.Point(12, 84);
            this.btnChangeFont.Name = "btnChangeFont";
            this.btnChangeFont.Size = new System.Drawing.Size(94, 24);
            this.btnChangeFont.TabIndex = 33;
            this.btnChangeFont.Text = "Skrifttype";
            this.btnChangeFont.UseVisualStyleBackColor = true;
            this.btnChangeFont.Click += new System.EventHandler(this.btnChangeFont_Click);
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(144, 9);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(28, 17);
            this.lblTime.TabIndex = 31;
            this.lblTime.Text = "Tid";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(12, 9);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(38, 17);
            this.lblDate.TabIndex = 30;
            this.lblDate.Text = "Dato";
            // 
            // mtxtTime
            // 
            this.mtxtTime.Location = new System.Drawing.Point(147, 29);
            this.mtxtTime.Mask = "00:00";
            this.mtxtTime.Name = "mtxtTime";
            this.mtxtTime.Size = new System.Drawing.Size(100, 22);
            this.mtxtTime.TabIndex = 29;
            this.mtxtTime.TextMaskFormat = System.Windows.Forms.MaskFormat.ExcludePromptAndLiterals;
            this.mtxtTime.ValidatingType = typeof(System.DateTime);
            // 
            // dtpDate
            // 
            this.dtpDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDate.Location = new System.Drawing.Point(15, 29);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(126, 22);
            this.dtpDate.TabIndex = 28;
            // 
            // chkbxShowInfoText
            // 
            this.chkbxShowInfoText.AutoSize = true;
            this.chkbxShowInfoText.Location = new System.Drawing.Point(12, 57);
            this.chkbxShowInfoText.Name = "chkbxShowInfoText";
            this.chkbxShowInfoText.Size = new System.Drawing.Size(110, 21);
            this.chkbxShowInfoText.TabIndex = 32;
            this.chkbxShowInfoText.Text = "Vis info tekst";
            this.chkbxShowInfoText.UseVisualStyleBackColor = true;
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 398);
            this.Controls.Add(this.chkbxAlwaysOnTop);
            this.Controls.Add(this.lblVersion);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.lblFormatHelp);
            this.Controls.Add(this.lblFormat);
            this.Controls.Add(this.txtFormat);
            this.Controls.Add(this.btnBackgroundColor);
            this.Controls.Add(this.btnFontColor);
            this.Controls.Add(this.btnChangeFont);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblDate);
            this.Controls.Add(this.mtxtTime);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.chkbxShowInfoText);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(343, 500);
            this.MinimumSize = new System.Drawing.Size(343, 445);
            this.Name = "frmSettings";
            this.ShowInTaskbar = false;
            this.Text = "Indstillinger";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox chkbxAlwaysOnTop;
        private System.Windows.Forms.Label lblVersion;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lblFormatHelp;
        private System.Windows.Forms.Label lblFormat;
        private System.Windows.Forms.TextBox txtFormat;
        private System.Windows.Forms.ColorDialog cdBackgroundColor;
        private System.Windows.Forms.Button btnBackgroundColor;
        private System.Windows.Forms.Button btnFontColor;
        private System.Windows.Forms.Button btnChangeFont;
        private System.Windows.Forms.FontDialog fdTextFont;
        private System.Windows.Forms.ColorDialog cdFontColor;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.MaskedTextBox mtxtTime;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.CheckBox chkbxShowInfoText;
    }
}