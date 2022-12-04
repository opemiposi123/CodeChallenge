using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeChallenge
{
    public class Exercise
    {
        public  void Swapping(string word)
        {
            try
            {
                string a = word.Substring(0, word.Length / 2);
                string b = word.Substring(word.Length / 2);

                char[] firstword = a.ToCharArray();
                char[] secondword = b.ToCharArray();

                string newA = string.Empty;
                string newB = string.Empty;
                var addword = newA + newB;

                int i;
                for (i = 0; i <= firstword.Length - 1; i++)
                {
                    bool even = i % 2 == 0;
                    bool odd = i % 2 != 0;
                    if (even)
                    {
                        newA += firstword[i] + "" + secondword[i];

                    }
                    else if (odd)
                    {
                        newB += firstword[i] + "" + secondword[i];
                    }

                    Console.WriteLine($"{newA} {newB}");
                }
                string reversed = String.Join(a, "", b);
                Console.WriteLine(reversed);

            }
            catch (Exception ex)
            {
               Console.WriteLine(ex.Message);
            }
         
        }
    }
}