// Задача 41: Пользователь вводит 
// с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.

// 0, 7, 8, -2, -2 -> 2

// 1, -7, 567, 89, 223-> 3

Console.Write("Введите количество чисел в массиве: ");
int numberOfNumbers = Convert.ToInt32(Console.ReadLine());

if (numberOfNumbers > 0)
{
    int[] array = CreateArray(numberOfNumbers);
    PrintArray(array);
    int countPositiveNumbers = CountPositiveNumbers(array);
    Console.WriteLine($"Количество положительных чисел в массиве: {countPositiveNumbers}");
}
else Console.WriteLine("Вы ввели ненатуральное число");

int[] CreateArray(int size)
{
    int[] newArray = new int[size];
    for (int i = 0; i < newArray.Length; i++)
    {
        Console.Write($"Введите число: ");
        newArray[i] = Convert.ToInt32(Console.ReadLine());
    }
    return newArray;
}

int CountPositiveNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0) count++;
    }
    return count;
}

void PrintArray(int[] printArray)
{
    Console.Write("[");
    for (int i = 0; i < printArray.Length; i++)
    {
        if (i < printArray.Length - 1) Console.Write($"{printArray[i]}, ");
        else Console.WriteLine($"{printArray[i]}]");
    }
}