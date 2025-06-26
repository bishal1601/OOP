namespace ConsoleApp3;

public class Detals()
{
    static void Main()
    {
        int total, x;
        
        Calculate calculate = new Calculate();
        
        Console.Write("What you want to do : 1 for sum 2 for diff");
        x= int.Parse(Console.ReadLine());
        
        Console.Write("Enter first number: ");
        calculate.a= int.Parse(Console.ReadLine());
        
        Console.Write("Enter second number: ");
        calculate.b = int.Parse(Console.ReadLine());
        if (x == 1)
        {
            total = calculate.Sum();
            Console.WriteLine(total);
        }
        else
        {
            total = calculate.diff();
            Console.WriteLine(total);
        }
    }
    
 
}