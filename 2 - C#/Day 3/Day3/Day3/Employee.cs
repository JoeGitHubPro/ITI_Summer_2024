namespace Day3
{
    public struct Employee
    {
        //Assignment
        // struct Employee (SSN: int, name: string, age: int, Email: string, Salary: decimal)
        // setter & getter
        // validation for age: age must be between 18 & 60
        //						age => 20

        // salary: user can't get salary value;

        // print: id : name : age : email : salary.

        private int ssn;
        private string name;
        private int age;
        private string email;
        private decimal salary;

        public int SSN
        {
            get { return ssn; }
            set { ssn = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 18 || value < 60)
                {
                    age = value;
                }
                else
                {
                    age = 20;
                }

            }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public decimal Salary
        {
            private get { return salary; }
            set { salary = value; }
        }

        public void PrintV1()
        {
            Console.WriteLine(SSN);
            Console.WriteLine(Name);
            Console.WriteLine(Age);
            Console.WriteLine(Email);
            Console.WriteLine(Salary);
        }

        public string PrintV2()
        {
            return $"{SSN} : {Name} : {Age} : {Email} : {Salary}";
        }

    }
}
