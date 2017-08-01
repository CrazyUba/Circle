using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _8AsyncIO
{
    class Program
    {
        static void Main(string[] args)
        {
            //FileStream fs = new FileStream("Test.txt", FileMode.Open);
            FileStream fs = File.OpenRead("Test.txt");
            byte[] buf = new byte[1024];

            StateObject stateObject = new StateObject();
            fs.BeginRead(buf, 0, 1024, ReadCallBack, stateObject);

            Console.ReadLine();
        }

        static void ReadCallBack(IAsyncResult asyncResult)
        {

        }
        
    }




    class StateObject
    {
    }
}
