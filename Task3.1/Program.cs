Console.WriteLine(" Введите число от 1 до 7 ");

int number = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(number);

bool DayOfTheWeek(int arg)
{
    return number == 6 | number == 7;
}