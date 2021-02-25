﻿using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;
using FluentValidation;

namespace Business.ValidationRules.FluentValidation
{
    public class ColorValidator : AbstractValidator<Color>
    {
        public ColorValidator()
        {
            RuleFor(p => p.ColorName).NotEmpty();
            RuleFor(p => p.ColorName).NotNull();
            RuleFor(p => p.ColorName).MinimumLength(3);
        }
    }
}
