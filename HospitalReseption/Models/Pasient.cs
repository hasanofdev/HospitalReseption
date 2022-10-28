using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalReseption.Models;

public class Pasient
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public TimeOnly ReservTime { get; set; }
    public string Section { get; set; }

    public Pasient(string name,string surname,string phone,string email)
    {
        Name = name;
        Surname = surname;
        Phone = phone;
        Email = email;
    }
}
