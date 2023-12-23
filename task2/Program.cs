Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int count = 0;

int[] arr = CreateArr(size);
count = CountEvenDigit(arr);
PrintArray(arr);
Console.WriteLine($"\r\nКоличество чётных чисел в массиве равно {count}\r\n");

//---------------------------------
int CountEvenDigit(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]%2 == 0) sum ++;
    }
    return sum;
}

//----------------------------------
int[] CreateArr(int arrSize)
{
    int[] myArray = new int[arrSize];
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        myArray[i] = rand.Next(100, 1000);        
    }
    return myArray;
}
//-------------------------------------
void PrintArray(int[] array)
{ Console.Write("\r\nМассив [");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length-1)) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");

}