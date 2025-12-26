 

namespace BridgeLabzConsoleApp.FileIO
{
    public class FileHandlingTask
    {
        public static void Main()
        {
            string path = "SampleFile.txt";
            string filedata = "Helooo! this is file handling";
            File.WriteAllText(path, filedata);
            Console.WriteLine("File created and content added successfully");

            string filecontent = File.ReadAllText(path);
            Console.WriteLine(filecontent);

            string newcontent = "\nHello this new line";
            File.AppendAllText(path,newcontent);
            Console.WriteLine("Content Added");


            string currentDirectoryPath = Directory.GetCurrentDirectory();
            Console.WriteLine(currentDirectoryPath);

            string newDirectoryPath = Path.Combine(currentDirectoryPath,"DataFolder");
            Directory.CreateDirectory(newDirectoryPath);

            string fullPathNow = Path.GetFullPath(newDirectoryPath);
            Console.WriteLine(fullPathNow);

            string LogPath = Path.Combine(fullPathNow, "app.log");
            string logStarted = "\nApplication still started at : " + DateTime.Now;
            File.WriteAllText(LogPath,logStarted);

            string logEnded = "\nApplication getting stoped at : "+DateTime.Now;
            File.AppendAllText(LogPath, logEnded);
            string applog = File.ReadAllText (LogPath);
            Console.WriteLine(applog);

        }
    }
}
