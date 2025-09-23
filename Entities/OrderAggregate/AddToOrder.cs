namespace PMApplication.Entities.OrderAggregate
{
    public class AddToOrder
    {
        public long OrderId { get; set; }
        public long PlanogramId { get; set; }
        public int Quantity { get; set; }
        public bool IsFullPlano { get; set; }
    }

}
