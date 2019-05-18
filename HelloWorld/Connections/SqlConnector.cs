using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class SqlConnector : IDataConnection
    {
        public string Line { get; set; }
        public string ShowLine { get; set; }
    }
}
