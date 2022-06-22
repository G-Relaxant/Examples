/*string Method(int count, string text)
{
    string result = string.Empty;
    for (int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}

string res = Method(10, "z");
Console.WriteLine(res);*/






/*for (int i = 2; i <= 10; i++)
{
    for (int j = 2; j <= 10; j++)
    {
        Console.WriteLine($"{i} * {j} = {i * j}");
    }
    Console.WriteLine();
}*/







/*string text = "Матрицы TN хоть и быстрые, но по качеству "
+ "изображения и цветопередаче самые худшие, а хотя бы сколько"
+ " то хорошие стоят очень дорого. Матрицы IPS имеют очень "
+ "хорошую цветопередачу, но плохую передачу чёрного цвета и "
+ "среднюю скорость. Матрицы VA - имеют среднюю скорость,"
+ " но в среднем ниже, чем у IPS, зато дешевле, при этом у VA "
+ "матриц хорошая цветопередача и хороший чёрный цвет, из "
+ "минусов у VA матриц очень низкая скорость(то есть очень "
+ "высокая задержка) при смене цвета с чёрного на светлый. "
+ "Самыми лучшими по всем характеристикам являются LED матрицы"
+ ", у которых всё прекрасно кроме одного - очень высокой цены"
+ ", имеет смысл выбирать монитор с LED матрицей в том случае,"
+ " если нужна очень низкая задержка(то есть высокая скорость"
+ " матрицы) и при этом очень насыщенное и красивое изображение"
+ ", при этом если не устраивают лучшие TN мониторы";

string Replace(string text, char oldValue, char newValue)
{
    string result = String.Empty;
    int lenght = text.Length;
    for (int i = 0; i < lenght; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }
    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);

Console.WriteLine();

newText = Replace(newText, 'к', 'К');
newText = Replace(newText, 'с', 'С');
newText = Replace(newText, 'р', 'Р');
Console.WriteLine(newText);*/









// min to max
/*int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] < array[minPosition]) minPosition = j;
        }

        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);*/










// homework max to min
int[] arr = { 1, 5, 4, 3, 2, 6, 7, 1, 1, 9, 8 };

void PrintArray(int[] array)
{
    int count = array.Length;
    for (int i = 0; i < count; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int maxPosition = i;

        for (int j = i + 1; j < array.Length; j++)
        {
            if(array[j] > array[maxPosition]) maxPosition = j;
        }

        int temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);