
namespace FactoryMethod.QuoteMaker
{
    public class QuoteMaker
    {
        public Quote CreateQuote()
        {
            var quote = MakeQuote();

            quote.CustomerInfo = MakeCustomerInfo();
            quote.ProductLines = MakeProductLines();
            quote.Total = MakeTotal();

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