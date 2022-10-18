
int randomNumber = GetRandomNumber(100, 1000);

int secondNumber = SecondNumber(randomNumber);

Console.WriteLine(randomNumber);

Console.WriteLine(secondNumber);

int GetRandomNumber(int minValue, int maxValue)

{
    Random random = new Random();
    int randomNumber = random.Next(minValue, maxValue);
    return randomNumber;
}
int SecondNumber(int randomNumber)
{
    int secondNumber = randomNumber /10 % 10;
    
    return secondNumber;
}