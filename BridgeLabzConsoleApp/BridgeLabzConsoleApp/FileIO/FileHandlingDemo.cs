using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgeLabzConsoleApp.FileIO
{
    public class FileHandlingDemo
    {
        public static void Main()
        {
            string path = "sample.txt";
            string content = "Hello, this is my first file!";

            File.WriteAllText(path, content);

            Console.WriteLine("File written successfully.");

            string filecontent = File.ReadAllText(path);

            Console.WriteLine(filecontent);

            File.AppendAllText("sample.txt", "\nThis line is added later.");


            if (File.Exists("sample.txt"))
            {
                string text = File.ReadAllText("sample.txt");
                Console.WriteLine(text);
            }
            else
            {
                Console.WriteLine("File not found.");
            }


            string folderPath = "Data";

            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            string filePath = Path.Combine("Data", "info.txt");

            File.WriteAllText(filePath, "Stored inside Data folder");

            string filetext = File.ReadAllText(filePath);
            Console.WriteLine(filetext);


            string FolderPath = "LOG";

            if (!Directory.Exists(FolderPath))
            {
                Directory.CreateDirectory(FolderPath);
            }

            string FilePath = Path.Combine(FolderPath, "newSamp.log");
            File.WriteAllText(FilePath, "Stored in Log File");

            string FileText = File.ReadAllText(FilePath);
            Console.WriteLine(FileText);
            
        }
    }
}
