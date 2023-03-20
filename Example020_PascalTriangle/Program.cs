using System;
using static System.Console;
Clear();

int row = 25;
int[,] triangle = new int[row, row];
const int cellWidth = 1;

void FillTriangle()
{
    for(int i = 0; i < row; i++)
    {
        triangle[i, 0] = 1;
        triangle[i, i] = 1;
    }
    for(int i = 2; i < row; i++)
    {
        for(int j = 1; j <= i; j++)
        {
            triangle[i, j] = triangle[ i - 1, j - 1] + triangle[i - 1, j];
        }

    }
}

void PrintTriangle()
{
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < row; j++)
        {
            if(triangle[i, j] != 0)
            Write($"{triangle[i, j], cellWidth}");
        }
        WriteLine();
    }
}

void Magic()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j < row; j++)
        {
            SetCursorPosition(col, i + 1);
            //if(triangle[i, j] != 0)
            //Write($"{triangle[i, j], cellWidth}");
            if(triangle[i, j] % 5  != 0)                  // Функция заполнения %2 %3, %4, %5....
            WriteLine("*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        WriteLine();
    }

}

FillTriangle();
//PrintTriangle();
Magic();