using System.Globalization;

namespace ExMetodosAbstratos.Entities
{
    internal class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }
        public Company() : base() { }

        public Company(string name, double anualIncome, int numberOfEmployees) : base(name, anualIncome)
        { 
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Tax()
        {
            double taxPercentage = 0.0;

            if (NumberOfEmployees <= 10)
            {
                taxPercentage = 0.16;
            }
            else
            {
                taxPercentage = 0.14;
            }

            return AnualIncome * taxPercentage;
        }
    }
}