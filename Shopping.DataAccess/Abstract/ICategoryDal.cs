using Shopping.Core.DataAccess.Abstract;
using Shopping.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shopping.DataAccess.Abstract
{
    public interface ICategoryDal : IEntityRepository<Category>
    {

    }
}
