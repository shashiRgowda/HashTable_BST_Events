using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public delegate void EventHandler(string x);

    class EventHandling
    {
        public class Operation
        {
            public event EventHandler xyz;
            public void Action(string a)
            {
                if (xyz != null)
                {
                    xyz(a);

                    Console.WriteLine(a);
                }
                else
                {
                    Console.WriteLine("Not Registered");
                }
            }
        }
        private static void CatchEvent(string s)
        {
            Console.WriteLine("Method Calling");
        }
        private static void CatchEvent1(string s)
        {
            Console.WriteLine("Method Calling");
            int a = 5;
            a = a + 1;
            a += 1;
        }
        public static void ImplementEvent()
        {
            Operation o = new Operation();
            o.Action("Event Calling");
            Console.WriteLine();
            o.xyz += new EventHandler(CatchEvent);
            o.xyz += new EventHandler(CatchEvent1);
            o.Action("Event Called");
        }
    }


}