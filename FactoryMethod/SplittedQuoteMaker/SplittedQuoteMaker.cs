using FactoryMethod.QuoteMaker;


namespace QuoteFactoryMethod.SplittedQuoteMaker
{
    public class SplittedQuoteMaker : QuoteMaker
    {
        protected override IEnumerable<ProductLine> MakeProductLines()
        {
            Console.WriteLine("Splitted quote maker : MakeProductLines()");
            return new List<ProductLine>();
        }
    }
}
