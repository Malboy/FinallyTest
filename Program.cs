int N = 0;
Console.Write("Введите размерность массива: ");
UserInputNum(ref N);

string[] array1 = new string[N];
string[] array2 = new string[array1.Length];

FillFirstArray(array1);
PrintArray(array1);
FillSecondArray(array1, array2);
PrintArray(array2);




static void UserInputNum(ref int N)
{
    try
    {
        N = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Не верно введено значение {exc.Message}");
        return;
    }
    
}

void FillFirstArray(string[] array1)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"array1[{i}]= ");
        array1[i] = Console.ReadLine()?? "";
    }
}

void FillSecondArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
