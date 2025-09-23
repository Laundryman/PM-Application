using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.OrderAggregate
{

    public partial class OrderInfo
    {

        [Key]
        public long OrderId { get; set; }
        public int BrandId { get; set; }
        public string OrderTitle { get; set; }
        public int OrderStatus { get; set; }
        public DateTime OrderCreated { get; set; }
        public DateTime OrderUpdated { get; set; }
        public int OrderCreatedBy { get; set; }
        public int OrderUpdatedBy { get; set; }
        public string OrderCreatedByName { get; set; }
        public string OrderUpdatedByName { get; set; }
        public int CountryId { get; set; }
        public int RegionId { get; set; }
        public decimal TotalOrderValue { get; set; }

        public int TotalResults { get; set; }
        public int RowNum { get; set; }



    }
}
