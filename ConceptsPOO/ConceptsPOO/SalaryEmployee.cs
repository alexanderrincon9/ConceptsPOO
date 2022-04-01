namespace ConceptsPOO
{
    internal class SalaryEmployee : Employee
    {
        public decimal Salary { get; set; }
        public override decimal GetValueTopay()
        {
            return Salary;
        }
        public override string ToString()
        {
            return $"{ base.ToString()}" +
                   $"\n\tValue to pay.........: {$"{GetValueTopay():C2}",20}";
        }
    }
}
