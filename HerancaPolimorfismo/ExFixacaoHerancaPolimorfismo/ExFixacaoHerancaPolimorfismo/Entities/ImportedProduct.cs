using System.Text;
using System.Globalization;

namespace ExFixacaoHerancaPolimorfismo.Entities
{
    internal class ImportedProduct : Product
    {
        public double CustomsFee { get; set; }

        public ImportedProduct()  : base()
        {
        }

        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            CustomsFee = customsFee;
        }

        public override string PriceTag()
        {
            StringBuilder sb = new StringBuilder();

            sb.Append(base.PriceTag());
            sb.Append(" (Customs fee: $ ");
            sb.Append(CustomsFee.ToString("F2", CultureInfo.InvariantCulture));
            sb.Append(")");

            return sb.ToString();
        }

        public double TotalPrice()
        {
            return Price + CustomsFee;
        }
    }
}