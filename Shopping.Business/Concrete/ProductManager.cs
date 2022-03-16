using Shopping.Business.Abstract;
using Shopping.DataAccess.Abstract;
using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Business.Concrete
{
    public class ProductManager : IProductService
    {
        private IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public List<Product> GetAll()
        {
            return _productDal.GetList();
        }

        public List<Product> GetByCategory(int categoryId)
        {
            return _productDal.GetList(p => p.CategoryId == categoryId);
        }

        public Product GetById(int productImageId)
        {
            return _productDal.Get(p => p.ProductId == productImageId);
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }


        public void Delete(int productId)
        {
            _productDal.Delete(new Product { ProductId = productId });
        }


    }
}
