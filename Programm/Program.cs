string[] array = new string[]{"1231", "gdfgdg", "33", "World", "gg"};
string[] arrayTwo = new string[array.Length];
int wordSize = 3;
PoiskSlov(array, arrayTwo);
PrintArray(arrayTwo);
void PoiskSlov(string[] array, string[] arrayTwo)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= wordSize)
        {
            arrayTwo[count] = array[i];
            count++;
        }
    }
}

void PrintArray(string[] arrayTwo)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(arrayTwo[i] + " ");
    }
}

