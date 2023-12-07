Console.Clear();

string[] arrayUser = new string[7] { "123", "qwerty", "dog", "free1", "5818q", "cat", ":-)" };
string[] arraynew = new string[arrayUser.Length];
Console.WriteLine($"Написать программу, которая из имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам: ");
Console.WriteLine();
CreateArrayThreeEl(arrayUser, arraynew);
PrintStrings(arrayUser);
PrintArray(arraynew);

void CreateArrayThreeEl(string[] arrayUser, string[] arraynew)
{
    int count = 0;
    for (int i = 0; i < arrayUser.Length; i++)
    {
        if (arrayUser[i].Length <= 3)
        {
            arraynew[count] = arrayUser[i];
            count++;
        }
    }
}
void PrintStrings(string[] stringsArray)
{
    Console.WriteLine();
    Console.WriteLine("Исходные значения: ");
    foreach (var str in stringsArray)
    {
        Console.Write($"{str} ");
    }
    Console.WriteLine();
}
void PrintArray(string[] array)
{
    Console.WriteLine();
    Console.WriteLine("Итоговые значения из 3 символов:");
    for (int i = 0; i < array.Length; i++)
    {

        Console.Write($"{array[i]} ");
    }

}
