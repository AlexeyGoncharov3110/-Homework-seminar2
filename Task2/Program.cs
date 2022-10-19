Console.WriteLine(" Введите целое число");

int number = Convert.ToInt32(Console.ReadLine());
int number1 = number;
int count = 0;
while (number1 > 0)
{
    number1 /= 10;
    count++;
}
int[] array = new int[count];

if (number < 100)
{
    Console.WriteLine("Третьей цифры нет");
}
else
{
    for (int i = array.Length - 1; i >= 0; i--)
    {
        int lastValue = number % 10;
        array[i] = lastValue;
        number = number / 10;
    }
    Console.WriteLine(array[2]);
}


