using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NakladAuto
{
    internal class NakladniAuto
    {
        private string spz;
        private int nosnost;
        private int hmotnostNakladu = 0;
       
        public int HmotnostNakladu
        {
            get
            {
                return hmotnostNakladu;
            }            
        }
        public NakladniAuto(string spz,int nosnost)
        {
            this.nosnost = nosnost;
            this.spz = spz;
        }
        public void NalozNaklad(int hmotnost)
        {
            if(hmotnost>nosnost)
            {

                hmotnostNakladu = hmotnost-(hmotnost-nosnost);


                MessageBox.Show("Náklad nebyl naložen celý, protože hmotnost je větší než nosnost! Nenaložilo se proto: " + (hmotnost - nosnost + "T"));
                
            }
            else
            {
                

                hmotnostNakladu = hmotnost;
                
            }
        }
        public void VylozNaklad(int hmotnost)
        {
            if(hmotnost>hmotnostNakladu)
            {
               
                MessageBox.Show("Chybí náklad:" + (hmotnost - hmotnostNakladu) + "T");
                hmotnostNakladu = 0;
            }
            else
            {
               
                hmotnostNakladu = hmotnostNakladu - hmotnost;
                
            }
        }

        public override string? ToString()
        {
                return "Nákladní auto " + spz + " má nosnost: " + nosnost + "T a má naloženo " + hmotnostNakladu + "T";
           
        }
    }
}
