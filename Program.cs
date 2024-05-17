void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    string[] array = GenerateArray(arraySize);
    PrintArray(array);
    PrintArray(filterString(array));
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

string[] filterString(string[] array)
{
    string[] temArray = new string[counting(array)];
    int count2 = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            temArray[count2] = array[i];
            count2++;
        }
    }
    return temArray;
}

int counting(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            count++;
        }

    }
    return count;
}

Main();
