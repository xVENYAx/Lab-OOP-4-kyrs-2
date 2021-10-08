using System;

namespace Завдання_2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.OutputEncoding = System.Text.Encoding.Unicode; // для того, щоб консоль розпізнавав українські літери
			Console.WriteLine("Виконав роботу студент 2 курсу групи МН-205 ФАЕТ.");
			Console.WriteLine("Нагайченко Олександр Олегович");
			Console.WriteLine("Варіант-7");
			Console.WriteLine();

			Console.WriteLine("Завдання 2:");
			Console.WriteLine("Визначити для свого варіанту номер N області, в якій знаходиться точка М (х, у) з заданими координатами. Межі області відносити до області з Найбільший номером.");
			int N;
		m2: Console.WriteLine("  Введіть для точки M" + " координату по X ");
			float x = float.Parse((Console.ReadLine()));
			Console.WriteLine("  Введіть для точки M" + " координату по Y ");
			float y = float.Parse((Console.ReadLine()));

			if (y > 0)
			{
				if (x > 0)
				{
					if (x > 12 && y > 12) N = 4;
					else N = 1;
				}
				else
				{
					if (x > -12 && y > 12) N = 3;
					else N = 2;
				}
			}
			else
			{
				if (x > 0)
				{
					if (x > 12 && y > -12) N = 4;
					else N = 2;
				}
				else
				{
					if (y > -12 && x > -12) N = 3;
					else N = 1;
				}
			}
			Console.WriteLine('\t' + "     РЕЗУЛЬТАТ:");
			Console.WriteLine("   Точка M(" + x + ";" + y + ")" + " лежить в області с N=" + N);
			Console.WriteLine('\n' + "Для повторного ввода" + "наберіть любую клавишу.." + '\n' + "Для завершення програми натисніть Enter.");
			string p = Console.ReadLine();
			if (p != "") goto m2;
		}
    }
}
