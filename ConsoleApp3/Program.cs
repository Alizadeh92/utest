using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        { Calcul cal = new Calcul();
            Console.WriteLine("выберите действие\n 1 сумма \n 2 вычитание \n 3 умножение \n 4 деление \n 5 корень");
            switch (Console.ReadLine())
            {
                case "1":
                    try
                    {
                        Console.WriteLine("введите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(cal.Summa(a, b));
                    }
                    catch( Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    break;
                case "2":
                    try
                    {
                        Console.WriteLine("введите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(cal.Minus(a, b));
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    break;
                case "3":
                    try
                    {
                        Console.WriteLine("введите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(cal.Umnoj(a, b));
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    break;
                case "4":
                    try
                    {
                        Console.WriteLine("введите первое число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine("введите второе число");
                        double b = double.Parse(Console.ReadLine());
                        Console.WriteLine(cal.Delen(a, b));
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    break;
                case "5":
                    try
                    {
                        Console.WriteLine("введите  число");
                        double a = double.Parse(Console.ReadLine());
                        Console.WriteLine(cal.Koren(a));
                    }
                    catch (Exception error)
                    {
                        Console.WriteLine(error.Message);
                    }
                    break;





            }
            Console.ReadKey();
        }
        
    }
}
