using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyClassLib.WordOfTanks
{
    public class CustomArray
    {
        private int[] array;

        public CustomArray(int[] arr)
        {
            array = arr;
        }

        public static bool operator <(CustomArray arr1, CustomArray arr2)
        {
            return arr1.array.Sum() < arr2.array.Sum();
        }

        public static bool operator >(CustomArray arr1, CustomArray arr2)
        {
            return arr1.array.Sum() > arr2.array.Sum();
        }
    }
}
