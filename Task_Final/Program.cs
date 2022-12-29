// **Задача**: Написать программу, которая из имеющегося массива строк формирует массив из строк, 
//длина которых меньше либо равна 3 символа.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массива

 string[] array = new string[] { "Мы", "еще", "не", "закончили", "учебу",  "как", "Вы" };

PrintArray(array);
CheckArray(array);
Console.Write("результат-> ");
PrintArray(CheckArray(array));

void PrintArray(string[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}

string[] CheckArray(string[] array)
{
    int count = 0;
    int index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length < 4) count++;
    }
    string[] finalArray = new string[count];
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length < 4)
        {
            finalArray[index] = array[j];
            index++;
        }
    }
    return finalArray;
}
