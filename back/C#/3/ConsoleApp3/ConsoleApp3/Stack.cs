using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Stack<t>
    {
        int size;
        int tos;
        t[] arr;

        public int Size { get => size; }
        public Stack(int _s)
        {
            size = _s;
            tos = -1;
            arr = new t[size];
        }
        public void Push(t a)
        {
            if (tos < size - 1) 
            {
                tos++;
                arr[tos] = a;
            }
            else
                Console.WriteLine("Stack Is Full");
        }
        public t Pop()
        {
            if (tos < - 1)
            {
                t b = arr[tos];
                tos--;
                return b;

            }
            else
            {
                Console.WriteLine("Stack Is Empty");
                throw new Exception();
            }


        }
    }
}
