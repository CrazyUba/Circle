using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates2
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().DoIt();
        }

        void DoIt()
        {
            List<int> list = new List<int> { 4, 9, 1, 45, 42, 5, 7 };
            list.Sort(Descending);

            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        int Ascending(int x, int y)
        {
            if (x < y) return -1;
            if (x == y) return 0;
            if (x > y) return 1;
            return 0;
            // Short way: return x - y; 
        }

        int Descending(int x, int y)
        {
            return y - x;
        }

    }
}
