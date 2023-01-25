//Chapter 3 Exercize 34
//written by Muna shabab
//date:9-10-2020
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34
{
    class Program
    {
        static void Main(string[] args)
        {
            //explain the program to the user
            Console.WriteLine("this program accepts measurements of a box, length, width and depth and calculate and displays the surface area ");

            //get the dimentions from the user and store  them
            Console.WriteLine("please enter the length of the box:");
            double length = double.Parse(Console.ReadLine());

            Console.WriteLine("please enter the width of the box:");
            double width = double.Parse(Console.ReadLine());

            Console.WriteLine("please enter the depth of the box:");
            double depth = double.Parse(Console.ReadLine());

            //calculat the suface area
            double surfaceArea = 2 * ((length * width) + (length * depth) + (width * depth));

            //display the results
            Console.WriteLine($"the suface area of the box is {surfaceArea:n1} square units");
            Console.ReadLine();
           
         
        }
    }
}
