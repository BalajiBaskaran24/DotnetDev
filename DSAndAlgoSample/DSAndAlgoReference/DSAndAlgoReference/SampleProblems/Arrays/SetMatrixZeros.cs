using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSAndAlgoReference.SampleProblems.Arrays;

/// <summary>
/// If any cell in a 2D array contains 0 then all elements of
/// particular row and column should be set to 0
/// </summary>
public class SetMatrixZeros
{

    #region Brute force approach
    //Set -1 to all elements present in row||column that contain 0
    //Iterate the array again and change the values from -1 to 0
    public int[,] BruteForce(int[,] input)
    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (input[i, j] == 0)
                {
                    MarkRow(input, i);
                    MarkColumn(input, j);
                }
            }
        }

        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (input[i, j] == -1)
                {
                    input[i, j] = 0;
                }
            }
        }
        return input;
    }

    /// <summary>
    /// Mark all elements in current row to -1
    /// </summary>
    /// <param name="input"></param>
    /// <param name="rowIndex"></param>
    private void MarkRow(int[,] input, int rowIndex)
    {
        for (int i = 0; i < input.GetLength(1); i++)
        {
            if (input[rowIndex, i] != 0)
            {
                input[rowIndex, i] = -1;
            }
        }
    }

    /// <summary>
    /// Mark all elements in current column to -1
    /// </summary>
    /// <param name="input"></param>
    /// <param name="colIndex"></param>
    private void MarkColumn(int[,] input, int colIndex)
    {
        for (int i = 0; i < input.GetLength(0); i++)
        {
            if (input[i, colIndex] != 0)
            {
                input[i, colIndex] = -1;
            }
        }
    }

    #endregion

    #region Better approach
    //Have two array to track the row and column index for which all 
    //values should be set to 0
    public int[,] BetterSolution(int[,] input)
    {
        int[] RowIndex = new int[input.GetLength(0)];
        int[] ColIndex = new int[input.GetLength(1)];

        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if (input[i, j] == 0)
                {
                    RowIndex[i] = 1;
                    ColIndex[j] = 1;
                }
            }
        }

        for (int i = 0; i < input.GetLength(0); i++)
        {
            for (int j = 0; j < input.GetLength(1); j++)
            {
                if ((RowIndex[i] | ColIndex[j]) == 1)
                {
                    input[i, j] = 0;
                }
            }
        }
        return input;
    }

    #endregion

    #region Optimal approach
    //Use first row and column for tracking similar to better approach
    //for 0*0 have seperate variable. Since its common for row and column
    #endregion
}
