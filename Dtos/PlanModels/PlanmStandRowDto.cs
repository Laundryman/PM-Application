using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public class PlanmStandRowDto
    {
        [Key]
        public int RowId { get; set; }
        public int StandId { get; set; }
        public int Position { get; set; }
        public int Height { get; set; }
    }
}
