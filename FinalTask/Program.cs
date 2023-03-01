
// Задача: Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры, либо задать на старте 
// выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

// Примеры:
// ["hello", "2", "world", ":-)"] -> ["2", ":-)"]
// ["1234", "1567", "-2", "computer science"] -> [ "-2" ]
// ["Russia", "Denmark", "Kazan"] -> [ ]

string[] array = new string[] {"it", "hello", "5674", "is", "world", "ok", "12598"};
string[] newlist = new string[array.Length];
void NewArray(string[] array, string[] newlist)
{
    int count = 0;
    int i=0;
    while (i < array.Length )
    {
       if(array[i].Length < 4 & array[i].Length >0)
       {
        newlist[count] = array[i]; 
        count++;
       }
       i++;
    }
}
void PrintArray(string[] array)
{

    Console.Write($"->[ {array[0]}");
    for (int i = 1; i < array.Length; i++)
    {
        Console.Write($" {array[i]}");
    }
    Console.WriteLine("]");
}
NewArray(array, newlist);
PrintArray(newlist);