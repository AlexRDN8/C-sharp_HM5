// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. 
// Не использовать готовые методы Min и Max
// [3 7 22 2 78] -> 76

double[] array = new double []{3, 7, 22, 2, 78};
double min = GetMin(array);
double max = GetMax(array);
double difference = max - min;
Console.WriteLine(difference);

double GetMin(double[] array)
{
    int index = 0;
    double min = array[index];
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i]< min)
        {
            min = array[i];
        }
    }
    return min;
}

double GetMax(double[] array)
{
    int index = 0;
    double max = array[index];
    for (int i = 0; i < array.Length; i++)
    {        
        if (array[i]> max)
        {
            max = array[i];
        }
    }
    return max;
}

// double GetDifOfMinAndMax(double[] array)
// {
//     int index = 0;
//     double min = array[index];
//     double max = array[index];
//     for (int i = 0; i < array.Length; i++)
//     {        
//         if (array[i]< min)
//         {
//             min = array[i];
//         }
//         if (array[i]> max)
//         {
//             max = array[i];
//         }
//     }
//     double dif = max - min;
//     return dif;
// }