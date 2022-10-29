namespace HospitalReseption.User_Controls
{
    partial class DoctorUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DoctorPicture = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.DoctorFullNameLbl = new System.Windows.Forms.Label();
            this.ExperienceLbl = new System.Windows.Forms.Label();
            this.ReservBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CancelBtn = new System.Windows.Forms.Button();
            this.SubmitBtn = new System.Windows.Forms.Button();
            this.ReservTimesCombo = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPicture)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorPicture
            // 
            this.DoctorPicture.Location = new System.Drawing.Point(0, 0);
            this.DoctorPicture.Name = "DoctorPicture";
            this.DoctorPicture.Size = new System.Drawing.Size(86, 95);
            this.DoctorPicture.TabIndex = 0;
            this.DoctorPicture.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(92, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Dr.";
            // 
            // DoctorFullNameLbl
            // 
            this.DoctorFullNameLbl.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DoctorFullNameLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(211)))), ((int)(((byte)(168)))));
            this.DoctorFullNameLbl.Location = new System.Drawing.Point(92, 30);
            this.DoctorFullNameLbl.Name = "DoctorFullNameLbl";
            this.DoctorFullNameLbl.Size = new System.Drawing.Size(165, 65);
            this.DoctorFullNameLbl.TabIndex = 2;
            // 
            // ExperienceLbl
            // 
            this.ExperienceLbl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ExperienceLbl.ForeColor = System.Drawing.Color.Yellow;
            this.ExperienceLbl.Location = new System.Drawing.Point(263, 0);
            this.ExperienceLbl.Name = "ExperienceLbl";
            this.ExperienceLbl.Size = new System.Drawing.Size(94, 30);
            this.ExperienceLbl.TabIndex = 3;
            this.ExperienceLbl.Text = "Experience: ";
            this.ExperienceLbl.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // ReservBtn
            // 
            this.ReservBtn.BackColor = System.Drawing.Color.DarkCyan;
            this.ReservBtn.FlatAppearance.BorderSize = 0;
            this.ReservBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReservBtn.Location = new System.Drawing.Point(266, 71);
            this.ReservBtn.Name = "ReservBtn";
            this.ReservBtn.Size = new System.Drawing.Size(94, 23);
            this.ReservBtn.TabIndex = 4;
            this.ReservBtn.Text = "Reserv";
            this.ReservBtn.UseVisualStyleBackColor = false;
            this.ReservBtn.Click += new System.EventHandler(this.ReservBtn_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CancelBtn);
            this.panel1.Controls.Add(this.SubmitBtn);
            this.panel1.Controls.Add(this.ReservTimesCombo);
            this.panel1.Location = new System.Drawing.Point(235, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 94);
            this.panel1.TabIndex = 5;
            this.panel1.Visible = false;
            // 
            // CancelBtn
            // 
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.CancelBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelBtn.ForeColor = System.Drawing.Color.White;
            this.CancelBtn.Location = new System.Drawing.Point(0, 46);
            this.CancelBtn.Name = "CancelBtn";
            this.CancelBtn.Size = new System.Drawing.Size(125, 23);
            this.CancelBtn.TabIndex = 2;
            this.CancelBtn.Text = "Cancel";
            this.CancelBtn.UseVisualStyleBackColor = true;
            this.CancelBtn.Click += new System.EventHandler(this.CancelSubmitBtnClick_Btn_Click);
            // 
            // SubmitBtn
            // 
            this.SubmitBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.SubmitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubmitBtn.ForeColor = System.Drawing.Color.White;
            this.SubmitBtn.Location = new System.Drawing.Point(0, 23);
            this.SubmitBtn.Name = "SubmitBtn";
            this.SubmitBtn.Size = new System.Drawing.Size(125, 23);
            this.SubmitBtn.TabIndex = 1;
            this.SubmitBtn.Text = "Submit";
            this.SubmitBtn.UseVisualStyleBackColor = true;
            this.SubmitBtn.Click += new System.EventHandler(this.CancelSubmitBtnClick_Btn_Click);
            // 
            // ReservTimesCombo
            // 
            this.ReservTimesCombo.Dock = System.Windows.Forms.DockStyle.Top;
            this.ReservTimesCombo.FormattingEnabled = true;
            this.ReservTimesCombo.Location = new System.Drawing.Point(0, 0);
            this.ReservTimesCombo.Name = "ReservTimesCombo";
            this.ReservTimesCombo.Size = new System.Drawing.Size(125, 23);
            this.ReservTimesCombo.TabIndex = 0;
            // 
            // DoctorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ReservBtn);
            this.Controls.Add(this.ExperienceLbl);
            this.Controls.Add(this.DoctorFullNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorPicture);
            this.Name = "DoctorUserControl";
            this.Size = new System.Drawing.Size(360, 97);
            this.Click += new System.EventHandler(this.CancelSubmitBtnClick_Btn_Click);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPicture)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DoctorPicture;
        private Label label1;
        private Label DoctorFullNameLbl;
        private Label ExperienceLbl;
        private Button ReservBtn;
        private Panel panel1;
        private Button CancelBtn;
        private Button SubmitBtn;
        private ComboBox ReservTimesCombo;
    }
}
