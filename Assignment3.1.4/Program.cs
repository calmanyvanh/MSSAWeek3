/* 
Assignment3.1.4
Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]
*/

class Program
{
    static void Main()
    {
        int[] inputArray = { 0, 2, 1, 1, 9, 1, 1 };
        int[] outputArray = ChangeConsecutiveOnesToZero(inputArray);

        Console.WriteLine("Output: [" + string.Join(",", outputArray) + "]");
    }
    static int[] ChangeConsecutiveOnesToZero(int[] arr)
    {
        for (int i = 0; i < arr.Length - 1; i++)
        {
            if (arr[i] == 1 && arr[i + 1] == 1)
            {
                arr[i] = 0;
                arr[i + 1] = 0;
                break; 
            }
        }
        return arr;
    }
}