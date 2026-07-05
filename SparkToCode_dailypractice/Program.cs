namespace SparkToCode_dailypractice;

class Program
{
    static void Main(string[] args)
    {
        // 5/7/25 / 3rd session - functions 
        //built-in functions - 1- math functions 
        // math.abs --> making the (-) value (+)
        
        Console.Write("enter a negative number:  ");
        decimal userInput = Math.Abs(decimal.Parse(Console.ReadLine()));
        decimal result = userInput;
        Console.WriteLine("absolute result is :  "+result);
    }
}