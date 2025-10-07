using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class ProductShadesDto
    {
        public int ProductId { get; set; }
        public virtual IEnumerable<PlanmShadeDto> Shades { get; set; }
    }
}
