using System;

namespace Module2HW5.Exceptions
{
    class BusinessException : Exception
    {
        public BusinessException(string message) : base(message) { }
    }
}
