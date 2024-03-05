// Написать программу, которая из имеющегося массива строк формирует новый массив из строк, 
// длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, либо задать на старте выполнения алгоритма.
string [] CreateNewMassive(string [] str)
{
    for (int i = 0; i < str.Length; i++)
    {
        Console.WriteLine("Введите строку: ");
        string newString = Console.ReadLine()!;
        str[i] = newString;
    }
    return str;
}