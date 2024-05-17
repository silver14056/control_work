void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    string[] array = GenerateArray(arraySize);
    PrintArray(array);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

void PrintArray(string[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

string[] GenerateArray(int size)
{
    string[] tempArray = new string[size];

    for (int i = 0; i < size; ++i)
    {
        tempArray[i] = "string element";
    }
    return tempArray;
}

Main();
