using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld.DataAccess
{
   public class APIConnections
    {
        public static string ConfigFolder(string fileName)
        {
            string overrideFolder = System.Environment.GetEnvironmentVariable("USERPROFILE");
            string returnText;
            
            //Override text location to accomdate user's machine
            Configuration config =
           ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);

            config.AppSettings.Settings.Remove("filePath");
            config.AppSettings.Settings.Add("filePath", overrideFolder);
            config.Save(ConfigurationSaveMode.Minimal);

            returnText = $"{ ConfigurationManager.AppSettings["filePath"] + "\\" }";

            return returnText + fileName;


            // todo House Database Connections 
        }

    }
}
