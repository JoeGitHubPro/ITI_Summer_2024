namespace Day7
{

    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public Gender Gender { get; set; }

        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Age: {Age}, Email: {Email}, Gender: {Gender}";
        }


    }

}
