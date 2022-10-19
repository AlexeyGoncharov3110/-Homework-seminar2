Console.WriteLine(" Введите число");

int number = Convert.ToInt32(Console.ReadLine());

int secondNumber = SecondNumber(number);

if(number>100 && number<1000)
{
Console.WriteLine(secondNumber);
}
else
{
    Console.WriteLine("Ошибка");
}

int SecondNumber(int number)
{
    int secondNumber = number /10 % 10;
    
    return secondNumber;
}
