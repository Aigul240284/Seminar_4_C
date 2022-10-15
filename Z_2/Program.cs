// Напишите программу, которая принимает на вход число и 
//выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12
Console.Clear();
int A = GetNumberFromUser("Введите целое число A: ", "Ошибка ввода!");
int Sum = GetSumNumbers(A);
Console.WriteLine($"{A}-> {Sum}");


int GetNumberFromUser(string message, string errorMessage)
{
    while (true)
    {
        Console.Write(message);
        bool isCorrect = int.TryParse(Console.ReadLine(), out int userNumber);
        if (isCorrect)
            return userNumber;
        Console.WriteLine(errorMessage);
    }
}


int GetSumNumbers(int A)
{
    int sum = A % 10;
    while (A > 0)
    {
        A = A / 10;
        sum += A % 10;
        A--;
    }
    return sum;
}
