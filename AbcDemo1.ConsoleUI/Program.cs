using AbcDemo1.Business.Concrete;
using AbcDemo1.DataAccess.Concrete.NHibernate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbcDemo1.ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            ProductManager productManager = new ProductManager(new NHProdudctDal());
            foreach (var product in productManager.GetAll())
            {
                Console.WriteLine(product.Name);
            }
            Console.ReadLine();
        }
    }
}
