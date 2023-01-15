using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class Prime
    {

        List<int> Arp = new List<int>();
        List<int> Anp = new List<int>();



        public int j, x, k, val, flag = 0;
        public void prime(int start, int end)
        {
            for (k = start; k <= end; k++)
            {
                if (k == 1 || k == 0)
                    continue;

                int count = 0;
                for (j = 2; j <= k / 2; j++)
                {
                    if (k % j == 0)
                    {
                        count = 1;
                        break;

                    }
                }

                if (count == 0)
                {
                    Console.WriteLine(k);
                    Arp.Add(k);
                }


            }
        }
    }
}