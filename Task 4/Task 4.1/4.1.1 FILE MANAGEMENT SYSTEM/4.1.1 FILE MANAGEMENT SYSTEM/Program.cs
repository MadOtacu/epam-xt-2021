using Microsoft.VisualBasic.FileIO;
using System;
using System.IO;

namespace _4._1._1_FILE_MANAGEMENT_SYSTEM
{
    class Program
    {
        static FileWorker fileWorker;

        static void Main(string[] args)
        {
            fileWorker = new FileWorker();

            string choosenCase;

            bool caseChecker = false;

            Console.WriteLine("1. Отслеживание изменений");
            Console.WriteLine("2. Бекап");
            Console.WriteLine("3. Выход");

            while (true)
            {
                Console.Write("Выберите номер пункта:");
                do
                {
                    choosenCase = Console.ReadLine();

                    if (choosenCase == "1" || choosenCase == "2" || choosenCase == "3")
                    {
                        caseChecker = true;
                    }
                    else
                    {
                        Console.WriteLine("Введите число от 1 до 3!");
                    }
                }
                while (caseChecker == false);

                switch (choosenCase)
                {
                    case "1":
                        fileWorker.Activate();
                        Console.ReadLine();
                        break;
                    case "2":
                        Backup();
                        break;
                    case "3":
                        return;
                    default:
                        break;
                }
            }
        }

        static void Backup()
        {
            bool checker = false;

            string[] backups = fileWorker.GetBackups();

            for (int i = 0; i < backups.Length; i++)
            {
                Console.WriteLine($"{i} - {backups[i]}");
            }

            while (checker == false)
            {
                string input = Console.ReadLine();

                checker = int.TryParse(input, out int i);

                if (i >= 0 || i <= backups.Length)
                {
                    fileWorker.Copy(backups[i]);
                }
                else 
                {
                    Console.WriteLine("Введите корректное значение!");
                    checker = false;
                }
            }
        }
    }

    class FileWorker
    {
        string backupFolder = @"D:\Program Files (x86)\TestFolder\backup";

        string sourceFolder = @"D:\Program Files (x86)\TestFolder";

        public void Activate()
        {
            using var watcher = new FileSystemWatcher(sourceFolder);

            watcher.NotifyFilter = NotifyFilters.FileName
                                 | NotifyFilters.LastAccess
                                 | NotifyFilters.LastWrite;

            watcher.Changed += OnChanged;
            watcher.Created += OnChanged;
            watcher.Deleted += OnChanged;
            watcher.Renamed += OnChanged;

            watcher.Filter = "*.txt";
            watcher.IncludeSubdirectories = true;
            watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object sender, FileSystemEventArgs e)
        {
            var folderName = DateTime.Now.ToString("dd-MM-yyyy");
            FileSystem.CopyDirectory(sourceFolder, backupFolder + "\\" + folderName);
        }

        public void Copy(string path)
        {
            FileSystem.CopyDirectory(path, sourceFolder);
        }

        public string[] GetBackups()
        {
            return Directory.GetDirectories(backupFolder);
        }
    }
}
