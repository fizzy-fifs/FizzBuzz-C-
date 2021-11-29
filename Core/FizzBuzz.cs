using System;
using System.Collections.Generic;

namespace Core
{
    public class FizzBuzz
    {
        public string generate(int count)
        {
            List<int> countList = new List<int>();

            for (int i = 1; i <= count; i++)
            {
                countList.Add(i);
            }
            return string.Join(", ", countList);
        }
    }
}
