
namespace FactoryMethod.QuoteMaker
{
    public class Quote
    {
        public CustomerInfo CustomerInfo { get; set; }
        public IEnumerable<ProductLine> ProductLines { get; set; }
        public Total Total { get; set; }

    }
}
