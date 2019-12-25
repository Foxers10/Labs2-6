using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;

namespace Reflection
{
	class Program
	{
		public static bool GetPropertyA(PropertyInfo checkAType, Type AType, out object A)//функция проверки наличия заданного атрибута
        {
			bool Result = false;
			A = null;
			var isAttribute = checkAType.GetCustomAttributes(AType, false);//поиск атрибутов заданного типа 
			if (isAttribute.Length > 0)
			{
				Result = true;
				A = isAttribute[0];
			}
			return Result;//возвращение атрибута
		}


		static void Main(string[] args)
		{
			Console.Title = "Лисин Андрей РТ5-31Б";
			//объявление и ввод параметров
			int x1;
			int x2;
			Console.WriteLine("Введите первое число:");
			string str1 = Console.ReadLine();
			Console.WriteLine("Введите второе число:");
			string str2 = Console.ReadLine();
			x1 = Convert.ToInt32(str1);
			x2 = Convert.ToInt32(str2);

			Type t = typeof(SearchingClass);

			Console.WriteLine("Тип " + t.FullName + " унаследован от " + t.BaseType.FullName);//вывод информации о наследовании описанного SearchingClass класса
			Console.WriteLine("Пространство имен " + t.Namespace);
			Console.WriteLine("Находится в сборке " + t.AssemblyQualifiedName);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nКонструкторы:");
			Console.ResetColor();
			foreach (var x in t.GetConstructors())//вывод конструкторов
				Console.WriteLine(x);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nМетоды:");
			Console.ResetColor();
			foreach (var x in t.GetMethods())//вывод методов
				Console.WriteLine(x);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nСвойства:");
			Console.ResetColor();
			foreach (var x in t.GetProperties())
				Console.WriteLine(x);

			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nСвойства, для которых назначен атрибут:");
			Console.ResetColor();
			foreach (var x in t.GetProperties())
			{
				object attrObj;
				if (GetPropertyA(x, typeof(NewAttribute), out attrObj))//если для свойства объявлен атрибут
				{
					NewAttribute attr = attrObj as NewAttribute;
					Console.WriteLine(x.Name + " - " + attr.Description);//вывод имени свойства и назначенного ему артибута
				}
			}
			Console.ForegroundColor = ConsoleColor.Yellow;
			Console.WriteLine("\nВызов метода возведение в степень (Exponentiation):");
			Console.ResetColor();
			SearchingClass fi = (SearchingClass)t.InvokeMember(null, BindingFlags.CreateInstance, null, null, new object[] { });//создание объекта черех рефлексию
			object[] parameters = new object[] { x1, x2 };//параметры метода
			object Result1 = t.InvokeMember("Exponentiation", BindingFlags.InvokeMethod, null, fi, parameters);//вызов метода возведения первого числа в степень, равную второму, с заданными параметрами
			Console.WriteLine("Exponentiation({0},{1}) = {2}", x1, x2, Result1);
			Console.ReadLine();
		}
	}
}