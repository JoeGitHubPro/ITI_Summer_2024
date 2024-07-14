namespace Day4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            int b = 0;
            Console.WriteLine("Math Operations:");
            Console.WriteLine($"Addition of {a} and {b} is: {Math.Add(a, b)}");
            Console.WriteLine($"Subtraction of {b} from {a} is: {Math.Subtract(a, b)}");
            Console.WriteLine($"Multiplication of {a} and {b} is: {Math.Multiply(a, b)}");
            Console.WriteLine($"Division of {a} by {b} is: {Math.Divide(a, b)}");

            // Using Student Class
            Student student = new Student(1, "Youssef Mohamed", 20, "Youssef.Mohamed@example.com");
            Console.WriteLine("\nStudent Details:");
            student.Print();
        }
    }
}
