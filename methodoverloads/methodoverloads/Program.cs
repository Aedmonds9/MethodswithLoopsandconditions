using System;

namespace methodoverloads
{
    internal class Program
    {

        //Create an Add method:
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }


        //Create an overload of the Add method:
        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        //Create another overload of the Add method:
        public static string Add(int num1, int num2, bool isTrue)
        {
            var sum = 0;
            if (isTrue)
            {
                sum = num1 + num2;
                if (sum == 1)
                {
                    return $"{sum} dollar.";
                }
                else
                {
                    return $"{sum} dollars.";
                }
            }
        }
       static void Main(string[] args)
       {
         Console.WriteLine(Add(0, 1, true));
         Console.WriteLine(Add(5, 7, true));
         Console.WriteLine(Add(-6, 3, true));
       }
    }
}
