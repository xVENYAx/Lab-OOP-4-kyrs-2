using System;

namespace Лаб_ООП__4_2_курс
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

            Console.WriteLine("Завдання 1:");
            Console.WriteLine("Обчислити для свого варіанту значення функції F. При отриманні в знаменнику нуля дати відповідне повідомлення.");
            Console.WriteLine();
            Console.WriteLine("F=(max(x^2, y^2, x-y)+x)/(((min(x, y))^z-y)");
            Console.WriteLine();
            
            double f;
            double f1;
        m1: Console.WriteLine(" Введіть значення X");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введіть значення Y");
            float y = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введіть значення Z");
            float z = float.Parse((Console.ReadLine()));
            if (Math.Pow(x, 2) > Math.Pow(y, 2))
            {
                if (Math.Pow(x, 2) > x - y) f = Math.Pow(x, 2);
                else f = x - y;
            }
            else
            { if (Math.Pow(y, 2) > x - y) f = Math.Pow(y, 2); else f = x - y; }
            double ff = f + x;
            
            if (x > y) f1 = y;
            else f1 = x;
            double f11 = Math.Pow(f1, z) + Math.Pow(y, 4);

            if (f11 != 0)
            {
                f = ff / f11;
                Console.WriteLine('\n' + " Дано: x = " + x + " y = " + y + " z = " + z + '\n' + " Результат: F = " + f);
                Console.WriteLine('\n' + "Для повторного ввода" + "наберіть любую клавишу.." + '\n' + "Для завершення програми натисніть Enter.");
                string p = Console.ReadLine();
                if (p != "") goto m1;
            }
            else
            { 
                Console.WriteLine("ERROR!!!");
                Console.WriteLine('\n' + "Для повторного ввода" + "наберіть любую клавишу.." + '\n' + "Для завершення програми натисніть Enter.");
                string p = Console.ReadLine();
                if (p != "") goto m1;
            }
        }
    }
}
