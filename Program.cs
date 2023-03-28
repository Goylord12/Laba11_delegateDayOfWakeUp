using System;

class Program
{
    delegate string GetNextDayOfWeek();

    static void Main()
    {
      
        int currentDayIndex = (int)DateTime.Today.DayOfWeek;
        if (currentDayIndex != 1) currentDayIndex -= 1;

        GetNextDayOfWeek getNextDay = () =>
        {
            currentDayIndex = (currentDayIndex + 1);
            switch (currentDayIndex)
            {
                case 1:
                    return "Понедельник";
                case 2:
                    return "Вторник";
                case 3:
                    return "Среда";
                case 4:
                    return "Четверг";
                case 5:
                    return "Пятница";
                case 6:
                    return "Суббота";
                case 7:
                    return "Воскресенье";
                default:
                    currentDayIndex = 1;
                    return "Понедельник";
            }

        };

        for (int i = 0; i < 14; i++)
        {
            Console.WriteLine(getNextDay());
        }
    }
}
