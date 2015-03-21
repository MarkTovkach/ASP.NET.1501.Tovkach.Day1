using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
   public static class SortingRows : ISort
    {
       
        public static void Sort(int[][] array,bool course, ICompare comparer)
        {
            if (array == null)
            {
                throw new ArgumentNullException("arrayForSort");
            }
            if (comparer == null)
            {
                throw new ArgumentNullException("compare");
            }
            //For Ascending
           if (course)
	       {
               for (int i = 0; i < array.Length; i++)
               {
                   for (int j = i + 1; j < array.Length; j++)
                   {
                       if (comparer.Compare(array[i], array[j]) > 0)
                       {
                           var temp = array[i];
                           array[i] = array[j];
                           array[j] = temp;
                       }
                   }
               }
	       }
           //For Descending
           if (!course)
           {
               for (int i = 0; i < array.Length; i++)
               {
                   for (int j = i + 1; j < array.Length; j++)
                   {
                       if (comparer.Compare(array[i], array[j]) > 0)
                       {
                           var temp = array[j];
                           array[j] = array[i];
                           array[i] = temp;
                       }
                   }
               }
           }

        }
       public static void Sort(int [][] array,bool course,Func<int[], int[], int> comparer)
       {
           if (array == null)
            {
                throw new ArgumentNullException("arrayForSort");
            }
            if (comparer == null) 
            {
                throw new ArgumentNullException("compare");
            }
            //For Ascending
            if (course)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (comparer(array[i], array[j]) > 0)
                        {
                            var temp = array[i];
                            array[i] = array[j];
                            array[j] = temp;
                        }
                    }
                }
            }
            //For Descending
            if (!course)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = i + 1; j < array.Length; j++)
                    {
                        if (comparer(array[i], array[j]) > 0)
                        {
                            var temp = array[j];
                            array[j] = array[i];
                            array[i] = temp;
                        }
                    }
                }
            }


       }
    }
}
