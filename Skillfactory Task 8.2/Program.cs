using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using Skillfactory_Task_8._2;

class Program
{
    static void Main(string[] args)
    {
        string path = @"C:\\Skillfactory\";
        DirectoryInfo dirinfo = new DirectoryInfo(path);
        WriteFolderInfo(dirinfo);
    }

    static void WriteFolderInfo(DirectoryInfo folder)
    {
        try
            {
                Console.WriteLine(folder.Name + $"- {DirectoryExtension.DirSize(folder)} байт");
            }
        
        catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        
    }

}