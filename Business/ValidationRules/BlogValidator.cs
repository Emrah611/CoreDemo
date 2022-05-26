using EntityLayer.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.ValidationRules
{
    public class BlogValidator : AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog basligini bos gecemezsiniz");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Lutfen 150 karakterden az veri girisi yapin");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Lutfen 5 karakterden fazla veri girisi yapin");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog icerigini bos gecemezsiniz");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog gorselini bos gecemezsiniz");
        }
    }
}
