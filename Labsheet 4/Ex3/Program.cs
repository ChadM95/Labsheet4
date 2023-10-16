namespace Ex3;

class Program
{
    //main method, GetSize, ComputeArea, ComputePerimeter, display

    static void Main(string[] args)
    {
        double width, length, area, perimeter;     ;

        width = GetSize("width");
        length = GetSize("length");



        Display(length, width, area, perimeter);
        Console.ReadLine();
    }

    static double GetSize(string userValue)
    {
        double input;
        Console.Write("Please enter {0}", userValue);
        input = double.Parse(Console.ReadLine());

        return input;
    }

    static double ComputeArea(double, double)







    static void Display(double, double, double, double)
    {
        Console.WriteLine($"length:{length}\nWidth: {width} \narea: {area} \nperimeter: {perimeter}");
    }
}

