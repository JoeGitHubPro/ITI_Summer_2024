namespace Day8
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Point p1 = new Point(2, 3);
            Point p2 = new Point(4, 5);
            Point p3 = p1 + p2;
            Point p4 = p1 - p2;

            Console.WriteLine(p1);
            Console.WriteLine(p2);
            Console.WriteLine(p3);
            Console.WriteLine(p4);

            Console.WriteLine(p1 == p2);
            Console.WriteLine(p1 != p2);

            Console.WriteLine(p1 > p2);
            Console.WriteLine(p1 < p2);

            p1++;
            Console.WriteLine(p1);

            p2--;
            Console.WriteLine(p2);

            int sum = (int)p1;
            Console.WriteLine(sum);


        }
    }
}
