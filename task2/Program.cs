// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int length = InputLength();
int[] array = FullArrayByRandomNumbers(length);
PrintArray(array);
int sum = GetSumOfNumbersOnOddIndexes(array);
Console.WriteLine(sum);

int InputLength()
{
    Console.WriteLine("Введите число соответствующее длине массива");
    bool isNum = int.TryParse(Console.ReadLine(), out int length);
    if (isNum)
    {
        return length;
    }
    else
    {
        Console.WriteLine("Введено некорректное значение");
        return -1;
    }
}

int[]FullArrayByRandomNumbers(int length)
{
    Random random = new Random();
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = random.Next (-10,10); 
    }
    return array;
}

void PrintArray(int [] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine(message);
}

int GetSumOfNumbersOnOddIndexes(int[] array)
{
    int sum = 0;
    for (int i = 1; i < length; i+=2)
    {        
        sum = sum + array [i];
    }
    return sum;
}