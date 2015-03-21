using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class SumCompare:ICompare
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {
          
            var firstMaxValue = firstArray.Sum();
            var secondMaxValue = secondArray.Sum();

            return firstMaxValue.CompareTo(secondMaxValue);
        }
    }
}
