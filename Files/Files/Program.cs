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
            string filePath = @"E:\Visual Studio\.Net\FilesIO\Files\Files\TextFile1.txt";
            Operation operation = new Operation();

            // for file exists
            Console.WriteLine("***** File exists *****");
            operation.FileExist(filePath);

            // reading all lines
            Console.WriteLine("***** Read Lines *****");
            operation.ReadAllLines(filePath);

            // for reading all text
            Console.WriteLine("***** Text Read *****");
            operation.ReadAllText(filePath);

            // copy file path 
            Console.WriteLine("***** Copy Path *****");
            operation.CopyFilePath(filePath);

            // delete file
            Console.WriteLine("***** Delete Path ***** ");
            operation.DeleteFile();
        }
    }
}
