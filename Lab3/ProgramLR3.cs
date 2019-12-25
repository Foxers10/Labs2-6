using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lab2;

namespace Lab3
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Title = "Лисин Андрей РТ5-31Б";
			Rectangle rect = new Rectangle(6, 2);//объект класса Прямоугольник
			Square square = new Square(15);//объект класса Квадрат
			Circle circle = new Circle(13);//объект класса Окружность

			/*Необощенный список*/
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nКоллекция класса ArrayList");
			Console.ResetColor();
			ArrayList AL = new ArrayList();//создане необобщенного списка

			/*добавление в необобщенный список рассматриваемых элементов*/
			AL.Add(circle);
			AL.Add(square);
			AL.Add(rect);

			/*вывод элементов необобщенного списка*/
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Необобщенный список:");
			Console.ResetColor();
			foreach (object o in AL)
				Console.WriteLine(o.ToString());

			/*Коллекция класса Figure*/
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nКоллекция класса List<Figure>");
			Console.ResetColor();
			List<Figure> LF = new List<Figure>();// создание списка (коллекции класса Figure)

			/*добавление в список рассматриваемых элементов*/
			LF.Add(square);
			LF.Add(rect);
			LF.Add(circle);

			/*вывод элементов списка до сортировки*/
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Список до сортировки:");
			Console.ResetColor();
			foreach (var x in LF)
				Console.WriteLine(x);
			LF.Sort();//сортировка

			/*вывод после сортировки*/
			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("\nСписок после сортировки:");
			Console.ResetColor();
			foreach (var x in LF)
				Console.WriteLine(x);

			/*Односвязный список ListFigures*/
			SimpleList<Figure> OneCommunicationListFigures = new SimpleList<Figure>();//создание односвязного списка

			/*добавление элементов в односвязный список*/
			OneCommunicationListFigures.Add(square);
			OneCommunicationListFigures.Add(circle);
			OneCommunicationListFigures.Add(rect);
			OneCommunicationListFigures.Sort();//сортировка

			/*Трехмерная разреженная матрица*/
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nТрехмерная разреженная матрица");
			Console.ResetColor();
			Matrix3D<Figure> cube = new Matrix3D<Figure>(3, 3, 3, null);//создание трехмерной разреженной матрицы 3х3х3 с передачей в качестве нулевого элемента - null

			/*доабвление отсортированных элементов списка OneCommunicationListFigures в словарь, создающий основу матрицы, на места на "главной диагонали"*/
			cube[0, 0, 0] = OneCommunicationListFigures.Get(0);
			cube[1, 1, 1] = OneCommunicationListFigures.Get(1);
			cube[2, 2, 2] = OneCommunicationListFigures.Get(2);
			Console.WriteLine(cube.ToString());
			Console.ResetColor();

			/*Реализация стека*/
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nСтек");
			Console.ResetColor();
			SimpleStack<Figure> SimpleFigureStack = new SimpleStack<Figure>();//создание стека

			/*добавление отсортированных элементов списка OneCommunicationListFigures в стек по прицнипу LIFO*/
			SimpleFigureStack.Push(OneCommunicationListFigures.Get(0));
			SimpleFigureStack.Push(OneCommunicationListFigures.Get(1));
			SimpleFigureStack.Push(OneCommunicationListFigures.Get(2));

			Console.ForegroundColor = ConsoleColor.Blue;
			Console.WriteLine("Реализация метода Pop() для стека SimpleFigureStack");
			Console.ResetColor();
			while (SimpleFigureStack.Count > 0)//чтение из данных (элемента) с удалением из стека
			{
				Figure figur = SimpleFigureStack.Pop();
				Console.WriteLine(figur);
			}

			Console.ReadLine();
		}
	}
}