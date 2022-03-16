using Shopping.Core.DataAccess.Concrete.EntityFramework;
using Shopping.DataAccess.Abstract;
using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Concrete.EntityFramework.Context
{
    public class EfProductDal : EfEntityRepositoryBase<Product, ShoppingContext>, IProductDal
    {

    }
}
