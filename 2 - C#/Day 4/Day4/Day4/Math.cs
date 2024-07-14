namespace Day4
{
    public static class Math
    {
        public static int Add(int a, int b) => a + b;
        public static int Subtract(int a, int b) => a - b;
        public static int Multiply(int a, int b) => a * b;
        public static double Divide(int a, int b)
        {
            if (b == 0)
            {
                return 0;
            }
            return (double)a / b;
        }
    }
}
