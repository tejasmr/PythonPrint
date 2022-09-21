using System;
using System.Collections;

namespace Print
{
    public class Print
    {
        public static void print(params object[] objs)
        {
            Console.Write("[ ");
            foreach (var o in objs)
                InternalPrint(o);
            Console.WriteLine("]");
        }
        private static void InternalPrint(object o)
        {
            IEnumerable enumerable = (o as IEnumerable);
            if (enumerable != null && !(o is string))
            {
                Console.Write("[ ");
                foreach (var item in enumerable)
                {
                    Console.Write(item + " ");
                }
                Console.Write("] ");
            }
            else
            {
                Console.Write(o + " ");
            }
        }
    }
}
