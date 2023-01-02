using AbcDemo1.DataAccess.Abstract;
using AbcDemo1.DataAccess.Concrete.EntityFramework;
using AbcDemo1.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcDemo1.DataAccess.Concrete.NHibernate
    {
    public class NHProdudctDal : IProductDal
    {
        public List<Product> GetAll()
        {
            return new List<Product>
            {
            new Product{Id=1, Name="TV"}
            };
        }
    }
}
