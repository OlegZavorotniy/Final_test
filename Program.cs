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
string [] ResultMassive(string [] str2)
{
    int LenNewMass = 0;
    for (int j = 0; j < str2.Length; j++)
    {
        if (str2[j].Length <= 3)
        {
            LenNewMass++;
        }
    }
    string [] resultString = new string [LenNewMass];
    int k = 0;
        for (int i = 0; i < str2.Length; i++)
    {
        if (str2[i].Length <= 3)
        {
            resultString[k] = str2[i];
            k++;
        }
    }
    return resultString;

}
