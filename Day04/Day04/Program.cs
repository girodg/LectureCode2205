using System;
using System.Collections.Generic;
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

            SaveGrades(filePath);
            List<double> grades = LoadGrades(filePath);
            foreach (double grade in grades) Console.WriteLine(grade);
        }

        private static List<double> LoadGrades(string filePath)
        {
            List<double> grades = new List<double>();
            if (File.Exists(filePath))
            {
                //using (StreamReader sr = new StreamReader(filePath))//1. Open the file
                //{
                //    string line = sr.ReadLine();
                //    string[] data = line.Split('?');
                //    foreach (var item in data)
                //    {
                //        if(double.TryParse(item, out double value))
                //            grades.Add(value);
                //    }
                //}//Ctrl+K,D to fix the formatting
                //OR...
                string fileData = File.ReadAllText(filePath);//open,read,close the file
                string[] data = fileData.Split('?');
                foreach (var item in data)
                {
                    if (double.TryParse(item, out double value))
                        grades.Add(value);
                }
            }
            return grades;
        }

        private static void SaveGrades(string filePath)
        {
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
