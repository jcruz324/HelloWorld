using HelloWorld.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    public class TextConnector : APIConnections, IDataConnection
    {
        public string Line { get; set; }

        private string LocalFilePath { get; set; }

        private readonly string fileName = "HelloWorld.txt";
        public string FullFilePath { get; set; }

        public TextConnector(string line = "Hello World")
        {
            Line = line;
            this.FullFilePath = APIConnections.ConfigFolder(this.fileName);
            
        }

        private string GetFileName()
        {
            return fileName;
        }


        public void ShowLine()
        {
       
                if (File.Exists(this.FullFilePath))
                {
                File.Delete(this.FullFilePath);
                }
            File.WriteAllText(this.FullFilePath, this.Line);
            Process.Start(this.FullFilePath);

        }



    }
}
