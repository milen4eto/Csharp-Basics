using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpyHard
{
    class SpyHard
    {
        static void Main()
        {
            int key = int.Parse(Console.ReadLine());
            string message = Console.ReadLine();
            message = message.ToLower();
            int sum = 0;

            char[] messageArray = message.ToCharArray();

            for (int i = 0; i < messageArray.Length; i++)
            {
                if (Char.IsLetter(messageArray[i]))
                {
                    sum += (int)messageArray[i] - 96;
                }
                else
                {
                    sum += (int)messageArray[i];
                }
            }
            string codeMessage = Base10ToBaseX(sum, key);
            Console.WriteLine("{0}{1}{2}",key,message.Length,codeMessage);
        }
        static string Base10ToBaseX(int sum, int x)
        {
            string h = String.Empty;

            for (; sum != 0; sum /= x) h = GetChar(sum % x) + h;

            return h;
        }
        static char GetChar(int i)
        {
            if (i >= 10) return (char)('A' + i - 10);
            else return (char)('0' + i);
        }
    }
}
