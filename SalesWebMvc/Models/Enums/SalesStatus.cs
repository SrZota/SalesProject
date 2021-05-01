using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesWebMvc.Models.Enums
{
    public enum SalesStatus : int
    {
        PENDING = 1,
        BILLED = 2,
        CANCELED = 3
    }
}
