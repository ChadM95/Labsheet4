namespace Ex2a;

class Program
{
    //writing ex2 again for practice
    //method GetInputValue takes in a string (passed in as an argument when method is called)
    //the input string is assigned to the local variable whichValue
    //this allows the method to be used repeatedly for different outputs
    //method Display needs variables from main method passed in as arguments to be able to use them
    //display method has a void return type as it only writes to console
    //ie doesnt return anything to main method

    static void Main(string[] args)
    {
        string name, saying;

        name = GetInputValue("name");
        saying = GetInputValue("favourite saying");

        Display(name,saying);

        Console.ReadLine();
    }


    static string GetInputValue(string whichvalue)
    {
        string inputValue;
        Console.Write("What is your {0} ? ", whichvalue);
        inputValue = Console.ReadLine();

        return inputValue;

    }

    static void Display(string name, string saying)
    {
        Console.WriteLine($"{name}s favourite saying is {saying} ");

    }









}

