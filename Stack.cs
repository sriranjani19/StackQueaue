﻿
   
using System;

namespace StackProblem

{
    class Program
    {
        //Wecome to the Stack Problem
        /// <summary>
        /// UC1 Stack and Queues push 70,30,56 values.
        /// </summary>

        public static void Main(string[] args)
        {
            Stack<int> st = new Stack<int>();
            st.Push(70);
            st.Push(30);
            st.Push(56);

            foreach (int i in st)
            {
                Console.WriteLine(i);
            }
        }
    }
}

