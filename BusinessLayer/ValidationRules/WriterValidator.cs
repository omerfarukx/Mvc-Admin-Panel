using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class WriterValidator : AbstractValidator<Writer>
    {
        public WriterValidator()
        {
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.WriterSurName).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Boş Geçilemez");
            RuleFor(x => x.WriterSurName).MinimumLength(2).WithMessage("En az 2 karakter giriş yapın");
            RuleFor(x => x.WriterSurName).MaximumLength(50).WithMessage("Maksimum 50 karakterden fazla giriş yapmayın.");
        }
    }
}
