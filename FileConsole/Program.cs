using System;
using System.IO;

namespace FileConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "";
            Console.WriteLine("Hello World! Enter path for magic numbers");

            // var test = new FileReader();
            // test.createfile("MagicNumbers.txt");

            path = Console.ReadLine();
            while (string.IsNullOrEmpty(path) || !File.Exists(path))
            {
                Console.WriteLine("Invalid file path! Please enter a valid path");
                path = Console.ReadLine();
            }
            string number;
            Console.Write("Type a number, and then press Enter: ");
            number = Console.ReadLine();
            double cleanNum = 0;
            while (!double.TryParse(number, out cleanNum))
            {
                Console.WriteLine("Please enter a valid number");
                number = Console.ReadLine();
            }
            FileReader f = new FileReader();
            double result = f.GenMagicNum(cleanNum, path);

            Console.WriteLine("magic number is " + result);
        }
    }
}
