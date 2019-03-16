using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pralka
{

    class Program
    {
        static void Main(string[] args)
        {
            
            Pralka mojaPralka = new Pralka();
            mojaPralka.PodlaczDoProdu();
            mojaPralka.WlaczPralke();
            mojaPralka.WsypProszek("Ariel");
            mojaPralka.UruchomProgram("BIO");
            Console.ReadKey();
        }
    }
}
