using System;
using System.Collections.Generic;
using System.Text;

namespace PMApplication.Dtos.PlanModels
{
    public class SaveLayoutDto
    {
        public long Id { get; set; }
        public string? Name { get; set; }
        public bool Published { get; set; }
    }
}
