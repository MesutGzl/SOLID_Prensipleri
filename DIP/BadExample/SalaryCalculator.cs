using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIP.BadExample
{
    public class SalaryCalculator
    {
        public int CalculateSlary(int hoursWorked, int hourlyRate) => hoursWorked * hourlyRate;
    }
}
