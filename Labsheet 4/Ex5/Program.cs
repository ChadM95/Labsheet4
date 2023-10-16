namespace Ex5;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Temperature Converter App");

        double fahrenheit, celsius;

        fahrenheit = GetFahrenheit();

        celsius = ConvertToCelsius(fahrenheit);

        Display(fahrenheit, celsius);
        
        Console.ReadLine();
    }


    static double GetFahrenheit()
    {
        Console.Write("Enter temperature in fahrenheit> ");
        return double.Parse(Console.ReadLine());
    }


    static double ConvertToCelsius(double fahrenheit)
    {
        return fahrenheit * 0.38;
    }


    static void Display(double fahrenheit, double celsius)
    {
        Console.WriteLine($"Fahrenheit: {fahrenheit} \nCelsius: {celsius}");

    }


}

