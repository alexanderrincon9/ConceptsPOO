using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    internal class HourlyEmployee : Employee
    {
        public float Hours { get; set; }

        public decimal HourValue { get; set; }
        public override decimal GetValueTopay()
        {
            return (decimal)Hours * HourValue;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}" +
                   $"\n\tHours...............: {$"{Hours:N2}",20}" +
                   $"\n\tHour value..........: {$"{HourValue:C2}",20}" +
                   $"\n\tValue to pay........: {$"{GetValueTopay():C2}",20}";
        }
    }
}
