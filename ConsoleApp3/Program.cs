namespace ConsoleApp3;

public static class Apple{
    static void Main()
    {
        Fruits fruits = new Fruits();
        fruits.Name = Console.ReadLine();
        fruits.Color = Console.ReadLine();
        fruits.Weight = int.Parse(Console.ReadLine());
        fruits.PrintName();
    }
}