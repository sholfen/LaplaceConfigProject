using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laplace.Models
{
    public class ConnectionStringModel
    {
        public ConcurrentDictionary<string, string> ConnectionStrings { get; set; } = new ConcurrentDictionary<string, string>();
    }
}
