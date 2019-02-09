using System;

namespace Mileage
{
    public static class Program
    {
        public static void Main()
        {
            Console.Write("How many miles have you driven? ");
            float miles = float.Parse(Console.ReadLine());
            // Get input from the user and save it to a variable.

            Console.Write("How many gallons of gas have you consumed? ");
            float gallons = float.Parse(Console.ReadLine());


            // Get input from the user and save it to a second variable.

            // Output - Your miles per gallon is (computed value)
            float mpg = miles / gallons;
            
            Console.WriteLine("Your miles per gallon is " + mpg);
            Console.ReadLine();
        }
    }
}
