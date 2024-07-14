using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
	//public: can be accessed inside and outside the struct or class
	//private: can be accessed inside the struct or class only.
	// struct & class => members are private.
	struct Student  //Start with capital & 
	{
		//data members
		#region Fields (Data Fields)
		// start with small letter of _
		int id; //4b
		string name; //0
		int age; //4b
		string email; //0
		#endregion

		#region Setter & Getter

		//calller => s1
		public void SetId(int _id)
		{
			id = _id;
			//s1.id = _id; => s1 caller
		}

		//public int GetId()
		//{
		//	return id;
		//}

		public void SetName(string _name) { name = _name; }
		public string GetName() { return name; }

		public void SetAge(int _age) //validation
		{
			if (_age >= 18 && _age <= 60)
			{
				age = _age;
			}
			else
			{
				age = 25;
			}
		}
		public int GetAge() { return age; }

		//public void SetEmail(string _email) { email = _email; }
		public string GetEmail() { return email; }

		#endregion

		//caller => s1
		public void PrintStudent()
		{
			Console.WriteLine(id);
			Console.WriteLine(name);
			Console.WriteLine(age);
			Console.WriteLine(email);
		}

		public string PrintStudentV2()
		{
			return $"{id}:{name}:{age}:{email}";
		}
	}
}
