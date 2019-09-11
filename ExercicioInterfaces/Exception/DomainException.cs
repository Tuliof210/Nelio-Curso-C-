using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Curso.Exceptions
{
    class DomainException : ApplicationException
    {
        public DomainException(string m) : base(m) { }
    }
}
