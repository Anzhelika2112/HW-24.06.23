// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

int[] array = GetArray(size, 100, 999);
Console.WriteLine(String.Join(" ", array));

int EvenNumber = GetEvenNumber(array);
Console.WriteLine($"Массив [{String.Join(" ", array)}], чётных чисел {EvenNumber}");

int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber))
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int GetEvenNumber(int[] arr)
{
    int GetEvenNumber = 0;
    foreach (int el in arr)
    {
        if (el % 2 == 0) GetEvenNumber ++;
    }
    return GetEvenNumber;
}