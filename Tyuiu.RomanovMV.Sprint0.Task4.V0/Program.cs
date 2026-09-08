using Tyuiu.RomanovMV.Sprint0.Task4.V0.Lib;
namespace Tyuiu.RomanovMV.Sprint0.Task4.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.Addition(1, 5));
            Console.WriteLine(DataService.Sub(5, 5));
            Console.WriteLine(DataService.Mul(2, 5));
            Console.WriteLine(DataService.Div(50, 5));

            Console.ReadLine();
        }
    }
}
