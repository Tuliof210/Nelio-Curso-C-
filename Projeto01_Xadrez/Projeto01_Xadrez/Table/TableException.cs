using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    class TableException : ApplicationException
    {
        public TableException(string msg) : base(msg) { }
    }
}
