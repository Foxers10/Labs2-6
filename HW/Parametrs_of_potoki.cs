using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFHomeWork
{
	public class Parametrs_of_potoki//класс, в котором описаны свойства, которые будут применяться для разделения на потоки
	{
		public List<string> tempList { get; set; }//временный список дляя поиска
		public string Finded_word { get; set; }//слово для поиска
		public int maxDistanceSearch { get; set; }//максимальное расстояние для поиска
		public int Potok_Number { get; set; }//номер потока
	}
}
