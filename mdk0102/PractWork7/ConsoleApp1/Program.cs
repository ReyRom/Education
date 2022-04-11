using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<FileInfo> files = new List<FileInfo>();
            DirectoryInfo directories = new DirectoryInfo(@"C:\Temp\pcs91-93") ;
            files = directories.GetFiles("*", SearchOption.AllDirectories).ToList();
            var date = DateTime.Now;
            var result = files.Where(f => f.LastWriteTime.ToShortDateString() == date.ToShortDateString()).ToList();
        }
    }
}
