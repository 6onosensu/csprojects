using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_project
{
    public class Functions
    {
        public static void Greeting(string nimi)
        {
            Console.WriteLine("Tere kallis {0}", nimi);
        }

        public static int Korruta(int arv1, int arv2)            
        {
            return arv1*arv2;
        }
    }
}
