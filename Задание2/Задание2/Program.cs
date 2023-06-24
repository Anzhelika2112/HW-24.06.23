// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");
int minValue = GetNumberFromUser1("Введите минимальное значение: ", "Ошибка ввода!");
int maxValue = GetNumberFromUser2("Введите максимальное значение: ", "Ошибка ввода!");

int[] array = GetArray(size, minValue, maxValue);
Console.WriteLine(String.Join(" ", array));

int SumOddIndexNumbers = GetSumOddIndexNumbers(array); 
Console.WriteLine($"Массив [{String.Join(" ", array)}], сумма элементов, стоящих на нечётных позициях = {SumOddIndexNumbers}");


int GetNumberFromUser(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber1))
            return userNumber1;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberFromUser1(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber1))
            return userNumber1;
        Console.WriteLine(errorMessage);
    }
}

int GetNumberFromUser2(string message, string errorMessage)
{
    while(true)
    {
        Console.Write(message);
        if(int.TryParse(Console.ReadLine(), out int userNumber1))
            return userNumber1;
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




int GetSumOddIndexNumbers(int[] arr)
{
    int SumOddIndexNumbers = 0;
    for (int i = 0; i < size; i+=2)
    {
        SumOddIndexNumbers = SumOddIndexNumbers + array[i];
    }
    return SumOddIndexNumbers;
}