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
        public DoctorUserControl(string ImageUrl, string Name, string Surname, int Experience)
        {
            InitializeComponent();

            DoctorPicture.Load(ImageUrl);
            DoctorFullNameLbl.Text = Name + "\n" + Surname;
            ExperienceLbl.Text += Experience.ToString();
        }
    }
}
