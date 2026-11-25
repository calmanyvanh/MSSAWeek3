/*
Given a string, write a method that checks if it is a palindrome (is read the same backward as forward). 
Assume that string may consist only of lower-case letters.

Expected input and output

IsPalindrome("eye") → true

IsPalindrome("home") → false
*/

using System.Text;

class Program
{

    public static bool IsPalindrome(string Palindrome)
    {
        StringBuilder sb = new StringBuilder();
        for (int i = Palindrome.Length - 1; i >= 0; i--)
        {
            sb.Append(Palindrome[i]);
           //Console.WriteLine($"{i} = {Palindrome[i]}");
           //Console.WriteLine(sb.ToString());
        }
        return Palindrome == sb.ToString();
    }

    static void Main()
    {
        Console.WriteLine("Enter text to test for palindrome: ");
        string Palindrome = Console.ReadLine();

        Console.WriteLine(IsPalindrome(Palindrome));
     
    }

}