// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int length = InputLength();
int[] array = FullArrayByRandomPositiveNumbers(length);
PrintArray(array);
int amountPositiveNumbers = GetAmountPositiveNumbers(array);
Console.WriteLine(amountPositiveNumbers);

int InputLength()
{
    Console.WriteLine("Введите число соответствующеедлине массива");
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

int[]FullArrayByRandomPositiveNumbers(int length)
{
    Random random = new Random();
    int[] array = new int [length];
    for (int i = 0; i < length; i++)
    {
        array [i] = random.Next (100,1000);
    }
    return array;
}

void PrintArray(int [] array)
{
    string message = string.Join(", ", array);
    Console.WriteLine(message);
}

int GetAmountPositiveNumbers(int[] array)
{
    int count = 0;
    for (int i = 0; i < length; i++)
    {        
        if (array[i] % 2 == 0)
        {
            count+=1;
        }
    }
    return count;
}
