using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseAbstraction.Entities
{
    /// <summary>
    /// Example of a database entity to use for this demo project.
    /// </summary>
    public record SalesOrder(long Id, string Customer, DateTime OrderDate)
    {

    }
}
