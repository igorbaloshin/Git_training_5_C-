Console.Clear();
// Цикл FOR
string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 1; i < count; i++)
    {
        result = result + text;
    }
    return result;

}

string res = Method4(10, "Ура, ");
Console.WriteLine(res);
//-------------------------------------------------
// Печать таблицы умножения

// for(int i = 2; i <= 10; i++)
// {
//     for(int j = 2; j <= 10; j++)
//     {
//         Console.WriteLine($"{i} X {j} = {i * j}");

//     }
//     Console.WriteLine();
// }
//--------------------------------------------------
//