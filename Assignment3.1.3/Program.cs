/*
Write a program in C# Sharp to create a function to input a string and count number of spaces in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input a string: ");
        string inputString = Console.ReadLine();
        int spaceCount = CountSpaces(inputString);
        Console.WriteLine($"\"{inputString}\" contains {spaceCount} spaces");
    }
    static int CountSpaces(string str)
    {
        int count = 0;
        foreach (char c in str)
        {
            if (c == ' ')
            {
                count++;
            }
        }
        return count;
    }
}