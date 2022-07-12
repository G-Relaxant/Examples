/*
string path = "C:/Users/G1Sup/Desktop/Examples/Ex14_Directory_Lesson7";
DirectoryInfo di = new DirectoryInfo(path);
System.Console.WriteLine(di.CreationTime);  // Show create time of dir (1 str)
FileInfo[] fi = di.GetFiles();

for(int i = 0; i < fi.Length; i++)
{
    System.Console.WriteLine(fi[i].Name);  // Show list of files from dir
}
*/


/*
void CatalogInfo(string path, string indent = "")
{
    DirectoryInfo catalog = new DirectoryInfo(path);  // Нужен для получения всей информации для последующих циклов

    DirectoryInfo[] catalogs = catalog.GetDirectories();  // Нужен для получения кол-ва папок в текущей папке, для цикла for(DirectoryInfo), для вывода всех папок в консоль                                                     
    for(int i = 0; i < catalogs.Length; i++)  // Перебирает папки в текущей папке
    {
        Console.WriteLine($"{indent}{catalogs[i].Name}");
        CatalogInfo(catalogs[i].FullName, indent + "  ");  // Рекурсия нужна для последовательного открытия всех вложенных папок(то есть происходит последовательный ступенчатый перебор всех папок)
    }

    FileInfo[] files = catalog.GetFiles();  // Нужен для получения кол-ва файлов в текущей папке, для цикла for(FileInfo), для вывода всех файлов в консоль

    for(int i = 0; i < files.Length; i++)  // Перебирает файлы в текущей папке
    {
        Console.WriteLine($"{indent}{files[i].Name}");
    }
}

string path = "C:/Users/G1Sup/Desktop/Examples/Ex14_Directory_Lesson7";
CatalogInfo(path);
*/


/*
void Towers(string with = "1", string on = "3", string some = "2", int count = 5)
{
    if(count > 1) Towers(with, some, on, count - 1);
    Console.WriteLine($"{with} >> {on}");
    if(count > 1) Towers(some, on, with, count - 1);
}

Towers();
*/




decimal fRec = 0;
decimal fIte = 0;

decimal FibonacciRecursion(int n)
{
    fRec++;
    return n == 0 || n == 1 ? 1 : FibonacciRecursion(n - 1) + FibonacciRecursion(n - 2);
}

decimal FibonacciIteration(int n)
{
    fIte++;
    decimal result = 1;
    decimal f0 = 1;
    decimal f1 = 1;
    for (int i = 2; i <= n; i++)
    {
        result = f0 + f1;

        f0 = f1;
        f1 = result;
        fIte++;
    }
    return result;
}
DateTime dt = DateTime.Now;
//Console.ReadLine();
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciIteration({n}) = {FibonacciIteration(n)} fIte = {fIte.ToString("### ### ###"), -15}");
    fIte = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
Console.WriteLine();
//Console.ReadLine();
dt = DateTime.Now;
for (int n = 10; n < 40; n++)
{
    Console.WriteLine($"FibonacciRecursion({n}) = {FibonacciRecursion(n)} fRec = {fRec.ToString("### ### ###"), -15}");
    fRec = 0;
}
System.Console.WriteLine((DateTime.Now - dt).TotalMilliseconds);
//Console.ReadLine();
