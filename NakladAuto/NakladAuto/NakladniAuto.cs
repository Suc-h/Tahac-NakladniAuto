namespace NakladAuto
{
    internal class NakladniAuto
    {
        protected string spz;
        protected int nosnost;
        protected int hmotnostNakladu = 0;

        public int HmotnostNakladu
        {
            get
            {
                return hmotnostNakladu;
            }
        }
        public NakladniAuto(string spz, int nosnost)
        {
            this.nosnost = nosnost;
            this.spz = spz;
        }
        public virtual void NalozNaklad(int hmotnost)
        {
            MessageBox.Show("Nakládám....");
            if (hmotnost > nosnost)
            {

                hmotnostNakladu = nosnost;


                MessageBox.Show("Náklad nebyl naložen celý, protože hmotnost je větší než nosnost! Nenaložilo se proto: " + (hmotnost - nosnost + "T"));

            }
            else
            {


                hmotnostNakladu = hmotnostNakladu + hmotnost;

            }
        }
        public virtual void VylozNaklad(int hmotnost)
        {
            MessageBox.Show("Vykládám....");
            if (hmotnost > hmotnostNakladu)
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
