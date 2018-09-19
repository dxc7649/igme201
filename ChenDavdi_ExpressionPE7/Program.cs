using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChenDavdi_ExpressionPE7
{
    class Program
    {
        static void CalculateArea() //First method to calculate a room area of 10 * 13
        {
            double area = 10 * 13;
            Console.WriteLine("A 10 x 13 room needs {0} square feet of carpet.", area);
        }

        static void CalculateAreaTwo() //Second method to calculate a room area of 8 * 12
        {
            double area = 8 * 12;
            Console.WriteLine("A 8 x 12 room needs {0} square feet of carpet.", area);
        }

        static void CalculateAnyArea(double width, double length) //Third method to calculate a room area based on tow parameters and output the result into console window
        {
            double area = width * length;
            Console.WriteLine("A {0} x {1} room needs {2} square feet of carpet.", width, length, area);
        }

        static double ReturnCalculatedArea(double width, double length) //Fourth method to calculate a room area based on tow parameters and return the final result as a "double"
        {
            double area = width * length;
            return area;
        } 

		static string PrintYourName(string name) { //Method used to return the parameter ("name") the user put in as a string 
			return name;
		}

		static void Subtraction(double firstNum, double secondNum) { //Subtract two parameters ("firstNum" and "secondNum") and output the final result to the Console Window
			double result = firstNum - secondNum;
			Console.WriteLine("{0} - {1} is {2}.", firstNum, secondNum, result);
		}

		static double ReturnSubtraction(double firstNum, double secondNum) { //Subtract two parameters and return the final result as a double 
			double result = firstNum - secondNum;
			return result;
		}

        static void Main(string[] args)
        {
            /* CalculateArea();
            CalculateAreaTwo();
            CalculateAnyArea(11.5, 14);

            double totalCarpetArea = ReturnCalculatedArea(9, 9.5);
            Console.WriteLine(totalCarpetArea);

            double secondCarpetArea = ReturnCalculatedArea(12.25, 11);
            double thirdCarpetArea = ReturnCalculatedArea(24, 20.25);

            Console.WriteLine("You need {0} square feet of carpet for those rooms.", totalCarpetArea + secondCarpetArea + thirdCarpetArea); */

			string yourName = PrintYourName("David"); //Create a string and put the resulf of "PrintYourName" method inside this string.  
			Console.WriteLine(yourName); 

			Subtraction(10, 3); //Use "Subtraction" method to calculate the resulf of 10 - 3 and 4.2 - 15.6
			Subtraction(4.2, 15.6);

			double subResult = ReturnSubtraction(20, 4); //Create a double and put the result of "ReturnSubtraction" method inside this double
			Console.WriteLine("Subtraction of 20 and 4: {0}.", subResult); 
        }
    }
}
