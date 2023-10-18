namespace Ex3;

class Program
{
    //main method, GetSize, ComputeArea, ComputePerimeter, display

    static void Main(string[] args)
    {
        double width, length, area, perimeter;     ;

        width = GetSize("width");
        length = GetSize("length");

        area = ComputeArea(length, width);

        perimeter = ComputePerimeter(length, width);
     
        Display(length, width, area, perimeter);

        Console.ReadLine();
    }

    static double GetSize(string userValue)
    {
        Console.Write("Please enter {0}", userValue);
        return double.Parse(Console.ReadLine());
    }

    static double ComputeArea(double width, double length)
    {
        return width * length;
    }

    static double ComputePerimeter(double length, double width)
    {
        return (length * 2) + (width * 2); 
    }

    static void Display(double length, double width, double area, double perimeter)
    {
        Console.WriteLine($"length:{length}\nWidth: {width} \narea: {area} \nperimeter: {perimeter}");
    }

}