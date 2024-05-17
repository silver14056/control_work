void Main()
{
    int arraySize = ReadInt("Введите размер массива: ");
    string[] array = GenerateArray(arraySize);
}

int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
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
