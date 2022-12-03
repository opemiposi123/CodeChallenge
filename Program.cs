using System;

namespace CodeChallenge
{
    public class Program
    {
        
        public static void Main(string[] args)
        {


            string word = "AfricanJournal";
            string a = word.Substring(0, word.Length / 2);
            string b = word.Substring(word.Length / 2);

            char[] aArray = a.ToCharArray();
            string aReverse = String.Empty;
            for (int i = aArray.Length - 1; i > -1; i--)
            {
                aReverse += aArray[i];
            }

            char[] bArray = b.ToCharArray();
            string bReverse = String.Empty;
            for (int i = bArray.Length - 1; i > -1; i--)
            {
                bReverse += bArray[i];
            }
            

        
 

        }
    }
}




