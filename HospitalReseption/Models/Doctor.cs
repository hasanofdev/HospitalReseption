using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalReseption.Models;

public class Doctor
{
    public string? Name { get; set; }
    public string? Surname { get; set; }
    public int Experience { get; set; }
    public string? ImageUrl { get; set; }

    
    public List<string>? ReservTimes;
}
