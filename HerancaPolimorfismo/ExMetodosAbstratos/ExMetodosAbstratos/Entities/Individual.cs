namespace ExMetodosAbstratos.Entities
{
    internal class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual() : base() { }

        public Individual(string name, double anualIncome, double healthExpenditures) : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Tax()
        {
            double taxPercentage = 0.0;

            if (AnualIncome < 20000)
            {
                taxPercentage = 0.15;
            }
            else
            {
                taxPercentage = 0.25;
            }

            return (taxPercentage * AnualIncome) + (HealthExpenditures * 0.5);
        }
    }
}
