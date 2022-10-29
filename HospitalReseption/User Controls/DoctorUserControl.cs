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

            foreach (var time in _Doctor.ReservTimes!)
                ReservTimesCombo.Items.Add(time);
        }

        private void ReservBtn_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
        }

        private void CancelSubmitBtnClick_Btn_Click(object sender, EventArgs e)
        {
            Button? btn = sender as Button;

            if (btn is null)
                return;

            switch (btn!.Text)
            {
                case "Submit":
                    if (ReservTimesCombo.SelectedItem is not null)
                    {
                        _Doctor.ReservTimes!.Remove(ReservTimesCombo.SelectedItem.ToString()!);
                        ReservTimesCombo.Items.Remove(ReservTimesCombo.SelectedItem.ToString());

                        var mainPanel = this.Parent.Parent as Panel;
                        var form = mainPanel!.Parent;

                        foreach (var control in form.Controls)
                            if (control is Control control1 && control1.Name == "RegisterPanel")
                                control1.Visible = true;

                        panel1.Visible = false;
                        mainPanel.Visible = false;
                    }
                    if (_Doctor.ReservTimes!.Count == 0)
                        btn.Enabled = false;
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