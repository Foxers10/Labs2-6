using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using DistanceLib;

namespace WFHomeWork
{
	public partial class FormHW : Form
	{
		public FormHW()
		{
			InitializeComponent();
			this.Text = "Мирсонов РТ5-31Б --- Домашнее задание";
		}

		List<string> list = new List<string>();//список
		public static List<ParallelSearchResult> ArrayThreadTask(object paramObj)//поиск строк в параллельном потоке
		{
			Parametrs_of_potoki param = (Parametrs_of_potoki)paramObj;
			string wordUpper = param.Finded_word.Trim().ToUpper();//перевод в верхний регистр
			List<ParallelSearchResult> Once_Result = new List<ParallelSearchResult>();//результат поиска в одном потоке
			foreach (string str in param.tempList)//перебор всех слов в списке текущего потока
			{
				int dist = Damerau_Livenshtein_distance.Distance(str.ToUpper(), wordUpper);//расстояние мужду ними по описанной в классе из библиотеки классов DistanceLib
				if (dist <= param.maxDistanceSearch)//если расстояние меньше или равно введенному пороговому
				{
					ParallelSearchResult temp = new ParallelSearchResult()//передача данных найденного слова
					{
						Finded_word = str,
						Distance = dist,
						POTOK_Number = param.Potok_Number
					};
					Once_Result.Add(temp);//добавление слова во временный список найденных слов
				}
			}
			return Once_Result;
		}

		private void buttonReadFile_Click(object sender, EventArgs e)
		{
			OpenFileDialog fd = new OpenFileDialog();
			fd.Filter = "текстовые файлы|*.txt";//свойство Filter содержит список расширений файлов
			if (fd.ShowDialog() == DialogResult.OK)//ShowDialog производит открытие диалогового окна
			{
				Stopwatch DownloadTimer = new Stopwatch();//объявляется и запускается таймер загрузки файла
				Stopwatch SaveTimer = new Stopwatch();
				DownloadTimer.Start();
				SaveTimer.Start();
				string text = File.ReadAllText(fd.FileName, Encoding.Default );//содержимое файла считывается в виде переменной text типа string. Свойство fd.FileName возвращает путь и имя файла
				DownloadTimer.Stop();
				char[] razdelSimbols = new char[] { ' ', '.', ',', '!', '?', '/', '\t', '\n' };//массив символов для разделения слов при чтении файла
				string[] textArray = text.Split(razdelSimbols);//массив слов файла, произведенный методом разделения Split на основе разделительных символов
				foreach (string strTemp in textArray)
				{
					string str = strTemp.Trim();//для корректной работы удаляем пробелы в начале и конце файла
					if (list.Contains(str) != true)//если строка не содержится в списке
						list.Add(str);//добавление строки в список
				}
				SaveTimer.Stop();
				this.textBoxDownloadTime.Text = DownloadTimer.Elapsed.ToString();//время загрузки
				this.textBoxSaveTime.Text = SaveTimer.Elapsed.ToString();//время сохранения
			}
			else//если пользователь не выбрал текстовый файл
			{
				MessageBox.Show("Необходимо выбрать файл");
			}
		}

		private void buttonChSearch_Click(object sender, EventArgs e)
		{
			string Find_word = this.textBoxSearchingWord.Text.Trim();//слово для поиска - набор символов, введенных в окно для ввода слова для поиска textBox_find_word
			if (!string.IsNullOrWhiteSpace(Find_word) && list.Count > 0)//если данное поле не пусто и прочитаны данные из файла
			{
				string wordUpp = Find_word.ToUpper();//введеное для поиска слово Find_word переводится в верхний регистр для более легкого поиска
				List<string> tempList = new List<string>();//временный список найденных слов
				Stopwatch SearchTime = new Stopwatch();//объявляем время поиска слова
				SearchTime.Start();
				foreach (string str in list)//перебор всех слов в списке list
				{
					if (str.ToUpper().Contains(wordUpp))//если текущее рассматриваемое слово содержит введеное для поиска слово Find_word как подстроку
					{
						tempList.Add(str);//добавление слова во временный список найденных слов
					}
				}
				SearchTime.Stop();
				this.textBoxChSearchTime.Text = SearchTime.Elapsed.ToString();//вывод времени поиска в определенный для этого textBox_searching_time

				this.listBoxReport.BeginUpdate();//начало обновления данных списка
				this.listBoxReport.Items.Clear();//очитска результатов предыдущего поиска
				foreach (string str in tempList)//перечисление слов из временного списка найденных слов
				{
					this.listBoxReport.Items.Add(str);//добавление подходящего слова в список listBox_finded_word
				}
				this.listBoxReport.EndUpdate();//завершение обновления данных
			}
			else//если слово не введено или данные из файла не считаны
			{
				MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
			}
		}

