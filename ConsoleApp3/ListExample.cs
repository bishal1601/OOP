namespace ConsoleApp3;
public class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public char Gender { get; set; }
}

public class ListExample
{

    static List<Student> students = new List<Student>();
    static char addMore;
    static void Main(string[] args)
    {
        do
        {
        var student = new Student();
        Console.WriteLine("ID");
        student.Id = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Name");
        student.Name = Console.ReadLine();
        
        Console.WriteLine("Gender");
        student.Gender = char.Parse(Console.ReadLine());
        students.Add(student);
        
        Console.WriteLine("Do you want to add more students?");
        addMore = char.Parse(Console.ReadLine());
        
        }
        while (addMore == 'y');
        
        

        foreach (var stu in students)
        {
            Console.WriteLine("ID " + stu.Id + ", Name " + stu.Name + ", Gender " + stu.Gender);
            
        }
        
    }
}