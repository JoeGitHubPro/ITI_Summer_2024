namespace Day2.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public decimal OrderPrice { get; set; }
        public ICollection<OrderProduct> OrderProducts { get; set; }
    }
}
