using System;
using System.IO;

namespace Task10._1
{
    class Program
    {
        static readonly string logFilePath = @"log.txt";
        static void Main(string[] args)
        {
            FileSystemWatcher watcher = new FileSystemWatcher();
            watcher.Path = @"TestCatalog";
            watcher.Filter = "*.txt";

            watcher.Created += new FileSystemEventHandler(WatcherOnChanged);
            watcher.Changed += new FileSystemEventHandler(WatcherOnChanged);
            watcher.Deleted += new FileSystemEventHandler(WatcherOnChanged);
            watcher.Renamed += new RenamedEventHandler(WatcherOnRenamed);


            watcher.EnableRaisingEvents = true;
            Console.ReadLine();
        }

        static void WatcherOnChanged(object sender, FileSystemEventArgs e)
        {
            Log(string.Format("Changing({0}): {1}", e.ChangeType, e.FullPath));
        }

        static void WatcherOnRenamed(object sender, RenamedEventArgs e)
        {
            Log(string.Format("File {0} renamed to {1}", e.OldFullPath, e.FullPath));
        }

        static void Log(string message)
        {
            using (StreamWriter streamWriter = File.AppendText(logFilePath))
            {
                streamWriter.WriteLine(message);
            }
        }
    }
}
