using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Headphones
{
    class Headphones
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            string asterisk = new string('*',n+2);
            string line = new string('-', n/2);
            Console.WriteLine(line + asterisk + line);

            string lineIn = new string('-', n);
            for (int i = 0; i < n - 1; i++)
            {
                Console.WriteLine(line + '*' + lineIn + '*' + line);
            }

            int k = (n / 2);
            int l = n;
            int j = 1;
            for (int i = 0; i < n/2; i++)
            {
                asterisk = new string('*',j);
                line = new string('-', k);
                lineIn = new string('-', l);

                Console.WriteLine(line + asterisk + lineIn + asterisk + line);
                    k--;
                    l -= 2;
                    j += 2;
            }

            asterisk = new string('*', n);
            Console.WriteLine(asterisk+ '-' + asterisk);

            l = 2;
            k = n-2;
            j = 1;

            for (int i = 0; i < n / 2; i++)
            {
                asterisk = new string('*', k);
                line = new string('-', j);
                lineIn = new string('-', l+1);

                Console.WriteLine(line + asterisk + lineIn + asterisk + line);

                    k -= 2;
                    j++;
                    l += 2;     
            }
        }
    }
}
