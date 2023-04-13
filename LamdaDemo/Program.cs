using LamdaDemo;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Lamda Expression");
        Console.WriteLine();
        List<Student> list = new List<Student>()
        {
            new Student(){Id=1,Name="Puneeth",PhoneNumber=123456,Age=12,Address="Davngere",TotalMarks=60},
            new Student(){Id=2,Name="Abhi",PhoneNumber=2875212,Age=19,Address="Banglore",TotalMarks=90},
            new Student(){Id=3,Name="Pavan",PhoneNumber=2141241,Age=15,Address="Manglore",TotalMarks=75},
            new Student(){Id=4,Name="Swathi",PhoneNumber=21412141,Age=20,Address="Hubli",TotalMarks=80},
            new Student(){Id=5,Name="Kavya",PhoneNumber=2875212,Age=17,Address="Banglore",TotalMarks=95}
        };
        DisplayStudentDetais(list);
        //Console.WriteLine("\nStudents Age between 12 & 18");
        //StudentDataManagement.RetriveDataFromListByAge(list);
        //StudentDataManagement.SortDataBasedOnMarks(list);
        //StudentDataManagement.DisplayStudentByAddress(list);
        //StudentDataManagement.DisplayFirst3Students(list);
        //StudentDataManagement.DisplayLast3Students(list);
        StudentDataManagement.SearchStudentByName(list);

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