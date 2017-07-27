using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates1
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
            StringTester stringTester = new StringTester(checkForDigits);
            Console.WriteLine(stringTester("a 8 bc"));

        }
        
        bool checkForWhiteSpace(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsWhiteSpace(s[i]))
                {
                    return true;
                }
            }
            return false;
        }

        bool checkForDigits(string s)
        {
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                {
                    return true;
                }
            }
            return false;
        }



    }
}
