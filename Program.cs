// Написать программу, которая из имеющегося массива строк формирует новый массив
// из строк, длина которых меньше, либо равна 3 символам.
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте
// выполнения алгоритма.
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

Console.WriteLine("Программа из имеющегося массива строк формирует массив строк, длина");
Console.WriteLine("которых меньше, либо равна 3-м символам (либо отдельно заданному значению).");

Console.WriteLine("Введите размер массива строк: ");
int arraySize = Convert.ToInt32(Console.ReadLine()); // задаем длину массива
string[] array = new string[arraySize];   // либо указать вместо [arraySize] длину массива

string[] FillArray(string[] arr, string str)    // заполняем массив элементами - строками
{
    for (int i = 0; i < arr.Length; i++)
    {
            Console.Write("arr[{0}] = ", i);
            arr[i] = Console.ReadLine();
            Console.WriteLine(arr[i] + "; ");
    }
    return arr;
}

void PrintArray(string[] arr)   // вывод полученного массива
{
    Console.Write("[");
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write("\"" + arr[i] + "\"");
        if (i != arr.Length - 1)
        Console.Write(", ");
    }
    Console.Write("]");
}

string[] arr = new string[arraySize];
FillArray(arr, "");
Console.WriteLine("\n" + "Исходный массив строк:");
PrintArray(arr);
Console.WriteLine();

// вариант 1
Console.WriteLine("\n" + "Введите количество символов, ограничивающих строку:");
int stringLimit = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("\n" + "Массив строк длиной до " + stringLimit + "-х символов:");
Console.Write("[");
for (int i = 0; i < arr.Length; i++)
{    
    if (arr[i].Length <= stringLimit)
    {
        Console.Write("\"" + arr[i] + "\"");
        if (i != arr.Length - 1)
        Console.Write(", ");
    }
    if (arr[i].Length > stringLimit)
    {
        Console.Write("");
    }
}
Console.WriteLine("]");
Console.ReadKey();
