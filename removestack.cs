using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class removestack
    {
        public static void Main(string []args)
        {
            Stack st = new Stack();
            st.Push("One");
            st.Push("Two");
            st.Push("Third");
            st.Push("Fourth");
            st.Push("Fifth");

            Console.WriteLine("Total number of element in stack:" + st.Count);//Output will be 5
            Console.WriteLine("Remove all the element from the stack");
            st.Clear();//Removes all the elment from stack
            Console.WriteLine("Total number of element in stack after clear:" + st.Count);//Output will be 0
            Console.ReadLine();

        }
    }
}
