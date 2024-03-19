namespace WebApi.Entity
{
    public class Bill
    {
        public int BillId { get; set; }
        public int CartId { get; set; }
        public double Subtotal { get; set; }
        public double Total { get; set; }
        public double TotalIVA { get; set; }
        public DateTime DateTime { get; set; }
        public virtual ShoppingCart ShoppingCart { get; set; }
    }
}
