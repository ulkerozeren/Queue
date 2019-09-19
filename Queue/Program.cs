using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;

namespace Queue
{
    class Program
    {
        static ConcurrentQueue<string> queue = new ConcurrentQueue<string>();// thread safe
        public static void MailAdded()
        {
            while (true)
            {
                int tur = 1;
                queue.Enqueue("mail: "+ tur);
                tur++;
                Thread.Sleep(100);
            }       
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            new Thread(MailAdded).Start();

            //Queue<string> queue = new Queue<string>();
           

            //queue.Enqueue("data1"); //listeye alir
            //queue.Enqueue("data2"); //listeye alir
            //queue.Enqueue("data3"); //listeye alir
            //queue.Enqueue("data4"); //listeye alir
            //queue.Enqueue("data5"); //listeye alir
            //queue.Enqueue("data6"); //listeye alir
            //queue.Enqueue("data7"); //listeye alir
            //queue.Enqueue("data8"); //listeye alir

            while (true)
            {
                // string item = queue.Dequeue();
                queue.TryDequeue(out string item);
                if (item!=null)
                {
                    Console.WriteLine(item);
                }
                
                Thread.Sleep(200);
            }
        }
    }
}
