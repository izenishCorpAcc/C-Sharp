using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace netFramework
{
    internal class Dir
    {
        public static void DirectoryList() {
            var directories = Directory.GetDirectories(@"D:\Courses\Mastering SSIS", "*.*", SearchOption.AllDirectories);
            foreach(var d in directories)
            {
                Console.WriteLine(d);
            }

        }
    }
}
