using System;
using System.Collections.Generic;
using System.Text;

namespace Agathas.Storefront.Domain
{
    public class ValueObjectIsInvalidException : Exception
    {
        public ValueObjectIsInvalidException(string message) : base(message)
        {
        }


    }
}
