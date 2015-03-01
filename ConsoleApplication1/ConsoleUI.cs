using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            int size,size2,element, key;
            bool order = true;
            //The Initialization of a Ragged Array 
            Console.WriteLine("Hi! Please, input the array size: ");
            string s = Console.ReadLine();

            while (Int32.TryParse(s, out size) != true)
            {
                Console.WriteLine("Wrong input.Try again:");
                s = Console.ReadLine();

            }
            size = Int32.Parse(s);
  

            int[][] jaggedArray = new int[size][];

            for (int i = 0; i < jaggedArray.Length; i++)
            {
                Console.WriteLine("Input the {0}th array size: ", i);
                 s = Console.ReadLine();

                while (Int32.TryParse(s, out size) != true)
                {
                    Console.WriteLine("Wrong input.Try again:");
                    s = Console.ReadLine();

                }
                size2 = Int32.Parse(s);
                jaggedArray[i] = new int[size2];
            }

            //Filling an array
            for(int i=0;i<jaggedArray.Length;i++)
                for(int j=0;j<jaggedArray[i].Length;j++)
                {
                    Console.WriteLine("Input [{0}][{1}]",i,j);
                    s = Console.ReadLine();

                   while (Int32.TryParse(s, out element) != true)
                    {
                        Console.WriteLine("Wrong input.Try again:");
                        s = Console.ReadLine();

                    }

                    element = Int32.Parse(s);
                    jaggedArray[i][j]=element;

                 }
            // Select the order of sorting

            Console.WriteLine("Ascending or descending order A/D");
            string k = Console.ReadLine();
            if (k == "A" || k == "a")
                order = true;
            else if (k == "D" || k == "d")
                order = false;
            // Select sorting feature
            Console.WriteLine("On the amounts of the elements in rows(Input 1)/On the min of the elements in rows(Input 2)/On the max of the elements in rows(Input 3)");
            k = Console.ReadLine();
            int position = Convert.ToInt32(k);

            switch (position)
            {
                case 1: SortingRows.SortByMax(jaggedArray, order);
                    break;
                case 2: SortingRows.SortByMin(jaggedArray, order);
                    break;
                case 3: SortingRows.SortByMax(jaggedArray, order);
                    break;
            }

        }
    }
}
