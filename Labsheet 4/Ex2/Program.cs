using System;

namespace Ex2;

class NameAndSaying
{
    static void Main(string[] args)
    {
        //setup
        string name, saying;

        //output
        Console.WriteLine("><><><><><><><><><><><><><><><><><><><");

        name = GetInputValue("name");
        saying = GetInputValue("favourite saying");

        DisplayNameAndSaying(name,saying);

        Console.WriteLine("><><><><><><><><><><><><><><><><><><><");
        Console.ReadLine();
    }

    static string GetInputValue(string whichValue)
    {
        string inputValue;

        Console.Write("Enter your {0}> ", whichValue);
        inputValue = Console.ReadLine();

        return inputValue;
    }

    static void DisplayNameAndSaying(string name, string saying)
    {

        Console.WriteLine($"{name}'s favourite saying is {saying}");

    }











}//end of class


