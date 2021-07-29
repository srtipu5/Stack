using System;

namespace Stack
{
    public class Stack
    {
        int top;
        public int Count{ get; private set; }
        int [] arr;
        readonly int Stack_Length = 100;
        public Stack()
        {
            top = -1;
            Count = 0;
            arr = new int[Stack_Length];
        }
       public void Push(int value)
        {
            if(Count == Stack_Length)
            {
                Console.WriteLine("Stack Overflow.");
                return;
            }
            arr[++top] = value;
            Count++;
        }
        public int Pop()
        {
            if (top < 0)
            {
                Console.WriteLine("Stack Underflow.");
                return 0;
            }

            int temp = arr[top];
            top--;
            Count--;
            return temp;
        }
        public int Peek()
        {
            if (top == -1)
            {
                Console.WriteLine("Stack Overflow.");
                return 0;
            }

            int temp = arr[top];
            return temp;
        }
        public bool IsEmpty()
        {
            if (top == -1)
            {
                return true;
            }
            return false;
        }
        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow.");
                return;
            }
            Console.WriteLine("Stack items are : ");
            for (int i = top; i >= 0; i--)
            {
                Console.WriteLine(arr[i]);
            }
            return;
        }
        public bool Contains(int value)
        {
            for (int i = top; i >= 0; i--)
            {
                if(value == arr[i])
                {
                    return true;
                }
            }
            return false;
        }
        public void Clear()
        {
            top = -1;
            Count = 0;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Stack myStack = new Stack();
            myStack.Push(1);
            myStack.Push(11);
            Console.WriteLine(myStack.Contains(10));
            myStack.PrintStack();

            Console.ReadKey();
        }
    }
}
