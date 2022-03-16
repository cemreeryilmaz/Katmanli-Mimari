using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.Business.Abstract
{
    public interface IProductService
    {
        List<Product> GetAll();
        List<Product> GetByCategory(int categoryId);

        Product GetById(int productId);

        void Add(Product product);
        void Update(Product product);
        void Delete(int productId);
    }
}
