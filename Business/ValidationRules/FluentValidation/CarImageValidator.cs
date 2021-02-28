using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CarImageValidator:AbstractValidator<CarImage>
    {
        public CarImageValidator()
        {
            RuleFor(x => x.CarId).NotEmpty();
            RuleFor(x => x.ImagePath).NotEmpty().WithMessage("Resim dosya yolu boş bırakılamaz");
        }
    }
}
