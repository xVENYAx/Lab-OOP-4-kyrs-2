using System;

namespace Приклад_14
{
    class Program
    {
        static void Main(string[] args)
        {
            float f;
        m1: Console.WriteLine(" Введите значение X");
            float x = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введите значение Y");
            float y = float.Parse((Console.ReadLine()));
            Console.WriteLine(" Введите значение Z");
            float z = float.Parse((Console.ReadLine()));
            if (x > y)
            {
                if (x > z) f = x;
                else f = z;
            }
            else
            { if (y > z) f = y; else f = z; }
            Console.WriteLine('\n' + " Дано: x = " + x +  " y = " +  y + " z = " + z + '\n'+ " Результат: F = " + f);
            Console.WriteLine('\n' + "Для повторного ввода" + "набрать любую клавишу." + '\n' + "Для завершения программы нажмите Enter.");
            string p = Console.ReadLine();
            if (p != "") goto m1;
        }
    }
}
