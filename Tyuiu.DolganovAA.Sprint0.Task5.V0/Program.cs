using Tyuiu.DolganovAA.Sprint0.Task5.V0.Lib;
namespace Tyuiu.DolganovAA.Sprint0.Task5.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A + B =" + DataService.Addition(1, 5));
            Console.WriteLine("A - B =" + DataService.Subtraction(98, 5));
            Console.WriteLine("A * B =" + DataService.Multiplication(13, 5));
            Console.WriteLine("A / B =" + DataService.Division(10, 5));
            Console.ReadKey();
        }
    }
}
