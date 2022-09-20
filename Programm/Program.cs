string[] stringArray = {"sgvsg", "SVGS", "MJ1", "12", "qwerty", "as", "k00", "-100"};
string[] ResultArray(string[] array){
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            j++;
        }
    }
    string[] sortedArray = new string[j];
    j=0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            sortedArray[j] = array[i];
            j++;
        }
    }
    return sortedArray;
}
void PrintArray(string[] array){
    if (array.Length != 0)
    {
    System.Console.WriteLine($"Массив: ({string.Join(", ", array)})");    
    }
    else
    {
        System.Console.WriteLine("Результирующий массив пуст");
    }
    
}
PrintArray(stringArray);
PrintArray(ResultArray(stringArray));