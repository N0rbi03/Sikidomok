using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Kor
    {
        double sugar;
        double atmero;

        public Kor(double sugar)
        {
            Sugar = sugar;
        }

        public double Sugar 
        { 
            get => sugar;
            set {
                
                    if (value<=0)
                    {
                    throw new ArgumentOutOfRangeException($"{value} érték nem megengedett a kör sugarának");
                    }
                    else
                    {
                        sugar = value;
                    }
                }
        }
        public double Atmero { get => 2*sugar; set => atmero = value; }

        public double Terulet()
        {
            return Sugar * 2 * Math.PI;
        }
        public double Kerulet()
        {
                return Sugar * Sugar * Math.PI;
        }


    }
}
