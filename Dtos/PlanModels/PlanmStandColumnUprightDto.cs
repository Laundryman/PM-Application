using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public partial class PlanmStandColumnUprightDto
    {
        [Key]
        public int ColumnUprightId { get; set; }
        public int ColumnId { get; set; }
        public int StandId { get; set; }
        public int Position { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}
