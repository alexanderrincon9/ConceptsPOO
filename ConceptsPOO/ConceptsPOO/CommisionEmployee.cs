using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConceptsPOO
{
    internal class CommisionEmployee : Employee
    {
        public float Commisionpercentaje { get; set; }

        public decimal Sales { get; set; }

        public override decimal GetValueTopay()
        {
            return Sales * (decimal)Commisionpercentaje;
        }

        public override string ToString()
        {
            return $"{ base.ToString()}" +
                   $"\n\tCommision percentaje: {$"{Commisionpercentaje:P2}",20}" +
                   $"\n\tSales...............: {$"{Sales:C2}",20}" +
                   $"\n\tValue to pay........: {$"{GetValueTopay():C2}",20}";
        }
    }
}
