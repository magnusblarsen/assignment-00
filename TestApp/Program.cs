// See https://aka.ms/new-console-template for more information

public class Program
{
    public static void Main(string[] args)
    {
        string result = isLeapYear(getInput()) ? "yay" : "nay";
        Console.WriteLine(result);
    }

    public static int getInput()
    {
        string? line = Console.ReadLine();
        if (line != null)
        {
            return int.Parse(line);
        }
        return -1;
    }
    public static bool isLeapYear(int year)
    {
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
