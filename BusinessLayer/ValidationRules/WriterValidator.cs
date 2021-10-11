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
            RuleFor(x => x.WriterName).NotEmpty().WithMessage("Yazar Adını Boş Geçemezsiniz");
            RuleFor(x => x.WriterSurname).NotEmpty().WithMessage("Yazar Soyadı Boş Geçmeyiniz");
            RuleFor(x => x.WriterAbout).NotEmpty().WithMessage("Hakkında Boş Bırakamazsınız");
            RuleFor(x => x.WriterTitle).NotEmpty().WithMessage("Ünvanı Boş Bırakamazsınız");
            RuleFor(x => x.WriterSurname).MinimumLength(2).WithMessage("Lütfen En Az 2 Karekter Girişi Yapınız");
            RuleFor(x => x.WriterSurname).MaximumLength(20).WithMessage("Lütfen En Az 20 Karekterden Fazla Değer Girişi Yapınız");
RuleFor(x => x.WriterName).Must(x => x != null && x.ToUpper().Contains("A")).WithMessage("Hakkında kısmında en az bir a harfi içermelidir");
        }
    }
}
