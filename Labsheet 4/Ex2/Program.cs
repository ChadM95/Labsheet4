using System;

namespace Ex2;

class NameAndSaying
{
    static void Main(string[] args)
    {
        string name, saying;

        Console.WriteLine("><><><><><><><><><><><><><<><><><><><><><><><");

        name = GetInputValue("name");


        saying = GetInputValue("favourite saying");
       

        Display(name, saying);

        Console.WriteLine("><><><><><><><><><><><><><><><><><><><><><><><");
        Console.ReadLine();
    }

    static string GetInputValue(string whichValue)
    {
        string inputValue;
        Console.WriteLine("What is your {0}", whichValue);
        inputValue = Console.ReadLine();

        return inputValue;

    }

    static void Display(string name, string saying)
    {
        Console.WriteLine($"{name}'s favourite saying is \n {saying}");
    }

}//end of class


