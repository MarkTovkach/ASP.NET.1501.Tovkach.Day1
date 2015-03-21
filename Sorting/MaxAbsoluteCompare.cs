using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class MaxAbsoluteCompare : ICompare
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {

            var firstMaxValue = MaxAbsoluteValue(firstArray);
            var secondMaxValue = MaxAbsoluteValue(secondArray);
            return firstMaxValue.CompareTo(secondMaxValue);
        }

        private static int MaxAbsoluteValue(int[] array)
        {
            int maxAbsValue = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (Math.Abs(array[i]) > maxAbsValue)
                {
                    maxAbsValue = Math.Abs(array[i]);
                }
            }
            return maxAbsValue;
        }
    }
}