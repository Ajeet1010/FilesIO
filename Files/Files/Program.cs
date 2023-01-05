using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class Program
    {
        static void Main(string[] args)
        {
            string path = @"E:\Visual Studio\.Net\FilesIO\Files\Files\TextFile1.txt";
            
            // Read All Text
            string lines;
            lines = File.ReadAllText(path);
            Console.WriteLine(lines);
        }
    }
}
