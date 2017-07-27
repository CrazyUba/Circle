using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousDelegates
{
    delegate bool StringTester(string s);

    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoIt();
        }

        void DoIt()
        {
            List<int> list = new List<int> { 4, 9, 1, 45, 42, 5, 7 };
            list.Sort(
                delegate(int x, int y) {
                    return x - y;
                }
            );

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        //int Ascending(int x, int y)
        //{
        //    return x - y; 
        //}

        //int Descending(int x, int y)
        //{
        //    return y - x;
        //}

    }
}
