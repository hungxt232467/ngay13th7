namespace samsung;
using System;
class Math
{
    static void Main(String[] args)
    {
        int numOne;
        int numTwo;
        int result = 0;
        Console.WriteLine("(1) Addition");
        Console.WriteLine("(2) Subtraction");
        Console.WriteLine("(3) Multiplication");
        Console.WriteLine("(4) Division");
        int input = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Ener value one");
        numOne = Convert.ToInt32(Console.ReadLine());
        switch (input)
        {
            case 1:
                result = numOne + numTwo;
                break;
            case 2:
                result = numOne - numTwo;
                break;
            case3:
                result = numOne * numTwo;
                break;
            case4:
                Console.WriteLine("Do you want to calculate the quotient or remainder?");
                Console.WriteLine("(1) Quotient");
                Console.WriteLine("(2) Remainder");

        }
    }
}
