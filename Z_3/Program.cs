// Напишите программу, которая задаёт массив из 
//8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = GetArray(8);
PrintArray(array);
Console.WriteLine();
Console.Write($"\n{array[0]},{array[1]},{array[2]},{array[3]},{array[4]}->[{array[0]},{array[1]},{array[2]},{array[3]},{array[4]}]");
Console.WriteLine();
Console.Write($"\n{array[5]},{array[6]},{array[7]}->[{array[5]},{array[6]},{array[7]}]");




/////////////////////////////////////////////////
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array [i]} ");
    }
}

int[] GetArray(int size)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(1, 99);
    }

    return res;
}