using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class haromszog
    {
        double elsooldal;
        double masodikoldal;
        double harmadikoldal;
        double magassag;
        public haromszog(double elsooldal, double masodikoldal, double harmadikoldal,double magassag)
        {
            this.elsooldal = elsooldal;
            this.masodikoldal = masodikoldal;
            this.harmadikoldal = harmadikoldal;
            this.Magassag = magassag;
        }

        public double Elsooldal 
        { 
            get => elsooldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ez nem jó");
                }
                else
                {
                    elsooldal = value;
                }
            }
        }
        public double Masodikoldal { get => masodikoldal; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ez nem jó");
                }
                else
                {
                    masodikoldal = value;
                }
            }
        }
        public double Harmadikoldal { get => harmadikoldal; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ez nem jó");
                }
                else
                {
                    harmadikoldal = value;
                }
            }
        }
        public double Magassag { get => magassag; set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("ez nem jó");
                }
                else
                {
                    magassag = value;
                }
            }
        }

        public double terulet()
        {
            return Elsooldal*Magassag;
        }
        public double kerulet()
        {
            return Elsooldal + Masodikoldal + Harmadikoldal;
        }
    }
}
