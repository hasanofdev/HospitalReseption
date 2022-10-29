namespace HospitalReseption.Forms;

partial class HospitalRegestration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HospitalRegestration));
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.ErrorLbl = new System.Windows.Forms.Label();
            this.PhoneTxt = new System.Windows.Forms.MaskedTextBox();
            this.EnterBtn = new System.Windows.Forms.Button();
            this.EmailTxt = new System.Windows.Forms.TextBox();
            this.EmailLbl = new System.Windows.Forms.Label();
            this.PhoneLbl = new System.Windows.Forms.Label();
            this.SurnameTxt = new System.Windows.Forms.TextBox();
            this.SurnameLbl = new System.Windows.Forms.Label();
            this.NameTxt = new System.Windows.Forms.TextBox();
            this.NameLbl = new System.Windows.Forms.Label();
            this.WelcomeLbl = new System.Windows.Forms.Label();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.DoctorsLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.DoctorsLbl = new System.Windows.Forms.Label();
            this.HeaderPanel = new System.Windows.Forms.Panel();
            this.PasientFullnameLbl = new System.Windows.Forms.Label();
            this.RegisterPanel.SuspendLayout();
            this.MainPanel.SuspendLayout();
            this.HeaderPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(27)))), ((int)(((byte)(42)))));
            this.RegisterPanel.Controls.Add(this.ErrorLbl);
            this.RegisterPanel.Controls.Add(this.PhoneTxt);
            this.RegisterPanel.Controls.Add(this.EnterBtn);
            this.RegisterPanel.Controls.Add(this.EmailTxt);
            this.RegisterPanel.Controls.Add(this.EmailLbl);
            this.RegisterPanel.Controls.Add(this.PhoneLbl);
            this.RegisterPanel.Controls.Add(this.SurnameTxt);
            this.RegisterPanel.Controls.Add(this.SurnameLbl);
            this.RegisterPanel.Controls.Add(this.NameTxt);
            this.RegisterPanel.Controls.Add(this.NameLbl);
            this.RegisterPanel.Controls.Add(this.WelcomeLbl);
            this.RegisterPanel.Location = new System.Drawing.Point(225, 112);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(350, 350);
            this.RegisterPanel.TabIndex = 0;
            // 
            // ErrorLbl
            // 
            this.ErrorLbl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ErrorLbl.ForeColor = System.Drawing.Color.Red;
            this.ErrorLbl.Location = new System.Drawing.Point(0, 286);
            this.ErrorLbl.Name = "ErrorLbl";
            this.ErrorLbl.Size = new System.Drawing.Size(350, 64);
            this.ErrorLbl.TabIndex = 7;
            this.ErrorLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PhoneTxt
            // 
            this.PhoneTxt.Culture = new System.Globalization.CultureInfo("az-Latn-AZ");
            this.PhoneTxt.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneTxt.Location = new System.Drawing.Point(95, 157);
            this.PhoneTxt.Mask = "999-000-0000";
            this.PhoneTxt.Name = "PhoneTxt";
            this.PhoneTxt.Size = new System.Drawing.Size(161, 23);
            this.PhoneTxt.TabIndex = 2;
            this.PhoneTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.PhoneTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // EnterBtn
            // 
            this.EnterBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(141)))), ((int)(((byte)(169)))));
            this.EnterBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EnterBtn.FlatAppearance.BorderSize = 0;
            this.EnterBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Black;
            this.EnterBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EnterBtn.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EnterBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.EnterBtn.Location = new System.Drawing.Point(95, 250);
            this.EnterBtn.Name = "EnterBtn";
            this.EnterBtn.Size = new System.Drawing.Size(160, 33);
            this.EnterBtn.TabIndex = 4;
            this.EnterBtn.Text = "Enter";
            this.EnterBtn.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EnterBtn.UseVisualStyleBackColor = false;
            this.EnterBtn.Click += new System.EventHandler(this.EnterBtn_Click);
            // 
            // EmailTxt
            // 
            this.EmailTxt.Location = new System.Drawing.Point(95, 209);
            this.EmailTxt.Name = "EmailTxt";
            this.EmailTxt.PlaceholderText = "Enter Your Email";
            this.EmailTxt.Size = new System.Drawing.Size(160, 23);
            this.EmailTxt.TabIndex = 3;
            this.EmailTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.EmailTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // EmailLbl
            // 
            this.EmailLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.EmailLbl.Location = new System.Drawing.Point(0, 183);
            this.EmailLbl.Name = "EmailLbl";
            this.EmailLbl.Size = new System.Drawing.Size(350, 23);
            this.EmailLbl.TabIndex = 6;
            this.EmailLbl.Text = "Email";
            this.EmailLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PhoneLbl
            // 
            this.PhoneLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PhoneLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.PhoneLbl.Location = new System.Drawing.Point(0, 133);
            this.PhoneLbl.Name = "PhoneLbl";
            this.PhoneLbl.Size = new System.Drawing.Size(350, 23);
            this.PhoneLbl.TabIndex = 4;
            this.PhoneLbl.Text = "Phone";
            this.PhoneLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SurnameTxt
            // 
            this.SurnameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.SurnameTxt.Location = new System.Drawing.Point(180, 107);
            this.SurnameTxt.Name = "SurnameTxt";
            this.SurnameTxt.PlaceholderText = "Enter Your Surname";
            this.SurnameTxt.Size = new System.Drawing.Size(160, 23);
            this.SurnameTxt.TabIndex = 1;
            this.SurnameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SurnameTxt.TextChanged += new System.EventHandler(this.PasientFullName_TextChanged);
            this.SurnameTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // SurnameLbl
            // 
            this.SurnameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SurnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.SurnameLbl.Location = new System.Drawing.Point(180, 83);
            this.SurnameLbl.Name = "SurnameLbl";
            this.SurnameLbl.Size = new System.Drawing.Size(160, 21);
            this.SurnameLbl.TabIndex = 2;
            this.SurnameLbl.Text = "Surname";
            this.SurnameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NameTxt
            // 
            this.NameTxt.AutoCompleteCustomSource.AddRange(new string[] {
            ""});
            this.NameTxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.NameTxt.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.NameTxt.Location = new System.Drawing.Point(10, 107);
            this.NameTxt.Name = "NameTxt";
            this.NameTxt.PlaceholderText = "Enter Your Name";
            this.NameTxt.Size = new System.Drawing.Size(160, 23);
            this.NameTxt.TabIndex = 0;
            this.NameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.NameTxt.TextChanged += new System.EventHandler(this.PasientFullName_TextChanged);
            this.NameTxt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Txt_MouseDown);
            // 
            // NameLbl
            // 
            this.NameLbl.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.NameLbl.Location = new System.Drawing.Point(10, 83);
            this.NameLbl.Name = "NameLbl";
            this.NameLbl.Size = new System.Drawing.Size(160, 21);
            this.NameLbl.TabIndex = 0;
            this.NameLbl.Text = "Name";
            this.NameLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // WelcomeLbl
            // 
            this.WelcomeLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.WelcomeLbl.Font = new System.Drawing.Font("Gabriola", 27.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.WelcomeLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(225)))), ((int)(((byte)(221)))));
            this.WelcomeLbl.Location = new System.Drawing.Point(0, 0);
            this.WelcomeLbl.Name = "WelcomeLbl";
            this.WelcomeLbl.Size = new System.Drawing.Size(350, 52);
            this.WelcomeLbl.TabIndex = 0;
            this.WelcomeLbl.Text = "Welcome";
            this.WelcomeLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MainPanel
            // 
            this.MainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.MainPanel.Controls.Add(this.DoctorsLayout);
            this.MainPanel.Controls.Add(this.DoctorsLbl);
            this.MainPanel.Controls.Add(this.HeaderPanel);
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(0, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(884, 561);
            this.MainPanel.TabIndex = 1;
            // 
            // DoctorsLayout
            // 
            this.DoctorsLayout.AutoScroll = true;
            this.DoctorsLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsLayout.Location = new System.Drawing.Point(0, 109);
            this.DoctorsLayout.Name = "DoctorsLayout";
            this.DoctorsLayout.Size = new System.Drawing.Size(884, 452);
            this.DoctorsLayout.TabIndex = 3;
            // 
            // DoctorsLbl
            // 
            this.DoctorsLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorsLbl.Font = new System.Drawing.Font("Sitka Small", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoctorsLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(183)))), ((int)(((byte)(136)))));
            this.DoctorsLbl.Location = new System.Drawing.Point(0, 55);
            this.DoctorsLbl.Name = "DoctorsLbl";
            this.DoctorsLbl.Size = new System.Drawing.Size(884, 54);
            this.DoctorsLbl.TabIndex = 2;
            this.DoctorsLbl.Text = "Doctors";
            this.DoctorsLbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HeaderPanel
            // 
            this.HeaderPanel.Controls.Add(this.PasientFullnameLbl);
            this.HeaderPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.HeaderPanel.Location = new System.Drawing.Point(0, 0);
            this.HeaderPanel.Name = "HeaderPanel";
            this.HeaderPanel.Size = new System.Drawing.Size(884, 55);
            this.HeaderPanel.TabIndex = 0;
            // 
            // PasientFullnameLbl
            // 
            this.PasientFullnameLbl.Dock = System.Windows.Forms.DockStyle.Top;
            this.PasientFullnameLbl.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PasientFullnameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.PasientFullnameLbl.Location = new System.Drawing.Point(0, 0);
            this.PasientFullnameLbl.Name = "PasientFullnameLbl";
            this.PasientFullnameLbl.Size = new System.Drawing.Size(884, 55);
            this.PasientFullnameLbl.TabIndex = 0;
            this.PasientFullnameLbl.Text = "Pasient Fullname - Phone";
            this.PasientFullnameLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // HospitalRegestration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(90)))), ((int)(((byte)(119)))));
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.RegisterPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HospitalRegestration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Regestration";
            this.SizeChanged += new System.EventHandler(this.HospitalRegestration_SizeChanged);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.MainPanel.ResumeLayout(false);
            this.HeaderPanel.ResumeLayout(false);
            this.ResumeLayout(false);

    }

    #endregion

    private Panel RegisterPanel;
    private Label WelcomeLbl;
    private TextBox SurnameTxt;
    private TextBox EmailTxt;
    private Button EnterBtn;
    private Label EmailLbl;
    private Label PhoneLbl;
    private Label SurnameLbl;
    private Label NameLbl;
    private Panel MainPanel;
    private MaskedTextBox PhoneTxt;
    private TextBox NameTxt;
    private Panel HeaderPanel;
    private Label PasientFullnameLbl;
    private Label DoctorsLbl;
    private Label ErrorLbl;
    private FlowLayoutPanel DoctorsLayout;
}