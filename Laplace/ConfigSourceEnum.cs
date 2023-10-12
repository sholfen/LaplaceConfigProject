using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laplace
{
    public enum ConfigSourceEnum
    {
        None = 0,
        Redis = 1,
        Azure = 2,
        AWS = 3,
        Database = 4,
        Memory = 5,
    }
}
