using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;
using Core.Utilities.Result.Abstract;

namespace Business.Repositories.TanerRepository
{
    public interface ITanerService
    {
        Task<IResult> Add(Taner taner);
        Task<IResult> Update(Taner taner);
        Task<IResult> Delete(Taner taner);
        Task<IDataResult<List<Taner>>> GetList();
        Task<IDataResult<Taner>> GetById(int id);
    }
}
