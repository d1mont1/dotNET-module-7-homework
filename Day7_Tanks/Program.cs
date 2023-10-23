using System;
using MyClassLib.WordOfTanks;

namespace Day7_Tanks
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Основная задача");

            Tank[] t34Tanks = new Tank[5];
            Tank[] pantherTanks = new Tank[5];

            // Создание танков
            for (int i = 0; i < 5; i++)
            {
                t34Tanks[i] = new Tank("T-34 " + (i + 1), seed: i);
                pantherTanks[i] = new Tank("Panther " + (i + 1), seed: i + 10);
            }

            // Моделирование сражений
            for (int i = 0; i < 5; i++)
            {
                if (t34Tanks[i] ^ pantherTanks[i])
                    Console.WriteLine($"{t34Tanks[i].GetTankParameters()} победил над {pantherTanks[i].GetTankParameters()}");
                else
                    Console.WriteLine($"{pantherTanks[i].GetTankParameters()} победил над {t34Tanks[i].GetTankParameters()}");
            }

            
            Console.WriteLine("Дополнительная задача");

            // Пример использования класса MyClass
            MyClass obj1 = new MyClass { Property1 = 1, Property2 = "A" };
            MyClass obj2 = new MyClass { Property1 = 1, Property2 = "A" };

            if (obj1 == obj2)
                Console.WriteLine("obj1 равен obj2");
            else
                Console.WriteLine("obj1 не равен obj2");

            // Пример использования класса CustomArray
            int[] arr1 = { 1, 2, 3 };
            int[] arr2 = { 4, 5, 6 };
            CustomArray customArr1 = new CustomArray(arr1);
            CustomArray customArr2 = new CustomArray(arr2);

            if (customArr1 < customArr2)
                Console.WriteLine("Сумма элементов массива 1 меньше суммы элементов массива 2");
            else if (customArr1 > customArr2)
                Console.WriteLine("Сумма элементов массива 1 больше суммы элементов массива 2");
            else
                Console.WriteLine("Суммы элементов массивов равны");

            // Пример использования класса Money
            Money money1 = new Money(100, "USD");
            Money money2 = new Money(100, "USD");

            if (money1 == money2)
                Console.WriteLine("money1 равен money2");
            else
                Console.WriteLine("money1 не равен money2");
        }
    }
}
