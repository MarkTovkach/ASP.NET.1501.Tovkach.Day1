using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class LengthCompare
    {
        public int Compare(int[] firstArray, int[] secondArray)
        {

            var firstMaxValue = firstArray.Length;
            var secondMaxValue = secondArray.Length;

            
            return firstMaxValue.CompareTo(secondMaxValue);
        }
    }
}
