using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.FileIO
{
    public class StreamReadeWriteTask
    {

        public static void Main()
        {
            string path = "notes.txt";

            using (StreamWriter sw = new StreamWriter(path,true))
            {
                sw.WriteLine("Line 1");
                sw.WriteLine("Line 2");
                sw.WriteLine("Line 3");
                sw.WriteLine($"Today's Date and Time {DateTime.Now}");
            }

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
