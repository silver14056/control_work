void Main()
{
    // Запрашиваем размер массива
    int arraySize = ReadInt("Введите размер массива: ");
    // Генерируем массив
    string[] array = GenerateArray(arraySize);
    // Выводим сгенерированный массив в консоль
    PrintArray(array);
    // Выводим в консоль отфильтрованный массив
    PrintArray(filterString(array));
}

//Запрашиваем у пользователя и получаем из консоли размер массива
int ReadInt(string msg)
{
    Console.Write(msg);
    return Convert.ToInt32(Console.ReadLine());
}

// Вывод массива в консоль
void PrintArray(string[] arrayForPrint)
{
    System.Console.WriteLine("[" + string.Join(", ", arrayForPrint) + "]");
}

// Генерируем массив заданного размера
string[] GenerateArray(int size)
{
    string[] tempArray = new string[size];

    for (int i = 0; i < size; ++i)
    {
        // Заполняем сгенерированными строками длиной 5
        tempArray[i] = GenerateString(5);
    }
    return tempArray;
}

// Генерируем строки
string GenerateString(int maxSize)
{
    Random rand = new Random();
    string str = "";
    int strLength = rand.Next(0, maxSize + 1);
    char symbol;

    // Составляем строку из символов по коду ASCII
    for (int i = 0; i < strLength; i++)
    {
        symbol = (char)rand.Next(32, 126);
        str += symbol;
    }
    return str;
}

// Фильтруем массив согласно задания и выдаем новый согласно условию задачи
string[] filterString(string[] array)
{
    // Создаем новый массив, размер котороого равен колличеству элеметов отвечающих условию задачи
    string[] tempArray = new string[counting(array)];

    // Переносим необходимые элементы в новый массив
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArray[count] = array[i];
            count++;
        }
    }
    return tempArray;
}

// Подсчёт элементов отвечающих условию задачи
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