		private void buttonMnogopotochnSearch_Click(object sender, EventArgs e)
		{
			string word_nechet = this.textBoxSearchingWord.Text.Trim();//слово для нечеткого поиска
			if (!string.IsNullOrWhiteSpace(word_nechet) && list.Count > 0)//если строка для ввода слова не пуста
			{
				int maxDist;//максимальное расстояние для нечеткого поиска
				if (!int.TryParse(this.textBoxNechetDistance.Text.Trim(), out maxDist))//если не указано максимальное расстояние
				{
					MessageBox.Show("Необходимо указать максимальное расстояние");
					return;
				}
				if (maxDist < 1 || maxDist > 5)//указание диапазона для максимального расстояния
				{
					MessageBox.Show("Максимальное расстояние должно быть в диапазоне от 1 до 5");
					return;
				}
				int PotokiCount;
				if (!int.TryParse(this.textBoxNumberOfPotoki.Text.Trim(), out PotokiCount))
				{
					MessageBox.Show("Необходимо указать количество потоков");
					return;
				}


				Stopwatch timerOfParallelSearch = new Stopwatch();
				timerOfParallelSearch.Start();
				List<ParallelSearchResult> Result = new List<ParallelSearchResult>();//результирующий список
				List<MinMax> ListDivided = Treading_Algorithm.Treading(0, list.Count, PotokiCount);//деление последовательности из уникальных слов на промежутки согласно количеству указанных потоков
				int count = ListDivided.Count;//количество потоков = количество фрагментов или "отрезков"
				Task<List<ParallelSearchResult>>[] delenie = new Task<List<ParallelSearchResult>>[count];//деление на потоки
				for (int i = 0; i < count; i++)//запуск поиска в потоках
				{
					List<string> TempL = list.GetRange(ListDivided[i].Min, ListDivided[i].Max - ListDivided[i].Min);//временный список для разделения работы потоков в коллекции
					delenie[i] = new Task<List<ParallelSearchResult>>(ArrayThreadTask, new Parametrs_of_potoki()
					{
						tempList = TempL,
						maxDistanceSearch = maxDist,
						Potok_Number = i,
						Finded_word = word_nechet
					});
					delenie[i].Start();
				}
				Task.WaitAll(delenie);

				for (int i = 0; i < count; i++)//объединение результатов со всех потоков
				{
					Result.AddRange(delenie[i].Result);
				}

				timerOfParallelSearch.Stop();
				this.textBoxMnogopotochSearchTime.Text = timerOfParallelSearch.Elapsed.ToString();//вывод времени нечеткого поиска


				this.textBoxRealNumberPotoki.Text = count.ToString();
				this.listBoxReport.BeginUpdate();
				this.listBoxReport.Items.Clear();//очитска списка в окне
				foreach (var x in Result)//вывод результатов
				{
					string temp = x.Finded_word + "( расстояние = " + x.Distance.ToString() + " поток = " + x.POTOK_Number.ToString() + " )";
					this.listBoxReport.Items.Add(temp);
				}
				this.listBoxReport.EndUpdate();
			}
			else
			{
				MessageBox.Show("Необходимо выбрать файл и ввести слово для поиска");
			}
		}

		private void buttonCLOSE_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void buttonSAVEreport_Click(object sender, EventArgs e)
		{
			string TempReportFileName = "Отчет многопоточный поиск " + DateTime.Now.ToString("dd_MM_yyyy_hhmmss");

			//Диалог сохранения файла отчета
			SaveFileDialog fd = new SaveFileDialog();
			fd.FileName = TempReportFileName;
			fd.DefaultExt = ".html";
			fd.Filter = "HTML Reports|*.html";

			if (fd.ShowDialog() == DialogResult.OK)
			{
				string ReportFileName = fd.FileName;
				StringBuilder b = new StringBuilder();//формирование html отчета
				b.AppendLine("<html>");

				b.AppendLine("<head>");
				b.AppendLine("<meta http-equiv='Content-Type' content='text/html; charset=UTF-8'/>");
				b.AppendLine("<title>" + "Отчет: " + ReportFileName + "</title>");
				b.AppendLine("</head>");

				b.AppendLine("<body>");

				b.AppendLine("<h1>" + "Отчет: " + ReportFileName + "</h1>");
				b.AppendLine("<table border='1'>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Время загрузки файла</td>");
				b.AppendLine("<td>" + this.textBoxDownloadTime.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Время сохранения файла</td>");
				b.AppendLine("<td>" + this.textBoxSaveTime.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Слово для поиска</td>");
				b.AppendLine("<td>" + this.textBoxSearchingWord.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Время четкого поиска слова</td>");
				b.AppendLine("<td>" + this.textBoxChSearchTime.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Максимальное расстояние для нечеткого поиска</td>");
				b.AppendLine("<td>" + this.textBoxNechetDistance.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Время многопоточного нечеткого поиска</td>");
				b.AppendLine("<td>" + this.textBoxMnogopotochSearchTime.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr>");
				b.AppendLine("<td>Вычисленное количество потоков нечеткого поиска</td>");
				b.AppendLine("<td>" + this.textBoxRealNumberPotoki.Text + "</td>");
				b.AppendLine("</tr>");

				b.AppendLine("<tr valign='top'>");
				b.AppendLine("<td>Результаты поиска</td>");
				b.AppendLine("<td>");
				b.AppendLine("<ul>");

				foreach (var x in this.listBoxReport.Items)
				{
					b.AppendLine("<li>" + x.ToString() + "</li>");
				}

				b.AppendLine("</ul>");
				b.AppendLine("</td>");
				b.AppendLine("</tr>");


				b.AppendLine("</table>");

				b.AppendLine("</body>");
				b.AppendLine("</html>");

				//Сохранение файла
				File.AppendAllText(ReportFileName, b.ToString());
				MessageBox.Show("Отчет успешно сформирован! Сохранен в файле: " + ReportFileName);
			}
		}
	}
}
