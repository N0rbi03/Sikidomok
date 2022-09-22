using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Negyzet
    {
        double elsooldal;

        public Negyzet(double elsooldal)
        {
            this.elsooldal = elsooldal;
        }

        public double Elsooldal 
        {
            get => elsooldal;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    elsooldal = value;
                }
            }
        }

        public double Terulet()
        {
            return Elsooldal * Elsooldal;
        }
        public double Kerulet()
        {
            return 4 * Elsooldal;
        }
    }
}
