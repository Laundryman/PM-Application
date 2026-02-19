using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PartProductsDto
    {
        public long? PlanogramPartsId { get; set; }
        public long PartId { get; set; }
        public long? PlanogramShelfId { get; set; }
        public virtual IEnumerable<ProductDto>? Products { get; set; }
    }
}
