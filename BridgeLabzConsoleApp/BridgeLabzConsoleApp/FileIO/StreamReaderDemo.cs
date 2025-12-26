
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.FileIO
{
    public class StreamReaderDemo
    {
        public static void Main()
        {
            
            using (StreamWriter sw = new StreamWriter("SampleDataFile.txt",true))
            {
                sw.WriteLine("This is sample text");

                sw.WriteLine("This is next line");
            }

            string path = "SampleDataFile.txt";

            using (StreamReader sr = new StreamReader(path))
            {
                string line;

                while ((line = sr.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
            }
        }
    
    }
}
