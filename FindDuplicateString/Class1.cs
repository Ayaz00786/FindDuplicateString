using System;
using System.Collections.Generic;
using System.Text;

namespace FindDuplicateString
{
    internal class Class1
    {
        public static void Duplicate()
        {

            string data = "Noida short for New Okhla Industrial Development Authority, is a planned city located in Gautam Buddha Nagar district of the Indian state of Uttar Pradesh.";

            int count;
            char[] charArr = data.ToCharArray();

            for (int i = 0; i < charArr.Length; i++)
            {
                count = 1;
                for (int j = i + 1; j < charArr.Length; j++)
                {
                    if (charArr[i] == charArr[j] && charArr[i] != ' ')
                    {
                        count++;
                        charArr[j] = '0';
                    }
                }
                if (count > 1 && charArr[i] != '0')
                {
                    Console.WriteLine(charArr[i]);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
