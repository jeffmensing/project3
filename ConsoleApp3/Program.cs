using System;
using System.Collections;
using System.Collections.Generic;
using FizzBuzzLib;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable numWordPairs = new Hashtable();
            numWordPairs.Add(2, "Boom");
            numWordPairs.Add(3, "Fizz");
            numWordPairs.Add(4, "Bam");
            numWordPairs.Add(5, "Buzz");
            numWordPairs.Add(25, "Boop");
            numWordPairs.Add(50, "Beep");

            int topNum = 15;
            //int topNum = int.MaxValue;
            Class1 cl = new Class1();
            for (int i = 0; i <= topNum; i++)
            {
                Console.WriteLine(cl.checkNumWordPair(i, numWordPairs));
            }
        }
    }
}
