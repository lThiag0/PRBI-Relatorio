using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;

namespace PRBIrelatorio
{
    class ReadConfig
    {
        public static string CaminhoDiretorio()
        {
            string path = @"c:\PRBI Relatorio\";
            if (ConfigurationManager.AppSettings["Diretorio"] != "")
            {
                DirectoryInfo dir = new DirectoryInfo(ConfigurationManager.AppSettings["Diretorio"]);
                if (dir.Exists)
                {
                    // Directory.GetFiles(Application.StartupPath + "\\Laudos", "*.xml", SearchOption.AllDirectories)
                    return ConfigurationManager.AppSettings["Diretorio"];
                }
                else
                {
                    Directory.CreateDirectory(path);
                    ConfigurationManager.AppSettings["Diretorio"] = path;
                    return path;
                }
            }
            else {
                Directory.CreateDirectory(path);
                ConfigurationManager.AppSettings["Diretorio"] = path;
                return path; 
            }
        }

    }
}
