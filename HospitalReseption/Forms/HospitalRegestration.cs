using HospitalReseption.Models;
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
    public string PhonePattern = @"^(050|051|055|070|077|099).*$";
    public string AllCharPattern = @"^[a-zA-Z]+(([',. -][a-zA-Z ])?[a-zA-Z]*)*$";
    public string MailPattern = @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$";
    public HospitalRegestration()
    {
        InitializeComponent();
        WindowSize = new Size(Size.Width, Size.Height);
        MainPanel.Visible = false;
        MainPanel.SendToBack();
        RegisterPanel.BringToFront();
    }

    private void HospitalRegestration_SizeChanged(object sender, EventArgs e)
    {
        if (Size.Width == 160 && Size.Height == 28)
            return;

        if (RegisterPanel.Location.X <= 0)
            RegisterPanel.Visible = false;
        else if (RegisterPanel.Location.X > 0)
            RegisterPanel.Visible = true;

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

    private void PasientTxt_TextChanged(object sender, EventArgs e)
    {

        var tb = sender as TextBox;
        if (!Regex.IsMatch(tb!.Text, AllCharPattern) || tb.Text.Length < 3)
        {
            tb.ForeColor = Color.Red;
        }
        else tb.ForeColor = Color.Black;
    }

    private void EnterBtn_Click(object sender, EventArgs e)
    {
        bool FullnameIsCorrect = Regex.IsMatch(NameTxt.Text, AllCharPattern) && Regex.IsMatch(SurnameTxt.Text, AllCharPattern);
        string Phone = PhoneTxt.Text.Split('-')[0] + PhoneTxt.Text.Split('-')[1] + PhoneTxt.Text.Split('-')[2];
        if ((Regex.IsMatch(EmailTxt.Text, MailPattern) && Regex.IsMatch(Phone, PhonePattern) && Phone.Length == 10) && FullnameIsCorrect)
        {
            Pasient pasient = new Pasient(NameTxt.Text, SurnameTxt.Text, PhoneTxt.Text, EmailTxt.Text);
            RegisterPanel.Visible = false;
        }
    }
}
