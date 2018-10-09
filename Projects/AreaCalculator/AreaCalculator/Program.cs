using System;

namespace AreaCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to the Area Calculator");
            string input;
          do
            {
                AreaCalc();
                Console.WriteLine("Continue Y/N");
                input = Console.ReadLine().ToLower();
            } while (input == "y");




            //Methods

            void AreaCalc()
            {
                Console.WriteLine("Enter your length");
                var input1 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter your width");
                var input2 = Convert.ToDouble(Console.ReadLine());

                Area(input1, input2);
                Parameter(input1, input2);
            }
           
             void Area(double length, double width )
            {
                Console.WriteLine("Area: " + length * width);
            }

            void Parameter(double length, double width)
            {
                Console.WriteLine("Perimeter: " + (length + length + width + width));
            }
        }
    }
}
