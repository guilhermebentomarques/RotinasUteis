using RotinasUteis.Diretorios;
using System.IO;

namespace RotinasUteis
{
    class Program
    {
        static void Main(string[] args)
        {
            string _sCaminhoRaiz = @"C:\Users\gmarques\Desktop\Cursos Alura";
            string[] subdiretorios = Directory.GetDirectories(_sCaminhoRaiz);
            Recursivo_RenomearArquivos.prcVarreDiretorio(_sCaminhoRaiz, subdiretorios);
        }
    }
}
