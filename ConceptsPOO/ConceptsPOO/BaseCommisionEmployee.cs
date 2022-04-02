using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    public class BaseCommisionEmployee :CommisionEmployee
    {
        public decimal Base { get; set; }

        public override decimal GetValueTopay()
        {
            return base.GetValueTopay() + Base;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}" +
                  $"\n\tBase...............: {$"{Base:C2}",20}";
               
        }
    }
}
