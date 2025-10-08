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
    public class GetCountrySpec : Specification<Country>
    {
        public GetCountrySpec(int Id)
        {
            Query.Where(country => country.Id == Id)
                .Include(r => r.Regions);
        }
    }
}
