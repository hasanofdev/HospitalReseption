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
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPicture)).BeginInit();
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
            this.DoctorFullNameLbl.Size = new System.Drawing.Size(265, 65);
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
            // DoctorUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(38)))), ((int)(((byte)(59)))));
            this.Controls.Add(this.ExperienceLbl);
            this.Controls.Add(this.DoctorFullNameLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorPicture);
            this.Name = "DoctorUserControl";
            this.Size = new System.Drawing.Size(360, 97);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox DoctorPicture;
        private Label label1;
        private Label DoctorFullNameLbl;
        private Label ExperienceLbl;
    }
}
