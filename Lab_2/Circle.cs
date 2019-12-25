using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab2
{
	public class Circle : Figure, IPrint//наследуется от Figure и реализует интерфес IPtint
	{
		double radius;
		public Circle(double rad)//конструктор
		{
			this.radius = rad;
			this.Type = "Окружность";
		}
		public override double Area()//переопределяем метод вычисления площади
		{
			double S = Math.Round(Math.Pow(this.radius, 2) * Math.PI, 4);//переопределение функции нахождения площади круга
			return S;
		}
		public void Print()//вывод
		{
			Console.WriteLine(this.ToString());
		}
	}
}
