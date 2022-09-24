void zadacha10()
{
    int number1=new Random().Next(100, 1000);
    Console.WriteLine($"число:{number1}");
    Console.WriteLine($"вторая цифра числа:{number1/10%10} ");
}

zadacha10();
