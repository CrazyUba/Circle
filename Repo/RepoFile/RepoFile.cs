using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo;
using System.IO;

namespace RepoImplementationAsFile 
{
    public class RepoFile : IRepo
    {
        public void Save(string text)
        {
            File.WriteAllText(@".\RepoFile.txt", text);

            //Alternative for string-array
            //string[] lines = { "First line", "Second line", "Third line" };
            //File.WriteAllLines(@".\RepoFile.txt", lines);

            //Alternative with stream
            //using (StreamWriter file = new StreamWriter(@".\RepoFile.txt"))
            //{
            //    file.Write(text);
            //}


            //https://msdn.microsoft.com/de-de/library/8bh11f1k.aspx


        }
    }
}
