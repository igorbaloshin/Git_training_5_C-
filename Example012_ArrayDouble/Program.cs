Console.Clear();

// string[,] table = new string[4,5];
// table[1,2] = "слово";
// for(int i = 0; i < 4; i++)
// {
//     for(int j = 0; j < 5; j++)
//     {
//         Console.Write($"- {table[i,j]} -");

//     }
//     Console.WriteLine();
// }


void PrintArray(int[,] matr)
{
   for(int i = 0; i < matr.GetLength(0); i++)
   {
       for(int j = 0; j< matr.GetLength(1); j++)
       {
           Console.Write($" {matr[i,j]} ");
       }
       Console.WriteLine();
   }
}

void FillArray(int[,] matr)
{
   for(int i = 0; i < matr.GetLength(0); i++)
   {
       for(int j = 0; j< matr.GetLength(1); j++)
       {
           matr[i,j] = new Random().Next(1,10);
       }
       Console.WriteLine();
   }
}
 int[,] matrix = new int[5,6];
 PrintArray(matrix);
 FillArray(matrix);
 Console.WriteLine();
 PrintArray(matrix);
