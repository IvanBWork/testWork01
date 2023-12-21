string[] Input(string text)
{
    Console.Write(text);
    int elements = Convert.ToInt32(Console.ReadLine());
    string[] array = new string[elements];

    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"Введите {i + 1} элемент массива: ");
        array[i] = Console.ReadLine()!;
    } 
    return array;
}

string[] CorrectedUserArray(string[] userArray)
{
    int lengths = 3;

    int n = 0;

    string[] correctedArray = new string[userArray.Length];

    for (int i = 0; i < userArray.Length;i++)
    {
        if(userArray[i].Length <= lengths)
        {
            correctedArray[n] = userArray[i];
            n++;
        }
    }

    return correctedArray;
}

void PrintArray(string[] array, string text)
{
    string result = string.Join(", ", array);
    Console.WriteLine(text + result);
}

string[] array = Input("Введите кол-во элементов массива: ");
Console.WriteLine();
PrintArray(array, "Ваш массив: ");
Console.WriteLine();
var result = CorrectedUserArray(array).Where(x => !string.IsNullOrEmpty(x)).ToArray();
PrintArray(result, "Ваш итоговый массив: ");