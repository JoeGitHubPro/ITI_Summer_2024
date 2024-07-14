namespace Day4
{
    public class Student
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }


        public Student()
        {

        }


        public Student(int id, string name, int age, string email)
        {
            Id = id;
            Name = name;
            Age = age;
            Email = email;
        }


        public void Print()
        {
            Console.WriteLine($"ID: {Id}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"Email: {Email}");
        }
    }
}
