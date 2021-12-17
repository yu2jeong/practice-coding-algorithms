using System;
using System.Linq;
using System.Collections.Generic;

public class MainClass
{
    public static void Main(string[] args)
    {
        var main = new MainClass();
        //Get Input
        int tcCount = int.Parset(Console.ReadLine());

        for (int tc = 1; tc <= tcCount; tc++)
        {
            
            // Get Matrix
            int matrixSize = int.Parset(Console.ReadLine());
            var inputMatrix = new int[matrixSize][matrixSize];
            for (int r = 0; r < matrixSize; r++)
            {
                string[] strArr = Console.ReadLine().Split(' ');
                string[] intArr = strArr.Select(int.Parse).ToArray();

                intputMatrix[r] = intArr;
            }

            // Get Answer
            int diagonalSum = main.GetDiagonalSum(inputMatrix);
            int repeatedRowCount = main.GetRepeatedRowCount(inputMatrix);
            int repeatedNum = main.GetRepeatedNum(inputMatrix);
            Console.WriteLine($"Case #{tc}: {diagonalSum} {repeatedRowCount} {repeatedNum}");
        }
    }

    private int GetRepeatedNum(int[][] matrix)
    {
        int count = 0;
        //row
        for (int i = 0; i < matrix.Length; i++)
        {
            int[] countArr = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                countArr[matrix[i][j]-1] += 1;
            }
            count += countArr.Where(c => c >= 2).Sum(c => 1);
        }

        //col
        for (int i = 0; i < matrix.Length; i++)
        {
            int[] countArr = new int[matrix.Length];
            for (int j = 0; j < matrix.Length; j++)
            {
                countArr[matrix[j][i]-1] += 1;
            }
            count += countArr.Where(c => c >= 2).Sum(c => 1);
        }

        return count;
    }

    private int GetDiagonalSum(int[][] matrix)
    {
        int sum = 0;
        for (int i = 0; i < matrix.Length; i++)
        {
            sum += matrix[i][i];
        }
        return sum;
    }

    private int GetRepeatedRowCount(int[][] matrix)
    {
        int count = 0;

        for (int i = 0; i < matrix.Length; i++)
        {
            HashSet<int> numSet = new HashSet(matrix[i]);
            if(numSet.Count != matrix.Length)
            {
                count += 1;
            }
        }
        return count;
    }
}
