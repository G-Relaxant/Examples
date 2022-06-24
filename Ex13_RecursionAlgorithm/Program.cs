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
        //Console.Write($" {matrix[currentRow, currentColumn]} ");
        if(matrix[currentRow, currentColumn] == 0)
            {
                Console.Write("   ");
            }
            else
            {
                Console.Write("(3)");
            }
    }
    Console.WriteLine("");
}




/*int[,] matrix = new int[9, 12];

for (int i = 0; i < matrix.GetLength(0); i++)           // Новая команда GetLength
{
    for(int j = 0; j < matrix.GetLength(1); j++)
    {
        Console.Write($" {matrix[i, j]} ");
    }
    Console.WriteLine("");
}*/



// SLADKIY PERSIK

int[,] Persik = new int[28, 37];
//Console.WriteLine();
//FillArray(matrix);
GoldenPeach(Persik);
//PrintArray(PersikPopka);
PrintPeach(Persik);

void FillArray(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < a.GetLength(1); j++)
        {
            Persik[i, j] = new Random().Next(1,10);
        }
    }
}

void GoldenPeach(int[,] a)
{
    int b = 3;
    //right line
    a[27, 19] = b;
    a[26, 20] = b;
    a[26, 21] = b;
    a[26, 22] = b;
    a[25, 23] = b;
    a[25, 24] = b;
    a[25, 25] = b;
    a[25, 26] = b;
    a[24, 27] = b;
    a[24, 28] = b;
    a[24, 29] = b;
    a[23, 30] = b;
    a[22, 31] = b;
    a[21, 32] = b;
    a[20, 32] = b;
    a[19, 33] = b;
    a[18, 34] = b;
    a[17, 34] = b;
    a[16, 35] = b;
    a[15, 35] = b;
    a[14, 36] = b;
    a[13, 36] = b;
    a[12, 36] = b;
    a[11, 36] = b;
    a[10, 36] = b;
    a[9, 35] = b;
    a[8, 35] = b;
    a[7, 35] = b;
    a[6, 34] = b;
    a[5, 34] = b;
    a[4, 33] = b;
    a[3, 33] = b;
    a[2, 32] = b;
    a[1, 31] = b;
    a[1, 30] = b;
    a[1, 29] = b;
    a[0, 28] = b;
    a[0, 28] = b;
    a[0, 27] = b;
    a[0, 26] = b;
    a[0, 25] = b;
    a[0, 24] = b;
    a[1, 23] = b;
    a[1, 22] = b;
    a[1, 21] = b;
    a[2, 20] = b;
    //left line
    a[26, 18] = b;
    a[26, 17] = b;
    a[26, 16] = b;
    a[25, 15] = b;
    a[25, 14] = b;
    a[25, 13] = b;
    a[24, 12] = b;
    a[24, 11] = b;
    a[24, 10] = b;
    a[23, 9] = b;
    a[23, 8] = b;
    a[22, 7] = b;
    a[22, 6] = b;
    a[21, 4] = b;
    a[21, 5] = b;
    a[20, 3] = b;
    a[19, 2] = b;
    a[18, 2] = b;
    a[17, 1] = b;
    a[16, 1] = b;
    a[15, 1] = b;
    a[14, 0] = b;
    a[13, 0] = b;
    a[12, 0] = b;
    a[11, 0] = b;
    a[10, 0] = b;
    a[9, 1] = b;
    a[8, 1] = b;
    a[7, 1] = b;
    a[6, 2] = b;
    a[5, 2] = b;
    a[4, 2] = b;
    a[3, 3] = b;
    a[2, 4] = b;
    a[2, 5] = b;
    a[1, 6] = b;
    a[1, 7] = b;
    a[1, 8] = b;
    a[1, 9] = b;
    a[0, 10] = b;
    a[0, 11] = b;
    a[0, 12] = b;
    a[0, 13] = b;
    a[0, 14] = b;
    a[0, 15] = b;
    a[1, 16] = b;
    a[1, 17] = b;
    a[1, 18] = b;
    a[1, 19] = b;
    // midle line
    a[25, 20] = b;
    a[24, 21] = b;
    a[23, 21] = b;
    a[22, 22] = b;
    a[21, 22] = b;
    a[20, 23] = b;
    a[19, 23] = b;
    a[18, 24] = b;
    a[17, 24] = b;
    a[16, 24] = b;
    a[15, 25] = b;
    a[14, 25] = b;
    a[13, 25] = b;
    a[12, 25] = b;
    a[11, 24] = b;
    a[10, 24] = b;
    a[9, 24] = b;
    a[8, 23] = b;
    a[7, 23] = b;
    a[6, 23] = b;
    a[5, 22] = b;
    a[4, 22] = b;
    a[3, 21] = b;
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

void PrintPeach(int[,] a)
{
    for (int i = 0; i < a.GetLength(0); i++)          
    {
        for(int j = 0; j < a.GetLength(1); j++)
        {
            //Console.Write($" {a[i, j]} ");
            if(a[i, j] == 0)
            {
                Console.Write("   ");
            }
            else
            {
                Console.Write("(3)");
            }
        }
    Console.WriteLine("");
    }
}
