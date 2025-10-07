using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmPlanoImageDto
    {
        public int PlanogramId { get; set; }
        public string UserId { get; set; }
        public string UserName { get; set; }

        public string Image { get; set; }
    }
}
