// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

Console.Clear();

int size = GetNumberFromUser("Введите размер массива: ", "Ошибка ввода!");

double[] array = GetArray(size, 100, 1000);
Console.WriteLine($"Массив {String.Join(" ", array)}");


double MinNumber = GetMinNumber(array); 
double MaxNumber = GetMaxNumber(array);

Console.WriteLine($"Максимальное значение = {MaxNumber}, минимальное значение = {MinNumber}");


double RazNumbers = GetRazNumbers(MaxNumber, MinNumber); 

Console.WriteLine($"Разница между максимальным и минимальным элементом массива -> {RazNumbers}");

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


double[] GetArray(int size, int minValue, int maxValue)
{
    double[] res = new double[size];
    for(int i = 0; i < size; i++)
        {
            res[i] = Convert.ToDouble(new Random().Next(minValue,maxValue)) / 100;
        }
    return res;
}


double GetMinNumber(double[] arr)
{
    double min = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return min;
}

double GetMaxNumber(double[] arr)
{
    double max = array[0];
    for (int i = 0; i < size; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
    }
    return max;
}

double GetRazNumbers(double MaxNumber, double MinNumber)
{
    RazNumbers = MaxNumber - MinNumber; 
    return RazNumbers;
}