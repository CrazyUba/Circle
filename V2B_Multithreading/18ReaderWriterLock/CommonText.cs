using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _18ReaderWriterLock
{
    class CommonText
    {
        string text = "";
        int writeCounter = 0;
        int readCounter = 0;

        public int WriteCounter { get { return writeCounter; } }
        public int ReadCounter { get { return readCounter; } }

        ReaderWriterLockSlim rwl = new ReaderWriterLockSlim();

        public string Read()
        {
            rwl.EnterReadLock();
            //readCounter++;    // => Falsche Werte!!!
            Interlocked.Increment(ref readCounter);
            rwl.ExitReadLock();
            return text;

            // rwl.ExitReadLock(); sollte in einen finally-Block gesetzt werden
        }

        public void Write(string s)
        {
            rwl.EnterWriteLock();
            text = s;
            //writeCounter++;   
            Interlocked.Increment(ref writeCounter);
            rwl.ExitWriteLock();
            return;

            // rwl.ExitWriteLock(); sollte in einen finally-Block gesetzt werden
        }

    }
}
