using System;
using System.Collections;

namespace ConsoleApp11
{
    class Stackprogram
    {
        static void Main(string[] args)
        {
            //program of stack using LIFO Concept
            Stack st = new Stack();
            st.Push(1);
            st.Push(2);
            st.Push(3);
            st.Push(4);
            st.Push(5);

            foreach(object o in st)
            {
                Console.WriteLine(o);
            }
            Console.WriteLine("Total number of stack:" + st.Count);
            Console.WriteLine("Fourth stack contains:" + st.Contains(4));
            Console.ReadLine();
            //output will be 5 4 3 2 1
            //output will be Total number of stack: 5
            //out put will be Fourth stack contains: True
        }
    }
}
