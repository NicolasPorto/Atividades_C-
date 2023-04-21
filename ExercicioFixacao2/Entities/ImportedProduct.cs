using System.Globalization;

namespace ExercicioFixacao2.Entities
{
    internal class ImportedProduct : Product
    {
        public double customsFee { get; set; }

        public ImportedProduct()
        {
        }
        public ImportedProduct(string name, double price, double customsFee) : base(name, price)
        {
            this.customsFee = customsFee;
        }

        public double totalPrice()
        {

            return customsFee + Price;

        }

        public override string priceTag()
        {
            return Name + " $ " 
                        + totalPrice().ToString("F2", CultureInfo.InvariantCulture) 
                        + " (Customs fee: $ " 
                        + customsFee.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
