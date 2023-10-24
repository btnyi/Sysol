using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DolgozatBatonyi
{
    class Solsys
    {
        public string bolygo { get; set; }
        public int holdSzam { get; set; }
        public double terfogat { get; set; }


        public Solsys(string s)
        {
            
            string[] v = s.Split(';');
            bolygo = v[0];
            holdSzam = int.Parse(v[1]);
            terfogat = Convert.ToDouble(v[2]);
            
        
        }

    }
}
