
using ConceptsPOO;

Console.WriteLine("POO Concepts Nomina");
Console.WriteLine("==================");

Employee employee1 = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Juan",
    LastName =  "Garcia",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1500000.45M 
};
//Console.WriteLine(employee);

Employee employee2= new CommisionEmployee()
{
    Id = 2000,
    FirstName = "Camilo",
    LastName = "Zuñiga",
    BirthDate = new Date(1998, 5, 9),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Sales = 500000000M,
    Commisionpercentaje = 0.03F   
};
//Console.WriteLine(employee1);


Employee employee3 = new HourlyEmployee()
{
    Id = 3030,
    FirstName = "Paula",
    LastName = "Rincon",
    BirthDate = new Date(1985, 11, 19),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    HourValue = 10000.30M,
    Hours = 48
    
};
//Console.WriteLine(employee2);


Employee employee4 = new BaseCommisionEmployee()
{
    Id = 4040,
    FirstName = "Natalia",
    LastName = "Araque",
    BirthDate = new Date(1998, 01, 01),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Base = 1000000M,
    Sales = 58000000M,
    Commisionpercentaje = 0.01F

};
//Console.WriteLine(employee3);

ICollection<Employee> employees = new List<Employee>()
{
    employee1,employee2,employee3,employee4
};

decimal payroll = 0;

foreach (Employee employee in employees)
{
    Console.WriteLine(employee);
    payroll += employee.GetValueTopay();
}

Console.WriteLine("                               ========================");
Console.WriteLine($"TOTAL                         {$"{payroll:C2}",20}");

Invoice invoice1 = new Invoice()
{
    Description = "iPhone 13",
    Id = 1,
    Price = 5300000M,
    Quantity = 6
};

Invoice invoice2 = new Invoice()
{
    Description = "Posta Preum",
    Id = 2,
    Price = 50000M,
    Quantity = 17.5F
};

Console.WriteLine(invoice1);
Console.WriteLine(invoice2);
