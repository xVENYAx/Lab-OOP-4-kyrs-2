using System;

namespace Приклад_13
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
        m1: Console.WriteLine("Введите целое число");
            int a = int.Parse((Console.ReadLine()));
            switch (a)
            {
                case 1:
                    n = 10;
                    break;
                case 2:
                case 3:
                    n = 20;
                    break;
                default:
                    n = 0;
                    break;
            }
            Console.WriteLine("a = " + a + "  n = " + n);
            if (a != 0) goto m1;
            Console.Read();
        }
    }
}
