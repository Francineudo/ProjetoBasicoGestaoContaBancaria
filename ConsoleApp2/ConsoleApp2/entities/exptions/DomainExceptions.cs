using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.entities.exptions
{
    internal class DomainExceptions : ApplicationException
    {
        public DomainExceptions(string message) : base (message) { }
    }
}
