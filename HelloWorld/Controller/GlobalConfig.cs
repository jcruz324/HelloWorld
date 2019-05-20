using HelloWorld.Connections.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>();
        public static void InitializeConnections(ConnectionType conn )
        {
            switch (conn)
            {
                case ConnectionType.SQL:
                    {
                        SqlConnector sql = new SqlConnector();
                        Connections.Add(sql);
                    }
                    break;
                case ConnectionType.TextFile:
                    {
                        TextConnector text = new TextConnector();
                        Connections.Add(text);
                    }
                    break;
                case ConnectionType.Console:
                    {
                        ConsoleConnector cmd = new ConsoleConnector();
                        Connections.Add(cmd);
                    }
                    break;
                case ConnectionType.Web:
                    // Todo add logic here
                    break;
                case ConnectionType.Mobile:
                    // Todo add logic here
                    break;
                default:
                    // Todo add logic here
                    break;
            }
        }
    }
}
