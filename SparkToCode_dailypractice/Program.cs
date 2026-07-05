namespace SparkToCode_dailypractice;

class Program
{
    static void Main(string[] args)
    {
        // 5/7/25 / 3rd session - functions 
        //built-in functions - 1- math functions 
        // math.abs --> making the (-) value (+)
        
        /*
        Console.Write("enter a negative number:  ");
        decimal userInput = Math.Abs(decimal.Parse(Console.ReadLine()));
        decimal result = userInput;
        Console.WriteLine("absolute result is :  "+result);
        */
        
        // Math.Pow --> getting the power of a number (2^3)
        /*
        Console.Write("enter the base:  ");
        float baseValue = float.Parse(Console.ReadLine());
        Console.Write("enter the power:  ");
        float powervalue = float.Parse(Console.ReadLine());
        
        double result = Math.Pow(baseValue, powervalue);
        Console.WriteLine("this is the result of power:  "+result);
        */
        
        //  Math.Sqrt function 
        
        Console.Write("enter a numer:  ");
        int num = int.Parse(Console.ReadLine());
        
        double sqrt = Math.Sqrt(num);
        Console.WriteLine("the square root of   " + num + "  is  "  + sqrt);
        
        
    }
}