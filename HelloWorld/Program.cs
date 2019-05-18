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
            GlobalConfig.InitializeConnections(true, true);

            ConsoleConnector hello = new ConsoleConnector();
            Console.WriteLine(hello.Line);


            foreach (IDataConnection db in GlobalConfig.Connections)
            {
                db.Line = hello.Line;
            }


            hello.TranslateHelloWorld();

        }

        
    }
}
