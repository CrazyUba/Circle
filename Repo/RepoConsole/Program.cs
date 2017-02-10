using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Repo;
using RepoImplementationAsFile;


namespace RepoConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                IRepo repo = new RepoFile();

                Console.WriteLine("Write some words which should be stored");
                string text = Console.ReadLine();

                repo.Save(text);
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception occurs: " + e.Message);
            }
        }
    }

}
