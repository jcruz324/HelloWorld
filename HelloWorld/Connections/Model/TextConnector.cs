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
        private readonly string fileName = "HelloWorld.txt";
        public string FullFilePath { get; set; }

        /// <summary>
        /// Constructor: For text files, use the app.config to find a spot to save the files 
        /// </summary>
        /// <param name="line">Hello World Line</param>
        public TextConnector(string line = "Hello World") 
        {
            Line = line;
            this.FullFilePath = APIConnections.ConfigFolder(this.fileName);
            
        }
        /// <summary>
        /// Print Hello World to a text file
        /// </summary>
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
