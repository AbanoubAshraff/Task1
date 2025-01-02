using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //FirstTask
            Console.WriteLine("firstTask");



            Console.WriteLine("Number of small carpets:");
            int small = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Number of large carpets:");
            int large = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Price per small room: $25");


            Console.WriteLine("Price per large room: $35");

            double cost = small * 25 + large * 35;
            double tax = (cost / 100) * 6;
            double total = tax + cost;


            Console.WriteLine($"Cost:{cost}");


            Console.WriteLine($"Tax:{tax}");

            Console.WriteLine("===============================");

            Console.WriteLine($"Total estimate:{total}");

            Console.WriteLine("This estimate is valid for 30 days");


            Console.WriteLine("===============================");

            Console.WriteLine("SecendTask");

            //SecendTask
            //3. try another example with a different specifier with a screenshot of the output.
            double X = .25;
            double Y = .65;
            Console.WriteLine($"Equation: {X} + {Y} = {X + Y:P}");

            // 1. why the output of this Equation = $30.00? 
            // علشان الحرف c ف الكود اللي موجود ف التاسك بيعبر عن  العملات و بينظم الارقام ك انها تشير علي عمله
            //2. what is its benefit?
            // اني فهمت ان السي شارب ف حاجه اسمها سابيلفاير بيساعدني اني انظم الارقام و اطلعها ف الفورمت اللي انا عايزه
            



        }
    }
}
