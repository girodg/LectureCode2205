using System;
using System.IO;

namespace Day04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"C:\temp\2205\sample.txt";//full path
            filePath = @"..\..\..\sample.txt";//relative path
            filePath = "sample.txt";//current directory of the app

            using (StreamWriter sw = new StreamWriter(filePath))//1. open the file
            {
                //2. write to the file
                Random randy = new Random();
                char delimiter = '?';
                for (int i = 0; i < 10; i++)
                {
                    if (i != 0) sw.Write(delimiter);
                    sw.Write(randy.NextDouble() * 100);
                }
            }//3. CLOSE THE FILE!
        }
    }
}
