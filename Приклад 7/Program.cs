using System;

namespace Приклад_7
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 7
            ...
            if (x < -1)
            { n = 1; }
            else
            {
                // Начало вложенной конструкции if
                if (x > 1)
                { n = 2; }
                else
                { n = 0; }
                // Конец вложенной конструкции if
            }
            ...

            //Пример 8
            ...
            if (x < -1)
            { n = 1; }
            else
            {
                if (x > 1) { n = 2; }
                else { n = 0; }
            }
            ...

            // Пример 9
            ...
            if (x < -1) n = 1;
            else
            if (x > 1) n = 2;
            else n = 0;
            ...
        }
    }
}
