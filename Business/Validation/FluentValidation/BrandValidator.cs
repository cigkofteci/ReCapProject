﻿using Business.Constants;
using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Validation.FluentValidation
{
    public class BrandValidator:AbstractValidator<Brand>
    {
        public BrandValidator()
        {
            RuleFor(b => b.BrandName).NotEmpty();
            RuleFor(b => b.BrandName).MinimumLength(2);
        }
    }
}
