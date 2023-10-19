using FactoryMethod.QuoteMaker;


namespace QuoteFactoryMethod.EnterpriseQuoteMaker
{
    public class EnterpriseQuoteMaker : QuoteMaker
    {
        protected override EnterpriseInfo MakeCustomerInfo()
        {
            Console.WriteLine("Enterprise info");
            return new EnterpriseInfo();
        }
    }
}
