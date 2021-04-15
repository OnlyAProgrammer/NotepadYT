using System.IO;
using System.Windows.Forms;

namespace NotepadYT.Data
{
    internal static class DataController
    {
        internal static void Write(string path, string text)
        {
            try
            {
                File.WriteAllText(path, text);
            } catch
            {
                MessageBox.Show($"Houve um erro ao escrever o arquivo {path}", "Erro", MessageBoxButtons.OK);
            }
        }

        internal static string Read(string path)
        {
            if (!File.Exists(path))
                return null;

            return File.ReadAllText(path);
        }

        internal static string ExtractName(string path)
        {
            var parts = path.Split('\\');
            var nomecome = parts[parts.Length - 1].Split('.');

            return nomecome[0];
        }
    }
}
