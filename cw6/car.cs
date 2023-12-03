using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Car
    {
        private string marka;
        private int rok;
        private string model;
        private int iloscDrzwi;
        private int pojemnoscSilnika;
        public double sredniespalanie;
        public Car(string marka, int rok)
        {
            if(rok<=1769 || rok > 2017)
            {
                while(rok<=1769 || rok > 2017)
                {
                    Console.WriteLine("Podales zly rok podaj jeszcze raz: ");
                    rok = Convert.ToInt32(Console.ReadLine());
                }
            }
            this.marka = marka;
            this.rok = rok;

        }
        public void wyswietl()
        {
            Console.WriteLine("Marka: {0} Rok:{1}", this.marka, this.rok);
        }
        private double ObliczSpalanie(double dlugoscTrasy)
        {
            return (this.sredniespalanie * dlugoscTrasy);
        }
        public double ObliczKosztPrzejazdu(double dlugosctrasy,double cenaPaliwa)
        {
            return ObliczSpalanie(dlugosctrasy) * cenaPaliwa;
        }
    }

}
