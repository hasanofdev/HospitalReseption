using Bogus;
using HospitalReseption.Models;
using HospitalReseption.User_Controls;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalReseption.Forms;
public partial class HospitalRegestration : System.Windows.Forms.Form
{
    public Size WindowSize;
    public List<Doctor> Doctors;

    public string PhonePattern = @"^(050|051|055|070|077|099).*$";
    public string AllCharPattern = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
    public string MailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
    public HospitalRegestration()
    {
        
        InitializeComponent();
        Doctors = new();
        WindowSize = new Size(Size.Width, Size.Height);
        MainPanel.Visible = false;
        RegisterPanel.BringToFront();
    }

    private void HospitalRegestration_SizeChanged(object sender, EventArgs e)
    {
        if (Size.Width == 160 && Size.Height == 28)
            return;

        if (Size.Width > WindowSize.Width || Size.Height > WindowSize.Height)
        {
            RegisterPanel.Location = new Point((this.Size.Width / 2) - (RegisterPanel.Width / 2), (WindowSize.Height / 2 - 13) - (RegisterPanel.Height / 2));
            WindowSize = this.Size;
        }
        if (WindowSize.Height > Size.Height || WindowSize.Width > Size.Width)
        {
            WindowSize = this.Size;
            RegisterPanel!.Location = new Point((this.Size.Width / 2) - (RegisterPanel.Width / 2), (WindowSize.Height / 2 - 13) - (RegisterPanel.Height / 2));
        }
    }

    private void PasientFullName_TextChanged(object sender, EventArgs e)
    {
        var tb = sender as TextBox;
        if (!Regex.IsMatch(tb!.Text, AllCharPattern) || tb.Text.Length < 3)
            tb.ForeColor = Color.Red;
        else tb.ForeColor = Color.Black;
    }

    private void EnterBtn_Click(object sender, EventArgs e)
    {
        bool FullnameIsCorrect = (Regex.IsMatch(NameTxt.Text, AllCharPattern) && Regex.IsMatch(SurnameTxt.Text, AllCharPattern))
            && (NameTxt.Text.Length > 2 && SurnameTxt.Text.Length > 2);
        string Phone = PhoneTxt.Text.Split('-')[0] + PhoneTxt.Text.Split('-')[1] + PhoneTxt.Text.Split('-')[2];
        if ((Regex.IsMatch(EmailTxt.Text, MailPattern) && Regex.IsMatch(Phone, PhonePattern) && Phone.Length == 10) && FullnameIsCorrect)
        {
            Pasient pasient = new Pasient(NameTxt.Text, SurnameTxt.Text, PhoneTxt.Text, EmailTxt.Text);
            RegisterPanel.Visible = false;
            MainPanel.Visible = true;
            PasientFullnameLbl.Text = pasient.Name + " " + pasient.Surname + " - " + Phone;
            RegisterPanel.Visible = false;
            return;
        }
        StringBuilder errorMessage = new StringBuilder("");

        if (!Regex.IsMatch(EmailTxt.Text, MailPattern))
            errorMessage.Append("Email is Incorrect!\n");
        if (!Regex.IsMatch(Phone, PhonePattern))
            errorMessage.Append("Phone Number is Incorreсt!\n");
        if (!FullnameIsCorrect)
            errorMessage.Append("The full name must contain only letters and cannot be shorter than 3 letters!");

        ErrorLbl.Text = errorMessage.ToString();


    }

    protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
    {
        if (keyData == Keys.Enter)
        {
            if (this.ActiveControl.Handle != EnterBtn.Handle)
                this.SelectNextControl(EmailTxt, true, true, true, true);
        }
        return base.ProcessCmdKey(ref msg, keyData);
    }

    private void Txt_MouseDown(object sender, MouseEventArgs e)
    {
        if (e.Button == MouseButtons.Left)
            ErrorLbl.Text = String.Empty;
    }

    public void FakeDataGen(int count)
    {
        DoctorsLayout.Controls.Clear();
        //Doctors = new Faker<Doctor>()
        //     .RuleFor(u => u.Name, f => f.Person.FirstName)
        //     .RuleFor(u => u.Surname, f => f.Person.LastName)
        //     .RuleFor(u => u.ImageUrl, f => f.Person.Avatar)
        //     .Generate(15);

        //Doctors.ForEach(d => d.Experience = rdm.Next(1, 10));

        var stringData = File.ReadAllText("../../../Resources/DoctorsJson.json");
        Doctors = JsonConvert.DeserializeObject<List<Doctor>>(stringData)!;

        for (int i = 0; i < count; i++)
            DoctorsLayout.Controls.Add(new DoctorUserControl(Doctors[i]));
    }

    private void HospitalRegestration_FormClosed(object sender, FormClosedEventArgs e)
    {
        var jsonString = JsonConvert.SerializeObject(Doctors, Newtonsoft.Json.Formatting.None);
        File.WriteAllText("../../../Resources/DoctorsJson.json", jsonString);
    }

    private void SectionCombo_SelectedIndexChanged(object sender, EventArgs e)
    {
        Random rdm = new Random();
        FakeDataGen(rdm.Next(rdm.Next(1, 15)));
    }
}
