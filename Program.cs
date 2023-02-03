//Name: Solomon Thomas, Eyitayo Akinjinmi, and Riley Powers
//Course Section: CPS*3330*01
//Lab #2
using System;


Console.Write("Enter the number of values that you want to input: ");
double input = Convert.ToDouble(Console.ReadLine());

if (input < 2)
{
    Console.WriteLine("There has to be two different numbers for there to be a minimum number!");
    return; //Used to stop the code from continuing on
}

if (input  < 3)
{
    Console.Write("Enter num1: ");
    double num1 = Convert.ToDouble(Console.ReadLine());

    Console.Write("Enter num2: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    //2 args
    Console.WriteLine("Min is: " + KeanID_Library_Unit2.Class1.Min(num1, num2));

    return;
}

if (input == 3)
{
Console.Write("Enter num1: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter num2: ");
double num2 = Convert.ToDouble(Console.ReadLine());

Console.Write("Enter num3: ");
double num3 = Convert.ToDouble(Console.ReadLine());

//3 args
Console.WriteLine("Min is: " + KeanID_Library_Unit2.Class1.Min(num1, num2, num3));

    return;
}

if (input > 3)
{
    Console.WriteLine("You cannot go over 3!");

    return;
}



