// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello World!");
    }

    public static bool isLeapYear(int year) 
    {
        if(year % 4 == 0) 
        {
            if(year % 100 == 0)
            {
                if(year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }
}
