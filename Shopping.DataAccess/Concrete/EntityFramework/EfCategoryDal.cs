using Shopping.Core.DataAccess.Concrete.EntityFramework;
using Shopping.DataAccess.Abstract;
using Shopping.DataAccess.Concrete.EntityFramework.Context;
using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, ShoppingContext>, ICategoryDal
    {

    }
}
