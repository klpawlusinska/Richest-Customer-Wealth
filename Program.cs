using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Richest_Customer_Wealth
{
    public class Solution
    {
        static int MaximumWealth(int[][] accounts)
        {
            int maxWealth = 0;

            foreach (int[] customer in accounts)
            {
                int sum = 0;

                foreach (int account in customer)
                {
                    sum += account;
                }

                if (sum > maxWealth)
                {
                    maxWealth = sum;
                }
            }
            return maxWealth;
        }
        static void Main(string[] args)
        {
            int[][] accounts = new int[][]
            {
                new int[] { 1, 2, 3 },
                new int[] { 4, 5, 6 },
                new int[] { 7, 8, 9 }
            };

            for (int i = 0; i < accounts.Length; i++)
            {
                Console.Write($"Klient {i + 1}: ");
                foreach (int account in accounts[i])
                {
                    Console.Write(account + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int wynik = MaximumWealth (accounts);
            Console.WriteLine("Największy majątek: " + wynik);
        }
    }
}
