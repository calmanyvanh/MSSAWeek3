/*
5. Create a function that finds the index of a given item in the array

Examples

Search([1, 5, 3], 5) ➞ 1

Search([9, 8, 3], 3) ➞ 2

Search([1, 2, 3], 4) ➞ -1

Notes

If the item is not present, return -1.
*/

struct Program
{
    static void Main(string[] args)
    {
        int[] array1 = { 1, 5, 3 };
        int index1 = Search(array1, 5);
        Console.WriteLine(index1); // Output: 1

        int[] array2 = { 9, 8, 3 };
        int index2 = Search(array2, 3);
        Console.WriteLine(index2); // Output: 2

        int[] array3 = { 1, 2, 3 };
        int index3 = Search(array3, 4);
        Console.WriteLine(index3); // Output: -1

    }
    static int Search(int[] arr, int item)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == item)
            {
                return i;
            }
        }
        return -1; // Item not found
    }
}