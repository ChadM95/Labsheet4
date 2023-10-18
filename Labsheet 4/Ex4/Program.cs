namespace Ex4;

class TimeConverter
{
    //Main, InputSeconds, DetermineHours, DetermineRemainingSeconds
    //DetermineNumberMinutes, Display

    static void Main(string[] args)
    {
        Console.WriteLine("Time Converter");

        int totalSeconds, hours ;

        totalSeconds = InputSeconds();

        hours = DetermineHours(totalSeconds);

        Display(hours);

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


    static void Display(int hours)
    {
        Console.WriteLine(hours);
    }


}




