﻿using Entity.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
    public class CommentValidator : AbstractValidator<Comment>
    {
        public CommentValidator()
        {

        }
    }
}
