namespace NakladAuto
{
    internal class Tahac : NakladniAuto
    {
        private int nosnostNavesu;


        public Tahac(string spz, int nosnost, int nosnostNavesu) : base(spz, nosnost)
        {
            this.nosnostNavesu = nosnostNavesu;
            this.spz = spz;
            this.nosnost = nosnost + nosnostNavesu;
        }
        public override void NalozNaklad(int hmotnost)
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
        public override void VylozNaklad(int hmotnost)
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
            return "Tahač s spz: " + spz + " má nosnost: " + nosnost + "T a má naloženo: " + hmotnostNakladu + "T";

        }
    }
}
