int sum(int A)
{     
    int result = 0;
    for (int i = A; i > 0; i = i / 10)
    {
        result = result + (A % 10);
        A = A / 10;
    }
    return result;
}

System.Console.WriteLine("Введите число ");
int value = Convert.ToInt32(Console.ReadLine());
int answer = sum(value);
System.Console.WriteLine($"Сумма: {answer}");