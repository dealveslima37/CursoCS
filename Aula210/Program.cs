using System;
using System.Collections.Generic;
using System.IO;

namespace Aula210
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\temp\in.txt";

            try
            {
                List<string> list = new();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        var line = sr.ReadLine();
                        list.Add(line);
                    }
                }

                list.Sort();
                
                foreach (var line in list)
                {
                    Console.WriteLine(line);
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            
        }
    }
}