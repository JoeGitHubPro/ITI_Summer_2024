namespace C_Day1
{
	internal class Program
	{
		static void Main()
		{
			#region write in console
			//int age = 22;
			//string name = "Ahmed";

			////string concat is not recommend
			//Console.WriteLine("your name is " + name);
			//Console.WriteLine("your age is " + age);

			////string interpolation 

			//Console.WriteLine($"your name is {name}");
			//Console.WriteLine($"your age is {age}");
			#endregion

			#region read from console

			////console.ReadLine() => read stream of characters untill user press enter
			//						//then return the value

			//Console.WriteLine("Please enter your name");
			//string name = Console.ReadLine();

			//Console.WriteLine("Please enter your age");
			//int age = int.Parse(Console.ReadLine());

			//Console.WriteLine("Please enter your salary");
			//decimal salary = decimal.Parse(Console.ReadLine());

			//Console.WriteLine($"Your name is {name} & your age is {age}");

			#endregion

			#region Operators

			#region Arthmatic Operators

			#region Binary Arthmatic Operator  +, -, *, /, %

			//int x = 3;
			//int y = 4;
			//float z = (float) x / y;  // => 0.75
			//int a = x % y; //3

			//Console.WriteLine(x); //3
			//Console.WriteLine(y); //4
			//Console.WriteLine(z); //0.75

			#endregion

			#region Unary Arthmatic Operator ++, --

			//int x = 3, y = 4, z = 5;

			////x++; // x = x+1;

			////x++; // => postfix
			////++x; // => prefix

			//z = ++x;
			//z = x++;

			//Console.WriteLine(z); //4
			//Console.WriteLine(x); //5

			//z = x + 1; // z= 4, x=3
			//z = ++x; // z=4, x =4

			#endregion

			#endregion

			#region Comparison Operators  >, <, >=, <=, ==, !=  ===> true or false

			//int x = 3, y = 4, z = 3;

			//Console.WriteLine(x > y); //false;
			//Console.WriteLine(x >= z); //true;
			//Console.WriteLine(x != z); //false;
			//Console.WriteLine(x != y); //true;

			#endregion

			#region Compoind Operators +=, -=, *=, /=, %=

			//int x = 3, y = 4, z = 5;

			//z += x; //8  z = z+ x

			#endregion

			#region Logical Operators &&, ||

			//int x = 3, y = 4, z = 3;

			//// && returns true if all branches are true
			//// && returns false if any branch is false
			//// || returns false if all branches are false
			//// || returns true if any branch is true

			//Console.WriteLine(x == y && x > z && y < z); // false
			//Console.WriteLine(x != y && x >= z && y > z); // true
			//Console.WriteLine(x != y && x >= z && y < z); // false

			//Console.WriteLine(x == y || x > z || y < z); // false
			//Console.WriteLine(x != y || x >= z || y > z); // true
			//Console.WriteLine(x != y || x >= z || y < z); // true

			#endregion

			#endregion

			#region If statement

			//// if(condition) { ii condition is true }

			//int x = 5, y = 4, z = 6;

			//if (x > y) // true
			//{
			//	Console.WriteLine("X is greater than y");
			//}
			//else if (z > y) //false
			//{
			//	Console.WriteLine("Z is greater than y");
			//}
			//else
			//{
			//	Console.WriteLine("Y is greater than X & Z");
			//}

			#endregion

		}
	}
}
