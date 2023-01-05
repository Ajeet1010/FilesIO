﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    public class Operation
    {
        // File Exist or not 
        public void FileExist(string filePath)
        {
            if (File.Exists(filePath))
            {
                Console.WriteLine("File Exists ");
            }
            else
            {
                Console.WriteLine("File does not exist");
            }
        }

        // Reading the lines
        public void ReadAllLines(string filePath)
        {
            Console.WriteLine(" Welcome to read line ");
            if (File.Exists(filePath))
            {
                string[] lines;
                lines = File.ReadAllLines(filePath);
                Console.WriteLine(lines[0]);
                Console.WriteLine(lines[1]);
                Console.WriteLine(lines[2]);
                Console.WriteLine(lines[3]);
                Console.WriteLine(lines[4]);
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }
        }
        // Read All Text
        public void ReadAllText(string filePath)
        {
            if (File.Exists(filePath))
            {
                string lines = File.ReadAllText(filePath);
                Console.WriteLine(lines);                
            }
            else
            {
                Console.WriteLine("File Not Exist");
            }   
        }

        // Copying file path
        public void CopyFilePath(string filePath)
        {
            Console.WriteLine("Welcome to copy file path");
            // path of file where u want to copy the data of another file
            string copypath = @"E:\Visual Studio\.Net\FilesIO\Files\Files\TextFile2.txt";
            File.Copy(filePath, copypath, true);
        }

        // Delete file 
        public void DeleteFile()
        {
            Console.WriteLine("Welocme to Delte file");
            // path of the file u want to delete
            string path = @"E:\Visual Studio\.Net\FilesIO\Files\Files\TextFile2.txt";
            if (File.Exists(path))
            {
                 File.Delete(path);
                 Console.WriteLine("File Deleted");
            }
            else
            {
                Console.WriteLine("File not deleted");
            }
        }

        // Reading data using Stream Reader
        public void Read_StreamReader(string filePath)
        {
            using (StreamReader sr = File.OpenText(filePath))
            {
                string s = "";
                while ((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }
        }
    }
}
