using System;

namespace MyClassLib.WordOfTanks
{
    public class Tank
    {
        // Поля
        private string tankName;
        private int ammunitionLevel;
        private int armorLevel;
        private int maneuverabilityLevel;

        // Конструктор
        public Tank(string name, int seed)
        {
            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Имя танка не может быть пустым.");

            tankName = name;
            Random random = new Random(seed);

            try
            {
                ammunitionLevel = random.Next(0, 101);
                armorLevel = random.Next(0, 101);
                maneuverabilityLevel = random.Next(0, 101);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при генерации случайных чисел: " + ex.Message);
            }
        }

        // Методы для получения значений параметров танка в виде строки
        public string GetTankParameters()
        {
            return $"{tankName}: Ammo={ammunitionLevel}%, Armor={armorLevel}%, Maneuverability={maneuverabilityLevel}%";
        }

        // Перегрузка оператора "^" (произведение) с обработкой исключительных ситуаций
        public static bool operator ^(Tank tank1, Tank tank2)
        {
            try
            {
                int count = 0;

                if (tank1.ammunitionLevel > tank2.ammunitionLevel)
                    count++;
                if (tank1.armorLevel > tank2.armorLevel)
                    count++;
                if (tank1.maneuverabilityLevel > tank2.maneuverabilityLevel)
                    count++;

                return count >= 2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка при сравнении танков: " + ex.Message);
                return false;
            }
        }
    }
}
