using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace FileConsole
{
    public class FileReader: IFileReader
    {
        public string[] Read(string path)
        {
            return File.ReadAllLines(path);
        }

        public void createfile(string path)
        {
            if (File.Exists(path))
            {
                File.Delete(path);
            }

            using (FileStream fs = File.Create(path))
            {
                // Add some text to file    
                for(int i = 1; i<5; i++)
                {
                    Byte[] num = new UTF8Encoding(true).GetBytes(i.ToString()+"\n");
                    fs.Write(num, 0, num.Length);
                }
   
            }
        }

        public double GenMagicNum(double input, IFileReader fileReader)
        {
            double result = 0;
            int choice = Convert.ToInt16(input);
            //Dependency------------------------------
            //   FileReader getTheMagic = new FileReader();
            //----------------------------------------
            string[] magicStrings = fileReader.Read("MagicNumbers.txt");
            if ((choice >= 0) && (choice < magicStrings.Length))
            {
                result = Convert.ToDouble(magicStrings[choice]);
            }
            result = (result > 0) ? (2 * result) : (-2 * result);
            return result;
        }
    }
}
