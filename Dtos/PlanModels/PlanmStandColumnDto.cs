using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmStandColumnDto
    {
        public PlanmStandColumnDto()
        {
            this.ColumnUprightList = new HashSet<PlanmStandColumnUprightDto>();
        }

        [Key]
        public int ColumnId { get; set; }
        public int StandId { get; set; }
        public int Position { get; set; }
        public int Width { get; set; }
        //public virtual Stand Stand { get; set; }
        public IEnumerable<PlanmStandColumnUprightDto> ColumnUprightList { get; set; }
    }
}
