using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarDetailDtoValidator:AbstractValidator<CarDetailDto>
    {
        public CarDetailDtoValidator()
        {
            RuleFor(cd => cd.BrandName).NotEmpty();
            RuleFor(cd => cd.CarName).NotEmpty();
            RuleFor(cd => cd.ColorName).NotEmpty();
            RuleFor(cd => cd.DailyPrice).NotEmpty();
            

        }
    }
}
