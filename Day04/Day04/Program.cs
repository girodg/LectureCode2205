using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace Day04
{
    enum Powers
    {
        Swimming, Speed, Flight, Money, Strength, Invisibilty
    }
    class Superhero
    {
        public string Name { get; set; }
        public string Secret { get; set; }
        public Powers Superpowers { get; set; }
    }

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

            List<Superhero> JL = new List<Superhero>();
            JL.Add(new Superhero() { Name = "Batman", Secret = "Bruce", Superpowers = Powers.Money });
            JL.Add(new Superhero() { Name = "Superman", Secret = "Clark", Superpowers = Powers.Flight });
            JL.Add(new Superhero() { Name = "Wonder Woman", Secret = "Diana", Superpowers = Powers.Strength });
            JL.Add(new Superhero() { Name = "Flash", Secret = "Barry", Superpowers = Powers.Speed });
            JL.Add(new Superhero() { Name = "Aquaman", Secret = "Arthur", Superpowers = Powers.Swimming });

            filePath = Path.ChangeExtension(filePath, ".json");
            SaveJson(filePath, JL);

            List<Superhero> jl2 = LoadJson(filePath);
            if (jl2 != null)
            {
                foreach (var hero in jl2)
                {
                    Console.WriteLine($"I am {hero.Name} ({hero.Secret}). And I can {hero.Superpowers}!");
                }
            }
        }

        private static List<Superhero> LoadJson(string filePath)
        {
            List<Superhero> heroes = null;
            if (File.Exists(filePath))
            {
                //1. read all the json into 1 string variable
                string jsonText = File.ReadAllText(filePath);
                //Ctrl+K,S -- surround with
                try
                {
                    heroes = JsonConvert.DeserializeObject<List<Superhero>>(jsonText);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            else
                Console.WriteLine($"{filePath} does not exists.");

            return heroes;
        }

        private static void SaveJson(string filePath, List<Superhero> JL)
        {
            //Serialize to a JSON file
            using (StreamWriter sw = new StreamWriter(filePath))
            {
                using (JsonTextWriter jtw = new JsonTextWriter(sw))
                {
                    jtw.Formatting = Formatting.Indented;
                    JsonSerializer serializer = new JsonSerializer();
                    serializer.Serialize(jtw, JL);
                }
            }
        }

        #region CSV

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
        #endregion
    }
}
