// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

void print(int[] array) // создание массива
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}

void newArray(int[] array)
{
    for (int i = 0; i < 12; i++)
    {
        array[i] = new Random().Next(-100, 100);
    }
}

int[] array = new int[15];

int Max(int[] array)  // функция которая будет искать максимальный элемент
{
int max = array[0];  
    for (int i = 0; i < array.Count(); i++)
    {
        if (max < array[i])   
        {
            max = array[i]; 
        }
     }
     return max;
}

 int Min(int[] array)  // функция которая будет искать минимальный элемент
{
int min = array[0];  
    for (int i = 0; i < array.Count(); i++)
    {
        if (min > array[i])   
        {
            min = array[i]; 
        }
     }
     return min;
}

newArray(array);
print(array);
Console.WriteLine();
Console.WriteLine($"Максимальное число = {Max(array)}");
Console.WriteLine($"Минимальное число = {Min(array)}");