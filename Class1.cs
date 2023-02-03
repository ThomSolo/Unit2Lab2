
//Name: Solomon Thomas, Eyitayo Akinjinmi, and Riley Powers
//Course Section: CPS*3330*01
//Lab #2
using System;
using System.Reflection.Metadata.Ecma335;

namespace KeanID_Library_Unit2
{
    public class Class1
    {
        public static double Min(double num1, double num2)
        {
            if (num1 < num2) { return num1; }
            else { return num2; }
        }

        public static double Min(double num1, double num2, double num3)
        {
            double min = num1;
            if (num2 < min) { min = num2; }
            if (num3 < min) { min = num3; }
            return min;
        }
    }
}

