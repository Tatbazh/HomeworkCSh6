// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3
Console.Write("Введите массив из любых чисел через запятую и пробел: ");
string numb = Console.ReadLine()!;

int[] GetArrayFromString(string stringArray) //переводим string в int
{
    string[] strNumbers = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);//вырезаем из строки ", "
    int[] intArray = new int[strNumbers.Length];
    for (int i = 0; i < strNumbers.Length; i++)
    {
        intArray[i] = int.Parse(strNumbers[i]); // заменяем эл-т из строки на int-ый элемент в новом массиве
    }
    return intArray;
}

int PositivCount(int[] arrayN) // подсчет элементов массива болше 0
{
    int[] array = new int[arrayN.Length];
    int count = 0;
    foreach (int element in arrayN)
    {
        if (element > 0)
            count += 1;
    }
    return count;
}

int[] newArray = GetArrayFromString(numb);

int positivNumb = PositivCount(newArray);
Console.WriteLine($"в массиве положительных чисел больше 0:   {positivNumb}");