using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ICompare
    {
        int Compare(int[] firstArray, int[] secondArray);
    }
}
