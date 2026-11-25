/* 
Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments and out parameters to return both total and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18.75
The total is 75
*/

static void CalculateTotalAndAverage(out double total, out double average, params double[] numbers)
{
    total = 0;
    foreach (var number in numbers)
    {
        total += number;
    }
    average = total / numbers.Length;
}

Console.WriteLine("Enter the First number: ");
double first = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the Second number: ");
double second = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the third number: ");
double third = double.Parse(Console.ReadLine());
Console.WriteLine("Enter the fourth number: ");
double fourth = double.Parse(Console.ReadLine());

CalculateTotalAndAverage(out double total, out double average, first, second, third, fourth);
Console.WriteLine($"The average of {first}, {second}, {third}, {fourth} is: {average}");
Console.WriteLine($"The total is {total}");
