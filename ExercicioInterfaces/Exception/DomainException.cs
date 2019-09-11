using System;

namespace Curso.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string m) : base(m) { }
    }
}
