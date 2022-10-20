// Задача 43. Напишите программу, которая найдёт точку
// пересечения двух прямых, заданных уравнениями 
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются
// пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
Console.Write("Введите значения b1, k1, b2, k2 через запятую и пробел: ");
string arrayNumbers = Console.ReadLine()!;

int[] GetArrayFromString(string stringArray)
{
    string[] StringNumbers = stringArray.Split(", ", StringSplitOptions.RemoveEmptyEntries);
    int[] arrayNew = new int[StringNumbers.Length];
    for (int i = 0; i < StringNumbers.Length; i++)
    {
        arrayNew[i] = int.Parse(StringNumbers[i]);
    }
    return arrayNew;
}

void FormulaLineIntersection(int[] arrayNumbers)
{
    int B1 = arrayNumbers[0]; int K1 = arrayNumbers[1]; int B2 = arrayNumbers[2]; int K2 = arrayNumbers[3];
    double X = 0; double Y = 0;      // X и Y высчитываем из формул: Y = (K1 * X + B1); Y = (K2 * X + B2);
    
    X = (double)(B1 - B2) / (K2 - K1);  
    Y = K1 * X + B1;
    if ((Y - K1 * X - B1 != 0) && (Y - K2 * X - B2 != 0))  Console.WriteLine("Прямые параллельны");
    else Console.WriteLine($"Прямые пересекаются в точке ({X}, {Y})");
}
int[] valueArray = GetArrayFromString(arrayNumbers);
Console.WriteLine($"{String.Join(" ", valueArray)}");  // выводим массив, элементы к-го разделены пробелом
FormulaLineIntersection(valueArray);