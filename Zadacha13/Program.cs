void zadacha13()
{
    int number1=new Random().Next(0, 10000000);
       Console.WriteLine($"число:{number1}");
    if (number1<100)
    {
        Console.WriteLine("третьей цифры нет");
    }
    else
    {
        while (number1>999)
        {
            number1=number1/10;
        }
        Console.WriteLine($"третья цифра числа:{number1%10} ");
    }
    
}

zadacha13();