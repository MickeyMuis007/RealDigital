using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RealDigital.Application.Errors
{
    public class RecordNotFound : Exception
    {
        public RecordNotFound()
        {

        }

        public RecordNotFound(Guid id) : base($"Record for Id {id.ToString()}, was not found")
        {

        }
    }
}
