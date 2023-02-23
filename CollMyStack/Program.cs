using System;
using System.Collections.Generic;


namespace CollMyStack
{
    public class MyStack<T>
    {
        Stack<T> stack;
        public void Push(T item)
        {
            stack.Push(item);
        }

        public T Pop()
        {
            return stack.Pop();
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> temp = new MyStack<int>();

            temp.Push(1);
            Console.WriteLine(temp.Pop());
        }
    }

}