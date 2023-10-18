namespace Ex4WithSolution;

class Program
{   //with keiths solution, slightly different, same result
    //tidier than my version as all computations are carried out within methods
    //difference - uses mod % to work out remaining seconds

    static void Main(string[] args)
    {
        int totalSeconds, hours, minutes, remainingSeconds;

        totalSeconds = InputSeconds();

        hours = DetermineHours(totalSeconds);

        remainingSeconds = DetermineRemainingSeconds(totalSeconds, 3600);

        minutes = DetermineMinutes(remainingSeconds);

        remainingSeconds = DetermineRemainingSeconds(remainingSeconds , 60);

        Display(hours, minutes, remainingSeconds);

        Console.ReadLine();
    }

    static int InputSeconds()
    {
        Console.Write("Total Seconds: ");
        return int.Parse(Console.ReadLine());
    }

    static int DetermineHours(int totalSeconds)
    {
        return totalSeconds / 3600;
    }

    static int DetermineRemainingSeconds(int totalSeconds, int divisor)
    {
        return totalSeconds % divisor;
    }

    static int DetermineMinutes(int remainingSeconds)
    {
        return remainingSeconds / 60;
    }

    static void Display(int hours, int minutes, int seconds)
    {
        Console.WriteLine($"Hours:   {hours}");
        Console.WriteLine($"Minutes: {minutes}");
        Console.WriteLine($"Seconds: {seconds}");
    }

}

