// Написать программу, которая из имеющегося массива строк
// формирует массив из строк, длина которых меньше либо равна 3 символа.

int Sizing(string[] array, int lengthStrg)
{
    int count = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= lengthStrg) count++;
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

void SmallElements(string[] array, string[] newArray, int lengthStrg)
{
    int i = 0, j = 0;

    while (i < newArray.Length)
    {
        while (j < array.Length)
        {
            if (array[j].Length <= lengthStrg)
            {
                newArray[i] = array[j];
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

    int count = Sizing(letter, sizeString);
    string[] message = new string[count];

    SmallElements(letter, message, sizeString);
    PrintArray(message);
}

Start();