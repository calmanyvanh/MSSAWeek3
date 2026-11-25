/*
Write a program in C# Sharp for addition of two Matrices of same size.

Test Data :

Elements in the first matrix :
element - [0],[0] : 1

element - [0],[1] : 2

element - [1],[0] : 3

element - [1],[1] : 4

Elements in the second matrix :
element - [0],[0] : 5

element - [0],[1] : 6

element - [1],[0] : 7

element - [1],[1] : 8

Expected Output:
The First matrix is:

1 2

3 4

The Second matrix is :

5 6

7 8

The Addition of two matrix is :

6 8

10 12

*/

class Program
{
    static void Main(string[] args)
    {
    int[,] firstMatrix = new int[2, 2];
    int[,] secondMatrix = new int[2, 2];
    int[,] sumMatrix = new int[2, 2];

    // Input for first matrix
    Console.WriteLine("Elements in the first matrix :");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"element - [{i}],[{j}] : ");
            firstMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Input for second matrix
    Console.WriteLine("\nElements in the second matrix :");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write($"element - [{i}],[{j}] : ");
            secondMatrix[i, j] = Convert.ToInt32(Console.ReadLine());
        }
    }

    // Adding two matrices
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            sumMatrix[i, j] = firstMatrix[i, j] + secondMatrix[i, j];
        }
    }
    // Displaying the matrices
    Console.WriteLine("\nThe First matrix is:");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(firstMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nThe Second matrix is:");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(secondMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    Console.WriteLine("\nThe Addition of two matrix is:");
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            Console.Write(sumMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }
    }   
}


