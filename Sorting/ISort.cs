using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    interface ISort
    {
        void Sort(int[][] array,bool course, ICompare comparer);
    }
}
