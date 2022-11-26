using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(x => x.CategoryName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.CategoryDescription).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.CategoryName).MinimumLength(3).WithMessage("En az 3 karakter giriş yapın");
            RuleFor(x => x.CategoryName).MaximumLength(20).WithMessage("Maksimum 20 karakterden fazla giriş yapmayın.");
        }
    }
}
