using System.Diagnostics;

namespace Thread_2_lesson
{
    internal class Program
    {
        static object locker = new object();
        static void Main(string[] args)
        {
            Thread thread1 = new Thread(() => Print("salom"));
            thread1.Name = "Test 1 : ";
            Thread thread2 = new Thread(() => Print("hello"));
            thread2.Name = "Test 2 : ";
            Thread thread3 = new Thread(() => Print("privet"));
            thread3.Name = "Test 3 : ";

            thread1.Start();
            thread2.Start();
            thread3.Start();

        }
        public static void Print(string str)
        {
            lock (locker)
            {
                Console.Write(Thread.CurrentThread.Name);
                for (int i = 0; i < str.Length; i++)
                {
                    Console.Write(str[i]);
                }
                Console.WriteLine();
            }
        }
    }
}