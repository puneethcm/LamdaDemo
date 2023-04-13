using System;
namespace LamdaDemo
{
	public class StudentDataManagement
	{
		public static void RetriveDataFromListByAge(List<Student> students)
		{
			List<Student> studentsAge = students.Where(s => s.Age >= 12 && s.Age <= 18).ToList();
			Program.DisplayStudentDetais(studentsAge);
		}

		public static void SortDataBasedOnMarks(List<Student> students)
		{
			Console.WriteLine("\nSort Data based on total marks");
            List<Student> sortedData = students.OrderBy(s => s.TotalMarks).ToList();
            Program.DisplayStudentDetais(sortedData);
        }

		public static void DisplayStudentByAddress(List<Student> list)
		{
			Console.WriteLine("\nDisplay students based on address");
			var reslut = list.GroupBy(s => s.Address);
			foreach(var r in reslut)
			{
				Console.WriteLine("Key:" + r.Key);
				Console.WriteLine("=====================");
				List<Student> students = r.ToList();
				foreach(Student s in students)
				{
					Console.WriteLine(s);
				}
				Console.WriteLine();
			}

		}

		public static void DisplayFirst3Students(List<Student> list)
		{
			Console.WriteLine("\nDisplay First 3 students");
			var top3 = list.Take(3).ToList();
            Program.DisplayStudentDetais(top3);
        }

        public static void DisplayLast3Students(List<Student> list)
        {
            Console.WriteLine("\nDisplay Last 3 students");
            var top3 = list.TakeLast(3).ToList();
			top3.Reverse();
            Program.DisplayStudentDetais(top3);
        }

        public static void SearchStudentByName(List<Student> list)
        {
            Console.WriteLine("\nSearch student by Name");
			Console.WriteLine("\nEnter student name");
			string studentName = Console.ReadLine();
			var name = list.GroupBy(s => s.Name).ToList();
            foreach(var stu in name)
			{
                var s = stu.Key.Equals(studentName);
                if (s == true)
                {
                    Console.WriteLine(stu.Key + " Is present");
                }
            }
			Console.WriteLine("Student with name {0} is not present", studentName);
        }
    }
}

