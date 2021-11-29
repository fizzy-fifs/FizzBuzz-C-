using System;
using System.Collections.Generic;

namespace Core
{
    public class FizzBuzz
    {
        public string generate(int count)
        {
            List<string> countList = new List<string>();

            for (int i = 1; i <= count; i++)
            {
                if(i % 3 == 0)
                {
                    countList.Add("Fizz");
                }
                else if (i % 5 == 0)
                {
                    countList.Add("Buzz");
                }
                else
                {
                    countList.Add(i.ToString());
                }
                
            }
            return string.Join(", ", countList);
        }
    }
}
