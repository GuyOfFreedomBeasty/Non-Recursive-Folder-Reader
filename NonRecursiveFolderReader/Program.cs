using System;
using System.IO;

namespace NonRecursiveFolderReader
{
    internal class Program
    {
        public static void ReadDirectories(string path)
        {
            Stack<string> avalibleDirectories = new Stack<string>();
            avalibleDirectories.Push(path);

            while (avalibleDirectories.Count > 0)
            {
                var currentPath = avalibleDirectories.Pop();
                Console.WriteLine(currentPath);

                foreach (var directory in Directory.GetDirectories(currentPath))
                {
                    avalibleDirectories.Push(directory);
                }
            }
        }

        public static void Main(String[] args)
        {
            ReadDirectories("C:\\Users\\user\\Downloads\\MusicCS");
        }
    }
}