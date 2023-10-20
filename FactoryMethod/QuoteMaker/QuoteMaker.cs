
namespace FactoryMethod.QuoteMaker
{
    public class QuoteMaker
    {
        public Quote CreateQuote(QuoteMaker quoteMaker)
        {
            var quote = quoteMaker.MakeQuote();

            quote.CustomerInfo = quoteMaker.MakeCustomerInfo();
            quote.ProductLines = quoteMaker.MakeProductLines();
            quote.Total = quoteMaker.MakeTotal();

            return quote;
        }

        protected virtual Quote MakeQuote()
        {
            return new Quote();
        }

        protected virtual CustomerInfo MakeCustomerInfo()
        {
            Console.WriteLine("Customer info");
            return new CustomerInfo();
        }

        protected virtual IEnumerable<ProductLine> MakeProductLines()
        {
            return new List<ProductLine>();
        }

        protected virtual Total MakeTotal()
        {
            return new Total();
        }

    }
}