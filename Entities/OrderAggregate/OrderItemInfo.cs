using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.OrderAggregate
{
    public partial class OrderItemInfo
    {
        [Key]
        public int OrderItemId { get; set; }
        public int OrderId { get; set; }
        public int Quantity { get; set; }
        public int InitialQuantity { get; set; }
        public DateTime DateAdded { get; set; }
        public int PartId { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public string PackShotImageSrc { get; set; }
        public decimal Price { get; set; }
        public int? PlanogramId { get; set; }
        public bool Shoppable { get; set; }
        public bool HidePrices { get; set; }
        public bool? IsFullPlano { get; set; }
        public long? OrderPlanogramId { get; set; }
    }
}
