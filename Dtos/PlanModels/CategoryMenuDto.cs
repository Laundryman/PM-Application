using PMApplication.Entities;
using PMApplication.Entities.PlanogramAggregate;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Dtos.PlanModels
{
    public partial class CategoryMenuDto
    {
        [Key]
        public int Id { get; set; }
        public string? Name { get; set; }
        public int ParentCategoryId { get; set; }
        public string? ParentCategoryName { get; set; }
        public int DisplayOrder { get; set; }

        public int? HeroProductId { get; set; }
        public string? HeroImageUrl { get; set; }
        public List<PlanmMenuPart>? Parts { get; set; }

    }
}
