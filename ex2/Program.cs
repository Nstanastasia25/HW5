// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

int[] array = { 203, 511, 516, 612 };

void PrintNew(int[] array)
{
    int lenght = array.Length;
    for (int i = 0; i < lenght; i++)
    {
        Console.Write($" {array[i]}");
    }
}

int[] createArray(int elements) //Возвращает массив с рандомными числами
{
    //int num = new Random().Next(10,50);
    int[] arr = new int[elements];
    int i = 0;
    while (i < arr.Length)
    {
        arr[i] = new Random().Next(0, 100);
        i++;
    }
    return arr;
}

int SumOfUneven(int[] numbers)  //Возвращает сумму элементов, находящихся на нечетных позициях(с нечетн индексом)
{
    int result = 0;
    for (int i = 0; i < numbers.Length; i++)
        if (i % 2 != 0) result += numbers[i];
    return result;
}
int[] test = createArray(5);
PrintNew(test);
Console.WriteLine();
Console.WriteLine(SumOfUneven(test));
