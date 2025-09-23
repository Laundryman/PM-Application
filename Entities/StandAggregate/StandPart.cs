using System;
using System.Collections.Generic;
using PMApplication.Entities.PartAggregate;
using PMApplication.Entities.StandAggregate;

#nullable disable

namespace ApplicationCore.Entities
{
    public partial class StandPart
    {
        public long PartId { get; set; }
        public int StandId { get; set; }

        public virtual Part Part { get; set; }
        public virtual Stand Stand { get; set; }
    }
}
