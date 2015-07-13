using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dice
{
    class Program
    {
        static void Main(string[] args)
        {
            int qt;
            string ans = "";
            Console.Write("Roll-the-dice ");
            qt = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Rolling {0} dice...", qt);
            float prob = 1;
            Random rnd = new Random();
            for (int i = 0; i < qt; i++)
            {                
                float dice = rnd.Next(1, 13);
                ans += dice + " ";
                
                prob *= (dice / 12);
            }

            Console.WriteLine("{0} (Probability: {1:0.000})", ans, prob);

            Console.ReadKey();
        }
    }
}
