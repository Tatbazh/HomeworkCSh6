// Задача со звездочкой. Напишите программу, которая
// реализует обход введенного двумерного массива,
// начиная с крайнего нижнего левого элемента против
// часовой стрелки.
// 1 2 3
// 4 5 6 -> 7 8 9 6 3 2 1 4 5
// 7 8 9
void RandomArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(1, 10);
    }
}
int[,] matrix = new int[3, 3];

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write($"{table[i, j]}");
        }
        Console.WriteLine();
    }
}
RandomArray(matrix);
PrintArray(matrix); // заполнили массив случайными числами, вывели все в консоль

int[] FillImage(int row, int col)
{    
    if (array2[row, col] == true)
    {
        array2[row, col] = array1[i, j];
        FillImage(row, col + 1); // здесь метод сам себя вызывает
        FillImage(row - 1, col);
        FillImage(row, col - 1);
        FillImage(row - 1, col);
    }
    return arra1;
}

FillImage(2, 1); // [2,1] - начальная точка
int[,] newArray = FillImage;
Console.WriteLine();