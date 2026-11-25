/*

Sum digits in string

Given a string, write a method which returns sum of all digits in that string. 
Assume that string contains only single digits.

Expected input and output: 

SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9

SumDigitsInString("") → 0
*/

class Program

{
    static void Main()
    {
        string enterString = "1 plus 2 plus 4 plus 7";
        int sum = 0;

        Console.WriteLine("Enter string: " + enterString);

        foreach (char c in enterString)
        {
            if (char.IsDigit(c))
            {
                sum += int.Parse(c.ToString());
                Console.WriteLine("Digits in string: " + c);
            }
        }
        Console.WriteLine("Sum of digits: " + sum);
    }
}

