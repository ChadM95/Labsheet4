namespace Ex4;

class TimeConverter
{
    //Methods...
    //Main, InputSeconds, DetermineHours, DetermineMinutes, Display

    static void Main(string[] args)
    {
        Console.WriteLine("Time Converter");

        int totalSeconds, hours, remainingSeconds, minutes, finalSeconds ;

        totalSeconds = InputSeconds();

        hours = DetermineHours(totalSeconds);

        remainingSeconds = totalSeconds - (hours * 3600 );

        minutes = DetermineMinutes(remainingSeconds);

        finalSeconds = remainingSeconds - (minutes * 60);

        Display(hours, minutes, finalSeconds);

        Console.WriteLine();

        Console.ReadLine();
    }

    static int InputSeconds()
    {
        Console.Write("Total Seconds: ");
        return int.Parse(Console.ReadLine());
    }

    static int DetermineHours(int totalSeconds)
    {
        return totalSeconds / 60 / 60;
    }

    static int DetermineMinutes(int remainingSeconds)
    {
        return remainingSeconds / 60;
    }

    static void Display(int hours, int minutes, int finalSeconds)
    {
        Console.WriteLine($"hours:    {hours}");
        Console.WriteLine($"minutes:  {minutes}");
        Console.WriteLine($"seconds:  {finalSeconds}");
    }


}




