﻿using System;

namespace Приклад_4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Пример 4
            if (a > b)
            {
                max = a; // Эти операторы будут выполняться,
                min = b; // если условие выбора a>b истинно.
            }
            else
            {
                max = b; // Эти операторы будут выполняться,
                min = a; // если условие выбора a>b ложно.
            }
            // Записанные далее операторы будут выполняться
            // в любом случае, независимо от условия выбора.

            //Пример 6
            if (a > b) max = a;
            else max = b;
        }
    }
}
