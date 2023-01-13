string[] array = new string[]{"Арбуз","12","Самовар", "Бур"};
string[] arrayTwo = new string[array.Length];
TwoSymbol(array, arrayTwo);

void TwoSymbol(string[] array, string[] arrayTwo)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            arrayTwo[i] += array[i];
        }
        Console.Write(arrayTwo[i] + " ");
    }
    Console.Write("]");
}
