namespace Danse_konkurrence
{
    internal class DancerPoints
    {
        internal string navn;
        internal int points;
        internal DancerPoints(string navn, int points)
        {
            this.navn = navn;
            this.points = points;
        }
        public static DancerPoints operator+ (DancerPoints first, DancerPoints last)
        {
            string navn = $"{first.navn} og {last.navn}";
            int points = first.points + last.points;
            DancerPoints total = new DancerPoints(navn, points);
            return total;
        }
    }
}
