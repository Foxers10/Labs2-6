using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	delegate double Mydelegate(int p1, string p2, double p3);
	class Program
	{
		static double Multipli(int p1, string p2, double p3)//перемножение двух чисел типа делегата
		{
			return p1 * Convert.ToDouble(p2) * p3;
		}
	
		static void Method_Func_Mydelegate(string str, int i1, string i2, double i3, Func<int, string, double, double> Mydelegate_Param)/*обобщенный делегат Func, 
		принимающий параметры типа int, int и возвращающий  int*/
        {
            double Result = Mydelegate_Param(i1, i2, i3);
			Console.WriteLine(str + Result.ToString());//вывод на новой строке объвления действия делегатом и результата этого действия
		}

        static void Method_Mydelegate(string str, int i1, string i2, double i3, Mydelegate Mydelegate_Param)//исользование делегата на основе указания вложенного метода
        {
            double Result = Mydelegate_Param(i1, i2, i3);
			Console.WriteLine(str + Result.ToString());//вывод на новой строке объвления действия м делегаом и результата этого действия
		}

        static void Main(string[] args)
        {
			Console.Title = "Лисин Андрей РТ5-31Б";
			//объявление и ввод входных параметров делегата
			Console.ForegroundColor = ConsoleColor.Magenta;
			Console.WriteLine("Внимание, в зависимости от системы, ввод чисел может быть либо с использованием запятой либо точки");
			Console.ResetColor();
			Console.Write("Введите целое число: ");
			string str1 = Console.ReadLine();
			Console.Write("Введите любое число: ");
			string i2 = Console.ReadLine();
			Console.Write("Введите число с плавающей запятой: ");
			string str3 = Console.ReadLine();
			int i1 = Convert.ToInt32(str1);
			double i3 = Convert.ToDouble(str3);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nДля чисел {0}; {1} и {2}:\n", i1, i2, i3);
			Console.ResetColor();

			Method_Mydelegate("Метод перемножения: ", i1, i2, i3, Multipli);//вызов метода делегата
			Mydelegate P1 = new Mydelegate(Multipli);//создание экземпляра делегата
			Method_Mydelegate("Экземпляр на основе метода: ", i1, i2,i3, P1);//работа метода на основе объявленного метода делегата
			Method_Mydelegate("Экземпляр на основе лямбда-выражения: ", i1, i2, i3, (x, y, z) => x*Convert.ToDouble(y)*z );//работа метода на основе лямбда-выражения

            Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nИспользование обощенного делегата Func<>");
			Console.ResetColor();

			Method_Func_Mydelegate("Экземпляр на основе метода: ", i1, i2,i3, Multipli);
			Method_Func_Mydelegate("Экземпляр на основе лямбда-выражения: ", i1, i2,i3, (x, y, z) => x * Convert.ToDouble(y) * z);
			Console.ReadLine();
        }
    }
}
