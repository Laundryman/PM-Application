using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmShadeDto
    {
        public int ShadeId { get; set; }
        public string ShadeNumber { get; set; }
        public string ShadeDescription { get; set; }
        public int ProductId { get; set; }
        public bool Published { get; set; }
    }
}
