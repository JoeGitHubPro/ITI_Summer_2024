using Ticket;
using Library;
using Library.V1;

namespace Day3
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//homogenous ==> array
			//hetrogenous ===> struct / class
			//Student: Id: int, name: string, age: int, email: string
			//can't use array
			#region struct Definition

			//struct/class: data type with my own definition
			// from several data types

			//Student[] students = new Student[3];

			//Student s1; //object or instance from student
			// 8b
			//s1.id = 1; //assign => setter
			//Console.WriteLine(s1.id); //getter

			//Console.WriteLine("Please enter Id");
			//s1.id = int.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter name");
			//s1.name = Console.ReadLine();
			//Console.WriteLine("Please enter age");
			//s1.age = int.Parse(Console.ReadLine());
			//Console.WriteLine("Please enter email");
			//s1.email = Console.ReadLine();

			//Console.WriteLine(s1.id);
			//Console.WriteLine(s1.name);
			//Console.WriteLine(s1.age);
			//Console.WriteLine(s1.email);

			//s1.PrintStudent();

			//Console.WriteLine(s1.PrintStudentV2());

			//for(int i = 0; i < students.Length; i++)
			//{
			//	Console.WriteLine("Please enter Id");
			//	students[i].id = int.Parse(Console.ReadLine());
			//	Console.WriteLine("Please enter name");
			//	students[i].name = Console.ReadLine();
			//	Console.WriteLine("Please enter age");
			//	students[i].age = int.Parse(Console.ReadLine());
			//	Console.WriteLine("Please enter email");
			//	students[i].email = Console.ReadLine();
			//}

			//Console.Clear();

			//for(int i = 0;i < students.Length; i++)
			//{
			//	Console.WriteLine(students[i].PrintStudentV2());
			//}

			#endregion

			#region Try OOP

			//Student s1 = new Student(); // id = 0, name = null, age = 0, email null 

			//s1.id = 1;  => error as id is private field

			//s1.SetId(1);
			//Console.WriteLine(s1.GetId());

			//Ticket.Book b1;

			//Ticket.Book book1;
			//Library.Book book2;

			//BookV1 book = new BookV1();
			#endregion
		}
	}
}

//Assignment

// struct Employee (SSN: int, name: string, age: int, Email: string, Salary: decimal)

// setter & getter
// validation for age: age must be between 18 & 60
//						age => 20

// salary: user can't get salary value;

// print: id : name : age : email : salary.
