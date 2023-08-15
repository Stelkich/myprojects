using System;
using System.Threading;
namespace _46306r_SP_Threads
{
    public class Threads
    {
       public static void Thread1()
        {
            for (int i = 0; i <= 25; i++)
            {
                Console.WriteLine("Thread1: "+i);
            }
            
            Console.WriteLine("Thread 1 is done counting to 25");
        } //0-25


        public static void Thread2()
        {
            Thread.Sleep(2000);
            for (int i = 25; i<=50; i++)
            { 
                Console.WriteLine("Thread2: " + i); 
            }
            
            Console.WriteLine("Thread 2 is done counting to 50");
        } //25-50


        public static void Thread3() {
            Thread.Sleep(4000);
            for (int i = 50; i <= 75; i++)
            { Console.WriteLine("Thread3: " + i); }
            
            Console.WriteLine("Thread 3 is done counting to 75");
        }//50-75


        public static void Thread4()
        {
            Thread.Sleep(6000);
            for (int i = 75; i <= 100; i++)
            { Console.WriteLine("Thread4: " + i); }
            
            Console.WriteLine("Thread 4 is done counting to 100!");
        }//75-100
    }
    class Program
    {
        static void Main(string[] args)
        {
            Thread th1 = new Thread(Threads.Thread1);
            th1.Start();
            Thread th2 = new Thread(Threads.Thread2);
            th2.Start();
            Thread th3 = new Thread(Threads.Thread3);
            th3.Start();
            Thread th4 = new Thread(Threads.Thread4);
            th4.Start();
        }
    }
}
