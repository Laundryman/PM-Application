using System.ComponentModel.DataAnnotations;

namespace PMApplication.Entities.OrderAggregate
{
    public partial class OrderWindowInfo
    {
        [Key]
        public int OrderWindowId { get; set; }
        public int BrandId { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime UpdatedDate { get; set; }
        public int CreatedBy { get; set; }
        public int UpdatedBy { get; set; }
        public string UpdatedByName { get; set; }
        public string CreatedByName { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public int RowNum { get; set; }
        public int TotalResults { get; set; }

    }
}
