using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarValidator:AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.CarId).NotEmpty();
            RuleFor(c => c.ModelYear).NotEmpty();
            RuleFor(c => c.DailyPrice).NotEmpty();
            RuleFor(c => c.Description).NotEmpty();
            RuleFor(c => c.ColorId).NotEmpty();
            RuleFor(c => c.BrandId).NotEmpty();
            RuleFor(c => c.ModelYear).GreaterThan(1985);
            RuleFor(c => c.CarId).GreaterThan(0);
            RuleFor(c => c.DailyPrice).GreaterThan(0);
            RuleFor(c => c.ColorId).GreaterThan(0);
            RuleFor(c => c.BrandId).GreaterThan(0);
        }
    }
}
