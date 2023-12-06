using System;
using System.Collections.Generic;
using FluentValidation;
using System.Text;
using System.Threading.Tasks;
using Entities.Concrete;

namespace Business.Repositories.TanerRepository.Validation
{
    public class TanerValidator : AbstractValidator<Taner>
    {
        public TanerValidator()
        {
        }
    }
}
