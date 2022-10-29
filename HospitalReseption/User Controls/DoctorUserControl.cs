using HospitalReseption.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalReseption.User_Controls
{
    public partial class DoctorUserControl : UserControl
    {
        public Doctor _Doctor { get; set; }
        public DoctorUserControl(Doctor doctor)
        {
            InitializeComponent();
            _Doctor = doctor;
            DoctorPicture.Load(_Doctor.ImageUrl);
            DoctorFullNameLbl.Text = _Doctor.Name + "\n" + _Doctor.Surname;
            ExperienceLbl.Text += _Doctor.Experience.ToString();
        }

        private void ReservBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void CancelSubmitBtnClick_Btn_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;

            switch (btn.Text)
            {
                case "Submit":
                    if (ReservTimesCombo.SelectedItem is not null)
                    {
                        ReservTimesCombo.Items.Remove(ReservTimesCombo.SelectedItem.ToString());
                        _Doctor.ReservTimes.Remove(ReservTimesCombo.SelectedItem.ToString());
                        var mainPanel = this.Parent.Parent as Panel;
                        var form = mainPanel.Parent;
                        foreach (var control in form.Controls)
                        {
                            if (control is Control control1 && control1.Name == "RegisterPanel")
                            {
                                control1.Refresh();
                                control1.Visible = true;
                            }
                        }
                        mainPanel.Refresh();
                        mainPanel.Visible = false;
                    }
                    break;
                case "Cancel":
                    panel1.Visible = false;
                    break;
                default:
                    break;

            }
        }
    }
}