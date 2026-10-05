using System.ComponentModel.DataAnnotations;
using PMApplication.Dtos.StandTypes;

namespace PMApplication.Entities.PartAggregate
{
    public partial class PopularPart
    {


        public int PartCount { get; set; }
        public long? Id { get; set; }
        public string? Name { get; set; }
        public string? BrandName { get; set; }
    }
}
