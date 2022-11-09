using EntityLayer.Concrete;
using FluentValidation;
using FluentValidation.AspNetCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.ValidationRules
{
    public class BlogValidator:AbstractValidator<Blog>
    {
        public BlogValidator()
        {
            RuleFor(x => x.BlogTitle).NotEmpty().WithMessage("Blog title must be filled");
            RuleFor(x => x.BlogContent).NotEmpty().WithMessage("Blog content must be filled");
            RuleFor(x => x.BlogImage).NotEmpty().WithMessage("Blog image must be filled");
            RuleFor(x => x.BlogTitle).MaximumLength(150).WithMessage("Maximum 150 character is allowed");
            RuleFor(x => x.BlogTitle).MinimumLength(5).WithMessage("Type min 5 characters");
        }
    }
}
