using C_EgitimKampi301.DataAccessLayer.Abstract;
using C_EgitimKampi301.DataAccessLayer.Context;
using C_EgitimKampi301.DataAccessLayer.Repositories;
using C_EgitimKampi301.EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_EgitimKampi301.DataAccessLayer.EntityFramework
{
    public class EfProductDal : GenericRepository<Product>, IProductDal
    {
        public List<Object> GetProductsWithCateory()
        {
            var context = new KampContext();
            var values = context.Products.Select(x=> new 
            {
                ProductId = x.ProductId,
                ProductName = x.ProductName,
                ProductStock=x.ProductStock,
                ProductPrice=x.ProductPrice,
                ProductDescription=x.ProductDescription,
                CategoryName=x.Category.CategoryName
            }).ToList();

            return values.Cast<Object>().ToList();
        }
    }
}
