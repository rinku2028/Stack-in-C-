using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp11
{
    class stackexample
    {
        public static void Main(string []args)
        {
            Stack st = new Stack();
            //push to the stack
            st.Push("Central London");
            st.Push("East London");
            st.Push("North London");
            st.Push("South East");
            st.Push("Wembley");

            // Checking whether the element "Wembley" is present in the stack or not
            // Returns true if the element is present otherwise false
            Console.WriteLine(st.Contains("Wembley"));
            Console.ReadLine();
            //Output is True
        }
    }
}
