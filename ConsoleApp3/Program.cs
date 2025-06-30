namespace ConsoleApp3;

public class Detals()
{
    static void Main()
    {
        
        int total, x;

        Calculate calculate = new Calculate();
        top:
        Console.Clear();
        Console.Write("What you want to do : 1 for sum 2 for diff");
        // x = int.Parse(Console.ReadLine());
        var temp = Console.ReadLine();
        if (int.TryParse(temp, out x))
        {
        }
        else
        {
            Console.WriteLine("Wrong input");
            Thread.Sleep(1500);
            goto top;
        }

        point2:
        Console.Write("Enter first number: ");
        // calculate.a = int.Parse(Console.ReadLine());
        var temp1 = Console.ReadLine();
        if (!int.TryParse(temp1, out calculate.a))
        {
            Console.WriteLine("Wrong input");
            Thread.Sleep(1500);
            goto point2;
        }
        else
        {
            int.TryParse(temp1, out calculate.a);   
        }

        Console.Write("Enter second number: ");
        calculate.b = int.Parse(Console.ReadLine());

        switch (x)
        {
            case 1:
                total = calculate.Sum();
                Console.WriteLine($"The sum is: {total}");
                break;
            case 2:
                total = calculate.diff();
                Console.WriteLine("The difference is:" + total);
                break;
            default:
                Console.WriteLine("Invalid input.");
                break;
            
        }
    }


}