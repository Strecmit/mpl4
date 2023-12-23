Console.Write("Введите длину массива: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] arr = CreateArr(size);
int[] invers = CreateInversArray(arr);
Console.Write("Массив прямой:   ");
PrintArray(arr);

arr = CreateInversArray(arr);
Console.Write("Массив обратный: ");
PrintArray(arr);

//-----------------------------------
int[] CreateArr(int arrSize)
{
    int[] myArray = new int[arrSize];
    Random rand = new Random();
    for (int i = 0; i < arrSize; i++)
    {
        myArray[i] = rand.Next(1, 10);        
    }
    return myArray;
}
//-------------------------------------
int[] CreateInversArray(int[] arr)
{
    int[] invArr = new int[arr.Length];
    int n = arr.Length - 1;
    for (int i = 0; i < arr.Length; i++)
    {       
       invArr [i] = arr[n]; n--;
    }
    return invArr;
}
//-------------------------------------
void PrintArray(int[] array)
{ Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i == (array.Length-1)) Console.Write($"{array[i]}");
        else Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}