Console.WriteLine(" Введите число от 1 до 7 ");

int number = Convert.ToInt32(Console.ReadLine());

DayOfTheWeek(number);

bool DayOfTheWeek(int arg)
{
    if (arg > 5) return true;
    else return false;  
}

