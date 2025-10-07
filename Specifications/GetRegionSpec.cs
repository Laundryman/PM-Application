using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ardalis.Specification;
using Microsoft.EntityFrameworkCore;
using PMApplication.Entities;
using PMApplication.Entities.CountriesAggregate;

namespace PMApplication.Specifications
{
    public class GetRegionSpec : Specification<Region>
    {
        public GetRegionSpec(int Id)
        {
            Query.Where(region => region.Id == Id)
                .Include(r => r.Countries);
        }
    }
}
