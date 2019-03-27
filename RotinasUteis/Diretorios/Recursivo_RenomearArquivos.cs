using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RotinasUteis.Diretorios
{
    public static class Recursivo_RenomearArquivos
    {
        //MAIN
        //string _sCaminhoRaiz = @"C:\Users\gmarques\Desktop\Cursos Alura";
        //string[] subdiretorios = Directory.GetDirectories(_sCaminhoRaiz);
        //prcVarreDiretorio(_sCaminhoRaiz, subdiretorios);

        public static void prcVarreDiretorio(string currentDir, string[] subdiretorios)
        {
            #region FOREACH DirectoryInfoS E FileInfoS.

            List<FileInfo> files;
            string[] directories;

            directories = Directory.GetDirectories(currentDir);
            foreach (string directory in directories)
            {
                DirectoryInfo dif = new DirectoryInfo(directory);
                files = dif.GetFiles().OrderBy(x => x.LastWriteTime).ToList();

                int count = 0;
                foreach (FileInfo file1 in files)
                {
                    try
                    {
                        string newName = count.ToString() + "_" + dif.Name + ".mp4";
                        string oldName = file1.Name;
                        File.Move(file1.FullName, file1.FullName.Replace(oldName, newName));
                    }
                    catch { }
                    count++;
                }

                //PROCESSAR RECURSIVAMENTE
                prcVarreDiretorio(directory, subdiretorios);
            }

            #endregion
        }
    }
}
