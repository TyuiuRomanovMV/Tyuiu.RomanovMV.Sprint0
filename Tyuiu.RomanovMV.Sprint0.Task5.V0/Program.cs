using Tyuiu.RomanovMV.Sprint0.Task5.V0.Lib;
namespace Tyuiu.RomanovMV.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B = " + DataService.Addition(1, 5));
            Console.WriteLine("A - B = " + DataService.Sub(15, 5));
            Console.WriteLine("A * B = " + DataService.Mul(2, 5));

            Console.WriteLine("A / B = " + DataService.Div(9, 3));

            Console.ReadKey(); 
        }
    }
}
