
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("==================");

Employee employee = new SalaryEmployee()
{
    Id = 1010,
    FirstName = "Juan",
    LastName =  "Garcia",
    BirthDate = new Date(1990, 5, 23),
    HiringDate = new Date(2022, 1, 15),
    IsActive = true,
    Salary = 1500000.45M 
};
Console.WriteLine(employee);

Employee employee1 = new CommisionEmployee()
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
Console.WriteLine(employee1);