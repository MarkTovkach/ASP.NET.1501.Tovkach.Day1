using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Newton
{
    class ConsoleUI
    {
        static void Main(string[] args)
        {
            double baseNumber;
            double indexNumber;
            double accuracy;
            double accuracyOfComparison;

            Console.WriteLine("Please input the base:");
            string s = Console.ReadLine();
            while (Double.TryParse(s, out baseNumber) != true)
            {
                Console.WriteLine("Wrong input.Try again:");
                s = Console.ReadLine();
            }
            baseNumber = Convert.ToDouble(s);

            Console.WriteLine("Please input the index:");
            s = Console.ReadLine();
            while (Double.TryParse(s, out indexNumber) != true)
            {
                Console.WriteLine("Wrong input.Try again:");
                s = Console.ReadLine();
            }
            indexNumber = Convert.ToDouble(s);
            Console.WriteLine("Please input the accuracy:");
            s = Console.ReadLine();
            while (Double.TryParse(s, out accuracy) != true)
            {
                Console.WriteLine("Wrong input.Try again:");
                s = Console.ReadLine();
            }
            accuracy = Convert.ToDouble(s);

            Console.WriteLine("Your result:{0}", NewtonMethod.RootOfNDegree(baseNumber, indexNumber, accuracy));
            Console.WriteLine("Do you want to compare the result with true value??? Y/N");
            string c = Console.ReadLine();
            char j = Convert.ToChar(c);
            if (j == 89 || j == 121)
            {
                Console.WriteLine("Please input the accuracy for compare:");
                string k = Console.ReadLine();
                while (Double.TryParse(k, out accuracyOfComparison) != true)
                {
                    Console.WriteLine("Wrong input.Try again:");
                    k = Console.ReadLine();
                }
                accuracyOfComparison = Convert.ToDouble(k);
                if (Math.Abs(baseNumber - Math.Pow(NewtonMethod.RootOfNDegree(baseNumber, indexNumber, accuracy), indexNumber)) < accuracyOfComparison)
                {
                    Console.WriteLine("After comparing your result is true with this accuracy.");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("After comparing your result is false with this accuracy. ");
                    Console.ReadKey();

                }
            }
            else
            {
                if (j == 78 || j == 110)
                {
                    Console.WriteLine("Thank you.");
                    Console.ReadKey();
                }
            }
        }
    }
}