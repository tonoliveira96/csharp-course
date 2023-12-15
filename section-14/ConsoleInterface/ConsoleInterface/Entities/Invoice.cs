using System.Globalization;

namespace ConsoleInterface.Entities
{
    class Invoice
    {

        public double BasicPayment { get; set; }
        public double Tax { get; set; }

        public Invoice(double basicPayment, double tax)
        {
            BasicPayment = basicPayment;
            Tax = tax;
        }

        public double TotalPayment
        {
            get { return BasicPayment + Tax; }
        }

        public override string ToString()
        {
            return "Pagamento base: "
                + BasicPayment.ToString("F2", CultureInfo.InvariantCulture)
                + "\nImpostos: "
                + Tax.ToString("F2", CultureInfo.InvariantCulture)
                + "\nPagamento total: "
                + TotalPayment.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
