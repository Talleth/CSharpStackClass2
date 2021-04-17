using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualProject
{
    public class Program
    {
        public static void Main(string[] pArguments)
        {
            StackClass stackClass = new StackClass();

            // Add items to the stack
            stackClass.Push("Laptop");
            stackClass.Push("Keyboard");
            stackClass.Push("Mouse");
            stackClass.Push("Speaker");
            stackClass.Push("Charger");
            stackClass.Push("Mobile");
            stackClass.Push("LED");
            stackClass.Push("LCD");

            // Write out stack information
            Console.WriteLine();
            Console.WriteLine("Stack Size - " + stackClass.Size);
            Console.WriteLine();
            Console.WriteLine("Printing stack:");
            Console.WriteLine();
            stackClass.PrintStack();
            Console.WriteLine();
            Console.WriteLine("Printing top 3 elements:");
            Console.WriteLine();

            // Pop 3 items then rewrite stack information
            Console.WriteLine(stackClass.Pop());
            Console.WriteLine(stackClass.Pop());
            Console.WriteLine(stackClass.Pop());
            Console.WriteLine();
            Console.WriteLine("Stack Size - " + stackClass.Size);
            Console.WriteLine();
        }
    }

    public  class StackClass
    {
        private int         m_maxSize;
        private int         m_top;
        private object[]    m_stack;

        public bool IsEmpty()
        {
            bool result = false;

            if (this.m_top < 0)
                result = true;

            return result;
        }

        public StackClass()
        {
            this.m_top      = -1;
            this.m_maxSize  = 1000;
            this.m_stack    = new object[this.m_maxSize];
        }

        public StackClass(int maxSize)
        {
            this.m_top      = -1;
            this.m_maxSize  = maxSize;
            this.m_stack    = new object[this.m_maxSize];
        }

        public bool Push(object data)
        {
            if (this.m_top >= this.m_maxSize)
                throw new StackOverflowException();
            else
                this.m_stack[++this.m_top] = data;

            return true;
        }

        public object Pop()
        {
            object result = null;

            if (this.m_top < 0)
                throw new Exception("Stack Underflow");
            else
                result = this.m_stack[this.m_top--];

            return result;
        }

        public object Peek()
        {
            object result = null;

            if (this.m_top < 0)
                throw new Exception("Stack Underflow");
            else
                result = this.m_stack[this.m_top];

            return result;
        }

        public void PrintStack()
        {
            if (this.m_top < 0)
                throw new Exception("Stack Underflow");
            else
            {
                Console.WriteLine("Following are the items in the stack:");
                Console.WriteLine();

                for (int i = this.m_top; i >= 0; i--)
                    Console.WriteLine(this.m_stack[i]);
            }
        }

        public int Size
        {
            get { return this.m_top + 1; }
        }
    }
}
