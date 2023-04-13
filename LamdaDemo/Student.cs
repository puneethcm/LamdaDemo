using System;
namespace LamdaDemo
{
	public class Student
	{
		public int Id { get; set; }
        public string Name { get; set; }
        public int PhoneNumber { get; set; }
        public int Age { get; set; }
        public int TotalMarks { get; set; }
        public string Address { get; set; }


        public override string ToString()
        {
            return $"Id:{Id} Name:{Name} Age:{Age} Address:{Address} PhoneNumber:{PhoneNumber} TotalMarks:{TotalMarks}";
        }
    }
}

