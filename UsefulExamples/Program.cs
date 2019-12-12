using UsefulExamples.Examples;
using System.IO;

namespace UsefulExamples
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\temp";
            string[] subDirectories = Directory.GetDirectories(path);
            RenameFilesRecursively.runDirectory(path, subDirectories);
        }
    }
}
