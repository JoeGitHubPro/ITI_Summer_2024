namespace Day7
{
    internal partial class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();

            Console.Write("Enter ID: ");
            student.Id = int.Parse(Console.ReadLine());

            Console.Write("Enter Name: ");
            student.Name = Console.ReadLine();

            Console.Write("Enter Age: ");
            student.Age = int.Parse(Console.ReadLine());

            Console.Write("Enter Email: ");
            student.Email = Console.ReadLine();

            Console.Write("Enter Gender (m/f): ");
            string genderInput = Console.ReadLine().ToLower();

            if ((genderInput == "m") || (genderInput == "M"))
            {
                student.Gender = Gender.Male;
            }
            else if ((genderInput == "f") || (genderInput == "F"))
            {
                student.Gender = Gender.Female;
            }



        }
    }
}
