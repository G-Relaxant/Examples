// Равнобедренный треугольник Паскаля от Сергея Камянецкого
/*
int row = 9;
const int cellWidth = 3;
int[,] triangle = new int[row, row];
FillTriangle();
PrintTriangle();

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
            triangle[i, j] = 
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}
void PrintTriangle()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if(triangle[i, j] != 0)
                Console.Write($"{triangle[i, j],cellWidth}");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}
*/



// Треугольник фрактал от Сергея Камянецкого, необходимо выбрать 5-6 размер шрифта для терминала

int row = 128;
const int cellWidth = 1;
int[,] triangle = new int[row, row];
FillTriangle();
MagicTriangle();

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
            triangle[i, j] = 
                triangle[i - 1, j - 1] + triangle[i - 1, j];
        }
    }
}
void MagicTriangle()
{
    int col = cellWidth * row;
    for(int i = 0; i < row; i++)
    {
        for(int j = 0; j <= i; j++)
        {
            Console.SetCursorPosition(col, i + 1);
            if(triangle[i, j] % 2 != 0)
                Console.Write("*");
            col += cellWidth * 2;
        }
        col = cellWidth * row - cellWidth * (i + 1);
        Console.WriteLine();
    }
}