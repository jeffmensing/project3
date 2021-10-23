using System;
using System.Collections;
using System.Collections.Generic;

namespace FizzBuzzLib
{
    public class Class1
    {
        public string checkNumWordPair(int num, Hashtable ht)
        {
            string rtValue = "";
            bool match = false;
            ICollection key = ht.Keys;

            foreach (int a in key)
            {
                if (num % a == 0)
                {
                    match = true;
                    rtValue += ht[a].ToString() + " ";    
                }
            }

            if (match)
                rtValue.Trim();
            else
                rtValue = num.ToString();

            return rtValue;
        }

    }
}
