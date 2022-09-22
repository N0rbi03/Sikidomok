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

            Negyzet negyzet = new Negyzet (30);
            try
            {
                //negyzet.Elsooldal = 0;
            }
            catch (ArgumentOutOfRangeException kidob3)
            {
                Console.WriteLine(kidob3.Message);
            }
            Console.WriteLine($"{negyzet.Elsooldal} oldalú négyzet kerülete: {negyzet.Kerulet():N2} területe: {negyzet.Terulet():N2}");


            Rombusz rombusz = new Rombusz(10,10,10);
            try
            {
                //rombusz.Atloegy=0;
            }
            catch (ArgumentOutOfRangeException kidob2)
            {

                Console.WriteLine(kidob2.Message);
            }
            Console.WriteLine($"{rombusz.Elsooldal} oldalú rombusz kerülete: {rombusz.Kerulet():N2} területe: {rombusz.Terulet():N2} átlói: {rombusz.Atloegy},{rombusz.Atloketto}");

            Deltoid deltoid = new Deltoid(2,2,2,2);
            try
            {
                //deltoid.Atloelso = 0;
            }
            catch (ArgumentOutOfRangeException kidob)
            {

                Console.WriteLine(kidob.Message);
            }

            Console.WriteLine($"{deltoid.Elsooldal},{deltoid.Masodikoldal} oldalú deltoid kerülete: {deltoid.Kerulet():N2} területe: {deltoid.Terulet():N2} átlói:{deltoid.Atloelso},{deltoid.Atlomasodik}");

            Paraleogramma paraleogramma = new Paraleogramma(2, 2, 2);
            try
            {
                //paraleogramma.Magassag_elsoodal=0;
            }
            catch (ArgumentOutOfRangeException nemjo)
            {
                Console.WriteLine(nemjo.Message);
                
            }
            Console.WriteLine($"{paraleogramma.Elsoldal},{paraleogramma.Masodikoldal} oldalú paraleogramma kerülete: {paraleogramma.Kerulet():N2} területe: {paraleogramma.Terulet():N2} , első oldal magassága: {paraleogramma.Magassag_elsoodal}");

            haromszog haromszog = new haromszog(2,2,2,2);
            try
            {
                //haromszog.Elsooldal = 0;
            }
            catch (ArgumentOutOfRangeException vita)
            {
                Console.WriteLine(vita.Message);
            }
            
            Console.WriteLine($"{haromszog.Elsooldal},{haromszog.Masodikoldal},{haromszog.Harmadikoldal} oldalú háromszög kerülete: {haromszog.Kerulet():N2} területe: {haromszog.Terulet():N2} magassága:{haromszog.Magassag}");

            Teglalap teglalap = new Teglalap(3,2);
            try
            {
                //teglalap.Elsooldal = 0;
            }
            catch (ArgumentOutOfRangeException argu)
            {

                Console.WriteLine(argu.Message);
            }
            Console.WriteLine($"{teglalap.Elsooldal},{teglalap.Masodikoldal} oldalú téglalap kerülete : {teglalap.Kerulet():N2} területe: {teglalap.Terulet():N2} ");

            Kor kor = new Kor(3);
            //kor.Sugar = 3;
            try
            {
                //kor.Sugar = -3;
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
