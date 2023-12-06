using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Repositories.TanerRepository;
using Entities.Concrete;
using Business.Aspects.Secured;
using Core.Aspects.Validation;
using Core.Aspects.Caching;
using Core.Aspects.Performance;
using Business.Repositories.TanerRepository.Validation;
using Business.Repositories.TanerRepository.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrete;
using DataAccess.Repositories.TanerRepository;

namespace Business.Repositories.TanerRepository
{
    public class TanerManager : ITanerService
    {
        private readonly ITanerDal _tanerDal;

        public TanerManager(ITanerDal tanerDal)
        {
            _tanerDal = tanerDal;
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(TanerValidator))]
        [RemoveCacheAspect("ITanerService.Get")]

        public async Task<IResult> Add(Taner taner)
        {
            await _tanerDal.Add(taner);
            return new SuccessResult(TanerMessages.Added);
        }

        [SecuredAspect()]
        [ValidationAspect(typeof(TanerValidator))]
        [RemoveCacheAspect("ITanerService.Get")]

        public async Task<IResult> Update(Taner taner)
        {
            await _tanerDal.Update(taner);
            return new SuccessResult(TanerMessages.Updated);
        }

        [SecuredAspect()]
        [RemoveCacheAspect("ITanerService.Get")]

        public async Task<IResult> Delete(Taner taner)
        {
            await _tanerDal.Delete(taner);
            return new SuccessResult(TanerMessages.Deleted);
        }

        [SecuredAspect()]
        [CacheAspect()]
        [PerformanceAspect()]
        public async Task<IDataResult<List<Taner>>> GetList()
        {
            return new SuccessDataResult<List<Taner>>(await _tanerDal.GetAll());
        }

        [SecuredAspect()]
        public async Task<IDataResult<Taner>> GetById(int id)
        {
            return new SuccessDataResult<Taner>(await _tanerDal.Get(p => p.Id == id));
        }

    }
}
