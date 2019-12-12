using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace UsefulExamples.Examples
{
    public static class RenameFilesRecursively
    {
        public static void runDirectory(string currentDir, string[] subDirectory)
        {
            List<FileInfo> directoryFiles;
            string[] directories;

            directories = Directory.GetDirectories(currentDir);
            foreach (string directory in directories)
            {
                DirectoryInfo directoryInfo = new DirectoryInfo(directory);
                directoryFiles = directoryInfo.GetFiles().OrderBy(x => x.LastWriteTime).ToList();

                int count = 0;
                foreach (FileInfo file1 in directoryFiles)
                {
                    try
                    {
                        string newName = count.ToString() + "_" + directoryInfo.Name + file1.Extension;
                        string oldName = file1.Name;
                        File.Move(file1.FullName, file1.FullName.Replace(oldName, newName));
                    }
                    catch(Exception ex) {
                        string error = ex.Message;
                    }
                    count++;
                }

                runDirectory(directory, subDirectory);
            }
        }
    }
}
