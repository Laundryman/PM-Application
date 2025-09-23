#nullable disable

namespace PMApplication.Entities.PlanogramAggregate
{
    public partial class PlanogramPartProduct
    {
        public long PlanogramPartsId { get; set; }
        public long ProductId { get; set; }

        public virtual PlanogramPart PlanogramParts { get; set; }
        public virtual Product Product { get; set; }
    }
}
