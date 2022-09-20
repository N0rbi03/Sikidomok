using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sikidomok
{
    class Sikidomok
    {
        static void Main(string[] args)
        {
            haromszog haromszog = new haromszog(2,2,2,2);
            try
            {
                haromszog.Elsooldal = 0;
            }
            catch (ArgumentOutOfRangeException vita)
            {
                Console.WriteLine(vita.Message);
            }

            Teglalap teglalap = new Teglalap(3,2);
            try
            {
                teglalap.Elsooldal = 0;
            }
            catch (ArgumentOutOfRangeException argu)
            {

                Console.WriteLine(argu.Message);
            }
            Kor kor = new Kor(3);
            //kor.Sugar = 3;
            try
            {
                kor.Sugar = -3;
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                
            }
            Console.WriteLine($"{kor.Sugar} sugarú kör kerülete: {kor.Kerulet():N2} területe: {kor.Terulet():N2} átmérője: {kor.Atmero}");
            
            
            Console.WriteLine("\nProgram vége");
            Console.ReadKey();
        }
    }
}
