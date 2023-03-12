using System;
using static System.Console;
Clear();
string path = "C:/Users/Игорь/OneDrive/Рабочий стол/Geekbrain/git_training_5_C#/Example006_Based";//C:/Users/iebal/OneDrive/Рабочий стол/Geekbrain/git_training_5_C#/Example001_HelloConsole";
DirectoryInfo di = new DirectoryInfo(path);
WriteLine(di.CreationTime);
FileInfo[] fi = di.GetFiles();

for(int i = 0; i < fi.Length; i++)
{
    WriteLine(fi[i].Name);
}

void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);

    DirectoryInfo[] catalogs = catalog.GetDirectories();
    for(int i = 0; i < catalogs.Length; i++)
    {
        WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + " ");
    }

    FileInfo[] files = catalog.GetFiles();

    for(int i = 0; i < files.Length; i++)
    {
        WriteLine($"{indent}{files[i].Name}");
    }

}
 CatalogInfo(path);
