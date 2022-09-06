// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        string result;
        try
        {
            result = isLeapYear(getInput()) ? "yay" : "nay";
        } 
        catch(ArgumentException e) 
        {
            Console.WriteLine(e.Message);
            return;
        } 
        catch(FormatException)
        {
            Console.WriteLine("Something went wrong: You must write a number");
            return;
        }

        Console.WriteLine(result);
    }

    public static int getInput()
    {
        string? line = Console.ReadLine();
        if (line != null)
        {
            int result = int.Parse(line);
            return result;
        }
        return -1;
    }
    public static bool isLeapYear(int year)
    {
        if (year < 1582)
        {
            throw new ArgumentException("Can't calculate for years before 1582");
        }


        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
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
