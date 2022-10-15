// Напишите цикл, который принимает на вход два числа (A и B) и 
//возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)
//2, 4 -> 16
Console.Clear();
Console.Write("Введите число А: ");
int A = int.Parse(Console.ReadLine() ?? "");
Console.Write("Введите число B: ");
int B = int.Parse(Console.ReadLine() ?? "");
int exponentiate = Exponentiate(A, B);
Console.WriteLine($"{A}, {B} -> {exponentiate}");

/////////////////
int Exponentiate (int A, int B)
{
    int res = A;
    for (int i = 1; i < B; i++)
    
    {
        res = res*A;
    }
    return res;
}