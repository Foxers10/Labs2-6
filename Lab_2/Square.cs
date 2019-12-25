using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
	public class Square : Rectangle, IPrint//наследуется от класса Rectangle и реализует интерфес IPtint
	{
		public Square(double side_size) : base(side_size, side_size)
		{
			this.Type = "Квадрат";
		}//конструктор, вызывающий конструтор класса Прямоугольник, адаптированный для квадрата
	}
}
