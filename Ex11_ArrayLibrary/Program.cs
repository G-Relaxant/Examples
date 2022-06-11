void FillArray(int[] shablonmassiv)              //Воид метод ничего не возвращает из функции(СОЗДАЁТ ШАБЛОН)
{
    int lenght = shablonmassiv.Length;
    int index = 0;
    while (index < lenght)
    {
        shablonmassiv[index] = new Random().Next(1, 10);
        index++;
    }
}


void PrintArray(int[] shablonmassiv2)             //Воид метод ничего не возвращает из функции(СОЗДАЁТ ШАБЛОН)
{
    int count = shablonmassiv2.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(shablonmassiv2[position]);
        position++;
    }
}

int[] array = new int[10];   //ДОСЛОВНО - СОЗДАЙ НОВЫЙ МАССИВ, В КОТОРОМ БУДЕТ 10 ЭЛЕМЕНТОВ

FillArray(array); //МЕТОД(ФУНКЦИЯ) КОТОРЫЙ ЗАПОЛНИЛ МАССИВ ДЛЯ ПЕЧАТИ(СЛЕДУЮЩАЯ СТРОКА)
PrintArray(array);