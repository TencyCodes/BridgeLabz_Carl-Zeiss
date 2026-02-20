using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Review_5
{
    public class ContractEmployee : Employee
    {
        public double ContractAmount { get; set; }

        public override double CalculateSalary()
        {
            return ContractAmount;
        }
    }
}
