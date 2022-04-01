
using ConceptsPOO;

Console.WriteLine("POO Concepts");
Console.WriteLine("==================");


try
{
    Console.WriteLine(new Date(2024, 2, 29));

    Console.WriteLine(new Date(2022, 11, 31));

    Console.WriteLine(new Date(2022, 3, 31));

}
catch (Exception error)
{

    Console.WriteLine(error.Message);
}