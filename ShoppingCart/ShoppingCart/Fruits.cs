using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart
{
    class Fruits
    {
        

        public string Fname { get; set; }
        public double Fprice { get; set; }

       

        public Fruits(string fname)
        {
            Fname = fname.Trim();
            if (Fname == "APPLE")
            {
                Fprice = 0.60d;
            }
            else if (Fname == "ORANGE")
            {
                Fprice = 0.25d;
            }
            
            else
            {
                Console.WriteLine("We only sale Apple or Orange ");
            }
        }


    }
}
