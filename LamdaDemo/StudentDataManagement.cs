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
	}
}

