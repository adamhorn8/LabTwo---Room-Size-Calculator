using System;

namespace LabTwo
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ask for user inputs
            Console.WriteLine("Please enter the length of the room in feet");
            string Length = Console.ReadLine();
            Console.WriteLine("Please enter the width of the room in feet");
            string Width = Console.ReadLine();
            Console.WriteLine("Please enter the height of the room in feet");
            string Height = Console.ReadLine();

            //Convert string inputs to doubles
            double LengthD = Convert.ToDouble(Length);
            double WidthD = Convert.ToDouble(Width);
            double HeightD = Convert.ToDouble(Height);

            //Using artithmetic formulas solve for each desired output
            double Area = (LengthD * WidthD);
            double Perimeter = ((2 * LengthD) + (2 * WidthD));
            double Volume = (LengthD * WidthD * HeightD);


            //Display results of formulas
            Console.WriteLine("The Area of the room is " + Area + " feet\xB2");
            Console.WriteLine("The Perimeter of the room is " + Perimeter + " feet");
            Console.WriteLine("The Volume of the room is " + Volume + " feet\xB3");

        }
    }
}