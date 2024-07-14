namespace Day1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Student> students = new List<Student>
            {
            new Student { Id = 1, Name = "Ahmed", Age = 19, SpecialistType = "Front-end" },
            new Student { Id = 2, Name = "Mona", Age = 20, SpecialistType = "ML" },
            new Student { Id = 3, Name = "Sara", Age = 21, SpecialistType = "Front-end" },
            new Student { Id = 4, Name = "Ali", Age = 37, SpecialistType = "IS" },
            new Student { Id = 5, Name = "Omar", Age = 23, SpecialistType = "Computer Science" }
            };



            var allStudents = students.Select(s => s);
            Console.WriteLine("All Students:");
            foreach (var student in allStudents)
            {
                Console.WriteLine($"{student.Id}: {student.Name}, Age: {student.Age}, Specialist: {student.SpecialistType}");
            }


            var ageAbove21 = students.Where(s => s.Age > 21);
            Console.WriteLine("\nStudents with Age > 21:");
            foreach (var student in ageAbove21)
            {
                Console.WriteLine($"{student.Id}: {student.Name}, Age: {student.Age}, Specialist: {student.SpecialistType}");
            }


            var minAge = students.Min(s => s.Age);
            var maxAge = students.Max(s => s.Age);
            Console.WriteLine($"\nMinimum Age: {minAge}");
            Console.WriteLine($"Maximum Age: {maxAge}");


            var youngestStudent = students.OrderBy(s => s.Age).First();
            var oldestStudent = students.OrderByDescending(s => s.Age).First();
            Console.WriteLine($"\nYoungest Student: {youngestStudent.Name}, Age: {youngestStudent.Age}");
            Console.WriteLine($"Oldest Student: {oldestStudent.Name}, Age: {oldestStudent.Age}");


            var averageAge = students.Average(s => s.Age);
            Console.WriteLine($"\nAverage Age: {averageAge}");


            var groupBySpecialist = students.GroupBy(s => s.SpecialistType);
            Console.WriteLine("\nStudents Grouped by Specialist Type:");
            foreach (var group in groupBySpecialist)
            {
                Console.WriteLine($"\nSpecialist Type: {group.Key}");
                foreach (var student in group)
                {
                    Console.WriteLine($"{student.Id}: {student.Name}, Age: {student.Age}");
                }
            }
        }
    }
}
