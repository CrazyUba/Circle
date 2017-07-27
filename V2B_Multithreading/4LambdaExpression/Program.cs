using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4LambdaExpression
{
    class Program
    {
        void DoIt()
        {
            List<int> list = new List<int> { 14, 2, 4, 666, 7, 5, 77, 4 };
            list.Sort(
                (x, y) => { return x - y; }
            );
            for (int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }
        }

        static void Main(string[] args)
        {
            new Program().DoIt();
        }
    }
}
