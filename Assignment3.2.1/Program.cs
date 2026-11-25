/* 
Create a 2D array to store integers and print them in matrix format with proper formatting.

e. g:

| 2 | 3 | 4 |

| 1 | 4 | 6 |
*/

int[,] matrix = new int[2, 3] { { 2, 3, 4 }, { 1, 4, 6 } };

for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write("| " + matrix[i, j] + " ");
    }
    Console.WriteLine("|");
}
