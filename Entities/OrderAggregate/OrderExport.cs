using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.OrderAggregate
{
    public partial class OrderExport
      {
        [Key]
        public long ExportID { get; set; }
        public string OrderTitle { get; set; }
        public string OrderCreatedBy { get; set; }
        public string PartName { get; set; }
        public string PartNumber { get; set; }
        public string AltPartNumber { get; set; }
        public string CustomerRefNo { get; set; }
        public string CassetteBio { get; set; }
        public int TotalQuantity { get; set; }
        public decimal Price { get; set; }
        public decimal TotalCost { get; set; }
        public long? PlanogramId { get; set; }
        public string PlanogramName { get; set; }
        public string PartStatusName { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsFullPlano  { get; set; }
      }
}
