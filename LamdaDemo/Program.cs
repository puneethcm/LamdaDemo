using LamdaDemo;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Lamda Expression");
        Console.WriteLine();
        List<Student> list = new List<Student>()
        {
            new Student(){Id=1,Name="Puneeth",PhoneNumber=123456,Age=24,Address="Davngere"},
            new Student(){Id=2,Name="Abhi",PhoneNumber=2875212,Age=23,Address="Banglore"},
            new Student(){Id=3,Name="Pavan",PhoneNumber=2141241,Age=22,Address="Manglore"},
            new Student(){Id=4,Name="Swathi",PhoneNumber=21412141,Age=20,Address="Hubli"},
        };
        DisplayStudentDetais(list);
        Console.ReadLine();
    }

    public static void DisplayStudentDetais(List<Student> list)
    {
        foreach(Student student in list)
        {
            Console.WriteLine(student.ToString());
        }
    }
}