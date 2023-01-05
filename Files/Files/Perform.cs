using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class Perform
    {
        // Read All Lines
        public static void ReadAllLines()
        {
            string path = @"E:\Visual Studio\.Net\FilesIO\Files\Files\TextFile1.txt";
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
        }
    }
}
