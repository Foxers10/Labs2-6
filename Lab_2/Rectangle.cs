using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Rectangle : Figure, IPrint //наследуется от абстрактного класса Figure и реализует интерфес IPtint
	{
		double high;//высота
		double wdth;//ширина
		public Rectangle(double hg, double wd)//конструктор
		{
			this.high = hg;
			this.wdth = wd;
			this.Type = "Прямоугольник";
		}
		public override double Area()//переопределенный метод вычисления площади
		{
			double S = Math.Round(this.wdth * this.high, 4);//переопределение функции нахождения площади круга
			return S;
		}
		public void Print()//метод печати данных
		{
			Console.WriteLine(this.ToString());
		}
	}
}
