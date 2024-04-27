using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace words_on_cs
{
    public class ClassMain
    {
        public static void Main(string[] args)
        {
            
            List<string> engWords = new List<string>();
            try
            {
                foreach (string row in File.ReadAllLines(@"..\..\..\eng.txt"))
                {
                    engWords.Add(row);
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Error with the file!");
            }
        }
    }
}
