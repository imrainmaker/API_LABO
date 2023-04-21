using DAL.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces
{
    public interface IProductService
    {

        public IEnumerable<ProductViewModel> GetAll();

        public ProductViewModel? GetById(int id);
    }
}
