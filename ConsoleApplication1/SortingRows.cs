using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    public static class SortingRows
    {
        public static int[][] BubbleSort( int[][] array, int[] arrayForSort, bool course)
        {
            int [] tempArray;

            for (int i = 0; i < arrayForSort.Length; i++)
            {
                for (int j = i + 1; j < arrayForSort.Length; j++)
                {
                    if (course)
                    {
                        if (arrayForSort[j] < arrayForSort[i])
                        {
                            Swap(ref arrayForSort[j], ref arrayForSort[i]);
                            tempArray = array[j];
                            array[j] = array[i];
                            array[i] = tempArray;
                        }
                    }
                    else
                    {
                        if (arrayForSort[j] > arrayForSort[i])
                        {
                            Swap(ref arrayForSort[j], ref arrayForSort[i]);
                            tempArray = array[j];
                            array[j] = array[i];
                            array[i] = tempArray;
                        }
                    }
                }
            }
            return array;
        }
        public static void Swap(ref int firstElement, ref int secondElement)
        {
            int temp = firstElement;
            firstElement = secondElement;
            secondElement = temp;
        }
        public static int[][] SortBySum(int[][] array, bool course)
       {
           int[] arrayForSort = new int[array.Length];
           for (int i = 0; i < array.Length; i++)
           {
               arrayForSort[i] = array[i].Sum();
           }
           BubbleSort( array, arrayForSort, course);
           return array;
       }
        public static int[][] SortByMax(int[][] array, bool course) 
       {
           int[] arrayForSort = new int[array.Length];
           for (int i = 0; i < array.Length; i++)
           {
               arrayForSort[i] = array[i].Max();
            }
           BubbleSort(array, arrayForSort, course);
           return array;
       }

        public static int[][] SortByMin(int[][] array, bool course) 
       {
           int[] arrayForSort = new int[array.Length];
           for (int i = 0; i < array.Length; i++)
           {
               arrayForSort[i] = array[i].Min();
            }
           BubbleSort(array, arrayForSort, course);
           return array;
       }

    }
}
