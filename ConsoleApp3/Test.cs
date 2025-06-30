namespace ConsoleApp3;

public interface Test
{
    int sum(int a, int b);
    int diff(int a, int b);
    int multiply(int a, int b);
    int divide(int a, int b);
}


public class Test2 : Test
{
    public int sum(int a, int b)
    {
        return a + b;
    }

    public int diff(int a, int b)
    {
        return a - b;
    }

    public int multiply(int a, int b)
    {
        return a * b;
    }

    public int divide(int a, int b)
    {
        return a / b;
    }
}