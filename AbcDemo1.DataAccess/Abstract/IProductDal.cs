using AbcDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcDemo1.DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
    }
}
