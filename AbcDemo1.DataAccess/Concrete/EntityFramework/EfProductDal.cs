using AbcDemo1.DataAccess.Abstract;
using AbcDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcDemo1.DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>{
                new Product
                {
                    Id=1, Name="Laptop"
                },
                new Product
                {
                    Id=2, Name="Mouse"
                }
            };
        }
    }
}
