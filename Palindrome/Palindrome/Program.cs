using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    public class Palindrome
    {
        static void Main(string[] args)
        {
            //Set operation mode
            int choise;
            while (true)
            {
                Console.WriteLine("Select operation mode:\n 1. Only letters and numerals\n 2. All sumbols");
                try
                {
                    string input = Console.ReadLine();
                    choise = Int32.Parse(input);
                    if ((choise != 1) && (choise != 2)) throw new ArgumentException();
                    break;
                }
                catch (SystemException)
                {
                    Console.WriteLine("Wrong choise! Please repeat.");
                }
            }

            //Read string
            string msg = Console.ReadLine();
            
            //Select operation mode
            if (choise == 1) msg = RemoveExtraChar(msg);
            
            Console.WriteLine(IsPalindrome(msg));
            Console.Read();
        }
        //Check is the msg polindrome?
        public static bool IsPalindrome(string msg)
        {
            for (int num = 0; num <=msg.Length/2;num++)
            {
                if (msg[0+num] != msg[msg.Length -num - 1]) return false;
            }

            return true;
        }

        //Remove all symbols without number and letter
        public static string RemoveExtraChar(string msg)
        {
            StringBuilder str = new StringBuilder(msg);
            int num = 0;
            while (num < str.Length)
            {
                if (!Char.IsNumber(str[num]) && !Char.IsLetter(str[num]))
                {
                    str.Remove(num, 1);
                    continue;
                }
                num++;
            }
            //Console.WriteLine(str.ToString());
            return str.ToString();
        }
        
    }
}
