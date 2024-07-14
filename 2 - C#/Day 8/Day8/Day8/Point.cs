namespace Day8
{
    public class Point
    {
        public int x { get; set; }
        public int y { get; set; }

        public Point(int x = 0, int y = 0)
        {
            this.x = x;
            this.y = y;
        }

        public override string ToString()
        {
            return $"({x}, {y})";
        }


        public static Point operator +(Point p1, Point p2)
        {
            return new Point(p1.x + p2.x, p1.y + p2.y);
        }


        public static Point operator -(Point p1, Point p2)
        {
            return new Point(p1.x - p2.x, p1.y - p2.y);
        }


        public static bool operator ==(Point p1, Point p2)
        {
            return p1.x == p2.x && p1.y == p2.y;
        }


        public static bool operator !=(Point p1, Point p2)
        {
            return !(p1 == p2);
        }


        public static bool operator >(Point p1, Point p2)
        {
            return (p1.x > p2.x) || (p1.x == p2.x && p1.y > p2.y);
        }


        public static bool operator <(Point p1, Point p2)
        {
            return (p1.x < p2.x) || (p1.x == p2.x && p1.y < p2.y);
        }



        public static Point operator ++(Point p)
        {
            return new Point(p.x + 1, p.y + 1);
        }


        public static Point operator --(Point p)
        {
            return new Point(p.x - 1, p.y - 1);
        }




        public static explicit operator int(Point p)
        {
            return p.x + p.y;
        }




    }
}
