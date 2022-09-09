// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.

int Sizing(string[] sourceArray, int lengthStrg)
{
    int count = 0;

    for (int i = 0; i < sourceArray.Length; i++)
    {
        if (sourceArray[i].Length <= lengthStrg) count++;
    }
    return count;
}

void PrintArray(string[] array)
{
    if (array.Length == 0) Console.WriteLine("Array is empty.");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write((i == array.Length - 1) ? $"{array[i]}" : $"{array[i]}, ");
    }
}

void SmallElements(string[] sourceArray, string[] newArray, int lengthStrg)
{
    int i = 0, j = 0;

    while (i < newArray.Length)
    {
        while (j < sourceArray.Length)
        {
            if (sourceArray[j].Length <= lengthStrg)
            {
                newArray[i] = sourceArray[j];
                i++;
                j++;
            }
            else j++;
        }
    }
}

void Start()
{
    string[] letter = { "}:->", "4015", "Tnx", "clear", "GB", "22", "Moscow", "week", "<3", "happiness", "Eminem" };
    int sizeString = 3;

    int meter = Sizing(letter, sizeString);
    string[] message = new string[meter];

    SmallElements(letter, message, sizeString);
    PrintArray(message);
}

Start();