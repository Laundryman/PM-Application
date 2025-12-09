using Microsoft.EntityFrameworkCore;
using PMApplication.Entities.ProductAggregate;

namespace PMApplication.Entities.PartAggregate
{
    [PrimaryKey(nameof(PartId), nameof(ProductId))]
    public partial class PartProduct
    {
        public long PartId { get; set; }
        public long ProductId { get; set; }

        public virtual Part Part { get; set; }
        public virtual Product Product { get; set; }

        //-----------------------------------------------
        //ctors

        //private PartProduct() { }

        //public PartProduct(int partId, int productId)
        //{
        //    PartId = partId;
        //    ProductId = productId;
        //}
    }
}
