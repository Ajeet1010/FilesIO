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
            
            // Read All Lines
            string[] lines;
            lines = File.ReadAllLines(path);
            Console.WriteLine(lines[0]);
            Console.WriteLine(lines[1]);
            Console.WriteLine(lines[2]);
            Console.WriteLine(lines[3]);
            Console.WriteLine(lines[4]);
        }
    }
}
