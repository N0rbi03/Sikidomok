using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Teglalap
    {
        double elsooldal;
        double masodikoldal;
        public Teglalap(double elsooldal, double masodikoldal)
        {
            Elsooldal = elsooldal;
            Masodikoldal = masodikoldal;
        }
        public double Elsooldal
        {
            get => elsooldal;
            set
            {
                if (value<=0)
                {
                    throw new ArgumentOutOfRangeException($"nem jó");
                }
                else
                {
                    elsooldal = value;
                }
                
            }
        }
        public double Masodikoldal 
        { 
            get => masodikoldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    masodikoldal = value;
                }

            }
        }

        

        public double terulet()
        {
            return Elsooldal*Masodikoldal;
        }
        public double kerulet()
        {
            return 2*(Elsooldal+Masodikoldal);
        }
        
    }

}
