/*

If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true 
IfYearIsLeap(2018) → false

*/

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a year:");
        int year = Convert.ToInt32(Console.ReadLine());
        bool isLeap = IfYearIsLeap(year);
        Console.WriteLine($"Is {year} a leap year? {isLeap}");
    }
    static bool IfYearIsLeap(int year)
    {

        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                return year % 400 == 0;
            }
            return true;
        }
        return false;
    }
}
