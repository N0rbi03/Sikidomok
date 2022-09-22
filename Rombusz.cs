using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Rombusz
    {
        double elsooldal;
        double atloegy;
        double atloketto;

        public Rombusz(double elsooldal, double atloegy, double atloketto)
        {
            this.elsooldal = elsooldal;
            this.atloegy = atloegy;
            this.atloketto = atloketto;
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
        public double Atloegy 
        { 
            get => atloegy; 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    atloegy = value;
                }
            }
        }
        public double Atloketto 
        {
            get => atloketto; 
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    atloketto = value;
                }
            }
        }

        public double Terulet()
        {
            return (Atloegy * Atloketto) / 2;
        }
        public double Kerulet()
        {
            return 4 * Elsooldal;
        }
    }
}
