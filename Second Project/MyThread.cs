using System;
using System.Threading;
using System.Text;

namespace Second_Project
{
    class MyThread
    {
        public void Thread1()
        {
            Thread t = Thread.CurrentThread;
            Console.WriteLine(t.Name+" is running");
        }
    }
}
