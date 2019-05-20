using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using hw = HelloWorld;

namespace HelloWorld.Tests
{
    [TestClass]
    public class DisplayingHelloWorld
    {
        [TestMethod]
    public void ReturnConsoleCommand_UsingClassInstance()
        {
            // arrange
            var hello = new ConsoleConnector();
            // act
            hello.ShowLine();
            // assert
            Assert.AreEqual(hello.Line, "Hello World");
        }
        [TestMethod]
        public void ReturnConsoleCommand_UsingInterface()
        {
            // arrange
            GlobalConfig.InitializeConnections(Connections.Model.ConnectionType.Console);
;
            // act + assert
            foreach (IDataConnection conn in GlobalConfig.Connections)
            {

                if (conn is IDataConnection)
                 {   

                    if (conn.Line != "Hello World")
                    {
                        Assert.Fail();
                    }                  
                }
                else
                {
                    Assert.Fail();
                }
            
            }
            
        }

        
    }
}
