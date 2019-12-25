using System.Collections.Generic;

namespace WFHomeWork
{
	public struct MinMax//хранение минимального и максимального значений
	{
		public int Min;
		public int Max;
		public MinMax(int min, int max)
		{
			this.Min = min;
			this.Max = max;
		}
	}
	public static class Treading_Algorithm/*алгоритм деления слов 
		в файле на подпоследовательности (отрезки), длина которых
		определятся заданным количеством потоков*/
	{
		public static List<MinMax> Treading(int begin, int end, int potoki)
		{
			List<MinMax> Tread_result = new List<MinMax>();
			if ((end - begin) <= potoki)//если количество слов в файле меньше количетсва указанных потоков
			{
				Tread_result.Add(new MinMax(0, (end - begin)));
			}
			else
			{
				int section = (end - begin) / potoki;//отрезок
				int tempBegin = begin;
				while ((end - tempBegin) >= 2 * section)//условие для добавление отрезков заданной длины, длина = количеству потоков
				{
					Tread_result.Add(new MinMax(tempBegin, tempBegin + section));//добавление "отрезка" длиной в количество указанных потоков
					tempBegin = tempBegin + section;//переход к началу следующего "отрезка"
				}
				Tread_result.Add(new MinMax(tempBegin, end));//добавление последнего "отрезка"
			}
			return Tread_result;
		}
	}
}
