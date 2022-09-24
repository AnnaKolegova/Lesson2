void zadacha15()
{
    int number1=new Random().Next(1,8);
       Console.WriteLine($"число:{number1}");
    if (number1<6)
    {
        Console.WriteLine("рабочий день");
    }
    else
    {
       
        Console.WriteLine("выходной день");
    }
    
}

zadacha15();