using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Paraleogramma
    {
        double elsoldal;
        double masodikoldal;
        double magassag_elsoodal;

        public Paraleogramma(double elsoldal, double masodikoldal, double magassag_elsoodal)
        {
            this.elsoldal = elsoldal;
            this.masodikoldal = masodikoldal;
            this.magassag_elsoodal = magassag_elsoodal;
        }

        public double Elsoldal 
        { 
            get => elsoldal;
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    elsoldal = value;
                }
            }
        }
        public double Masodikoldal 
        { 
            get => masodikoldal;
            set 
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    masodikoldal=value;
                }
            }
        }
        public double Magassag_elsoodal 
        { 
            get => magassag_elsoodal;
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else 
                { 
                    magassag_elsoodal=value;
                }
            }
        }


        public double Terulet()
        { 
        return Elsoldal*Magassag_elsoodal;
        }
        public double Kerulet()
        {
            return 2 * (Elsoldal + Masodikoldal);
        }
    }
}
