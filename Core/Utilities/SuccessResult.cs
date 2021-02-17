﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities
{
    public class SuccessResult : Result,IResult
    {
        public SuccessResult(string message):base(true, message)
        {

        }
        public SuccessResult():base(true)
        {

        }
    }
}