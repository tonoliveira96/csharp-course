using System;

namespace SalesWebMvc.Services.Exceptions
{
    public class BdConcurencyException : ApplicationException
    {
        public BdConcurencyException(string message) : base(message)
        {
        }
    }
}
