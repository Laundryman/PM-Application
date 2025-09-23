using PMApplication.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMApplication.Interfaces.ServiceInterfaces
{
    public interface IBrandService
    {
        Task<IReadOnlyList<Brand>> GetBrands();
        Task<Brand> GetBrand(int id);
        Task<Brand> CreateBrand(Brand brand);
        Task DeleteBrand(int id);
    }
}
