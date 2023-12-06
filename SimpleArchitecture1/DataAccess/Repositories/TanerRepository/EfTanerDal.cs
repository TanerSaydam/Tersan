using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using Entities.Concrete;
using DataAccess.Repositories.TanerRepository;
using DataAccess.Context.EntityFramework;

namespace DataAccess.Repositories.TanerRepository
{
    public class EfTanerDal : EfEntityRepositoryBase<Taner, SimpleContextDb>, ITanerDal
    {
    }
}
