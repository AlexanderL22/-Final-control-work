//Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
//длина которых меньше, либо равна 3 символам. Первоначальный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями,
// лучше обойтись исключительно массивами.

using static System.Console;
using System.Linq;
Clear();

WriteLine ("Задача: Написать программу, которая из имеющегося массива строк формирует новый массив из строк,длина которых меньше, либо равна 3 символам.");

string[] M;
WriteLine("Введите массив строк через пробел");
string stroka = Console.ReadLine();
M = stroka.Split(' ');
var result = new string[M .Length];
var realSize = 0;
foreach (var value in M )
{
    if (value.Length <= 3)
    {
        result[realSize] = value;
        realSize++;
       
    }
}
WriteLine(string.Join(Environment.NewLine, result, 0, realSize));
Console.ReadKey(true);