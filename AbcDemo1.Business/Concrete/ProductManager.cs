using AbcDemo1.Business.Abstract;
using AbcDemo1.DataAccess.Abstract;
using AbcDemo1.Entities.Concrete;
using Core.Aspects.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcDemo1.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;
        //private ICache _cache;
        //private ILogger _logger;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
            //_cache = cache;
            //_logger = logger;   
        }

        [LogAspect]
        public List<Product> GetAll()
        {
            //_cache.Cache();
            //_logger.Log();
            return _productDal.GetAll();
        }
    }
}
