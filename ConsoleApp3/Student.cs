namespace ConsoleApp3;

public class Student
{
    private  string StudentName;
    public int Age;
    public int Class;

    public void setName(string name)
    {
        StudentName = name;
    }

    public void PrintStudent()
    {
        Console.WriteLine(StudentName);
    }
    
}

public class Teacher : Student
{
    public string TeacherName;
}

public class Class1 : Teacher
{
    public string ClassName;
}

public class Program
{
    static void Main (string[] args)
    {
        Class1 class1 = new Class1();
        Teacher teacher = new Teacher();
        
        
        class1.setName("Ram");
        class1.PrintStudent();
    }
}