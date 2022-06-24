/*
int row = 3;
int column = 5;

string[,] table = new string[row, column];

// Пример логики массива для 2х строк и 5и столбцов, то есть string[,] table = new string[2, 5]
// table[0,0] table[0,1] table[0,2] table[0,3] table[0,4]
// table[1,0] table[1,1] table[1,2] table[1,3] table[1,4]

table[0,1] = "запись в ячейке";
table[1,2] = "запись в ячейке";
table[2,3] = "запись в ячейке";
table[1,4] = "запись в ячейке";
table[0,0] = "запись в ячейке";

for(int currow = 0; currow < row; currow++)
{
    for(int curcol = 0; curcol < column; curcol++)
    {
        Console.Write($"cell-{table[currow, curcol]}-");
    }
    Console.WriteLine("");
}
*/

/*
int row = 9;
int column = 9;

int[,] matrix = new int[row, column];

for (int currentRow = 0; currentRow < row; currentRow++)
{
    for(int currentColumn = 0; currentColumn < column; currentColumn++)
    {
        Console.Write($" {matrix[currentRow, currentColumn]} ");
    }
    Console.WriteLine("");
}
*/



/*
int row = 20;
int column = 22;

int[,] matrix = new int[row, column];

for (int currentRow = 0; currentRow < row; currentRow++)                
{
    for(int currentColumn = 0; currentColumn < column; currentColumn++)
    {
        if(currentRow > 5 && currentRow < row - 6)
        {
            matrix[currentRow,currentColumn] = 3;
        }
        if(currentColumn > 6 && currentColumn < column - 7)
        {
            matrix[currentRow,currentColumn] = 3;
        }
    }
}
for (int currentRow = 0; currentRow < row; currentRow++)
{
    for(int currentColumn = 0; currentColumn < column; currentColumn++)
    {
        Console.Write($" {matrix[currentRow, currentColumn]} ");
    }
    Console.WriteLine("");
}
*/



/*int[,] matrix = new int[9, 12];

for (int i = 0; i < matrix.GetLength(0); i++)           // Новая команда GetLength
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine("");
}*/




int[,] matrix = new int[9, 12];
PrintArray(matrix);
Console.WriteLine();
FillArray(matrix);
PrintArray(matrix);

void FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,10);
        }
    }
}

void PrintArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            Console.Write($" {a[i, j]} ");
        }
    Console.WriteLine("");
    }
}
