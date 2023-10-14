namespace Labsheet_4;

class Program
{
    static void Main(string[] args)
    {
        // simple program using methods which
        // 1) displays a line of asterisks and
        // 2) displays information about your college

        string collegeInfo;
        DisplayAsterisk();
        collegeInfo = GetCollegeInfo();
        Console.WriteLine(collegeInfo);
        DisplayAsterisk();
        Console.ReadLine();
    } //end of main method


    public static void DisplayAsterisk()
    {

     Console.WriteLine("**************************");

    }//end of method

    public static string GetCollegeInfo()
    {
        string returnValue;
        returnValue = "College name = ATU Sligo\n" +
                      "School colours = Red/Black\n" +
                      "Location = Ash Lane, Sligo\n" +
                      "Number of students = 7,000";

        return returnValue;
    }//end of method





} // end of class


