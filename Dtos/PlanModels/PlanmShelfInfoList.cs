using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmShelfInfoList
    {
        public int PlanogramId { get; set; }
        public int ClusterId { get; set; }
        public IEnumerable<PlanmShelfInfo> shelfInfos { get; set; }
        public IEnumerable<PlanmPartInfo> partInfos { get; set; }
    }
}
