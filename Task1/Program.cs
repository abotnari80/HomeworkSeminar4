int degree(int num1, int num2)
{
    int result = num1;
    for (int i = 1; i < num2; i++)
    {
        result = result * num1;
    }
    return result;
}

System.Console.WriteLine("Введите число A ");
int A = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите число B ");
int B = Convert.ToInt32(Console.ReadLine());
int answer = degree(A,B);
System.Console.WriteLine($"Ответ {answer}");
