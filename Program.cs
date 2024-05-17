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
        tempArray[i] = GenerateString(5);
    }
    return tempArray;
}

string GenerateString(int maxSize)
{
    Random rand = new Random();
    string str = "";
    int strLength = rand.Next(0, maxSize + 1);
    char symbol;
    for (int i = 0; i < strLength; i++)
    {
        symbol = (char)rand.Next(32, 126);
        str += symbol;
    }
    return str;


}

Main();
