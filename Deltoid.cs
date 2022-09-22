using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    internal class Deltoid
    {

        double elsooldal;
        double masodikoldal;
        double atloelso;
        double atlomasodik;

        public Deltoid(double elsooldal, double masodikoldal, double atloelso, double atlomasodik)
        {
            this.elsooldal = elsooldal;
            this.masodikoldal = masodikoldal;
            this.atloelso = atloelso;
            this.atlomasodik = atlomasodik;
        }

        public double Elsooldal 
        {
            get => elsooldal;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
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
        public double Atloelso
        { 
            get => atloelso;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    atloelso = value;
                }
            }
        }
        public double Atlomasodik 
        { 
            get => atlomasodik;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }
                else
                {
                    atlomasodik = value;
                }
            }
            }

        public double Kerulet()
        {
            return 2*(Elsooldal+Masodikoldal);
        }
        public double Terulet()
        {
            return (Atloelso * Atlomasodik) / 2;
        }
    }
}
