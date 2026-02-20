using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class PartTimeEmployee : Employee
    { 
            public double HourlyRate { get; set; }
            public int HoursWorked { get; set; }

            public override double CalculateSalary()
            {
                return HourlyRate * HoursWorked;
            }
    }
}
