﻿using System;

namespace NlogDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Add obj = new Add();
            obj.Sum(2, 0);
            Console.WriteLine("This is a Logger Demo");
        }
    }
}
