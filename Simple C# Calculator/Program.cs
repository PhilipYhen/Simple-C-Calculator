using System;
using System.Linq;
using System.Collections.Generic;

namespace Calculator;

public class Program 
{       
	public static void Main()
	{
		Console.Write("Enter Operation: ");
		Console.WriteLine(handleOpperation(Console.ReadLine()));	
	}

	static string handleOpperation(string value)
	{
		(double num1, double num2) = HandleInputNumbers();		string opperator = value;
		
		switch(opperator){
			case "sum" : case "add" : case "plus": case "+":
				return "The Sum of " + num1 + " and " + num2 + " is equal to " + (num1 + num2);	
			case "difference": case "minus" : case "Subtract": case "-":
				return "The Difference of " + num1 + " and " + num2 + " is equal to " + (num1 - num2);	
			case "product": case "multiply" : case "times": case "×": case "*":
				return "The Product of " + num1 + " and " + num2 + " is equal to " + (num1 * num2);	
            case "quotient": case "divide" : case "fraction": case "÷": case "/":
				return "The Quotient of " + num1 + " and " + num2 + " is equal to " + (num1 / num2);
			case "remainder": case "modulo" : case "modulus": case "%":
				return "The Remainder of " + num1 + " and " + num2 + " is equal to " + (num1 % num2);
			default:
				return "Invalid Operation";
		}	
		return null;
	}
    
	static (double, double) HandleInputNumbers()
    {
        Func<double> getFirstNumber = () =>
        {
            Console.Write("Enter First Number: ");
            return Convert.ToDouble(Console.ReadLine());
        };

        Func<double> getSecondNumber = () =>
        {
            Console.Write("Enter Second Number: ");
            return Convert.ToDouble(Console.ReadLine());
        };
        return (getFirstNumber(), getSecondNumber());
    }	
}