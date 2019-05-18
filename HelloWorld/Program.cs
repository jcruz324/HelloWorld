using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add connection types statically
            GlobalConfig.InitializeConnections(Connections.Model.ConnectionType.TextFile);
            GlobalConfig.InitializeConnections(Connections.Model.ConnectionType.Console);
            GlobalConfig.InitializeConnections(Connections.Model.ConnectionType.SQL);

            // call instance
            ConsoleConnector hello = new ConsoleConnector();
            hello.ShowLine();

            SqlConnector sqlHello = new SqlConnector();
            sqlHello.ShowLine();

            // call any api using interface
            foreach (IDataConnection conn in GlobalConfig.Connections)
            {
                conn.ShowLine();
            }

        }

        
    }
}
