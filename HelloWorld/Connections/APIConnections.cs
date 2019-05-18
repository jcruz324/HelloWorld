using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.DataAccess
{
    class APIConnections
    {
        public static string FullFilePath(string fileName)
        {
            //return $"{ ConfigurationManager.AppSettings}";
            return $"{ ConfigurationManager.AppSettings }";
        }
    }
}
