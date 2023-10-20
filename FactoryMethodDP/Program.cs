using FactoryMethod.QuoteMaker;
using QuoteFactoryMethod.EnterpriseQuoteMaker;
using QuoteFactoryMethod.SplittedQuoteMaker;

Console.WriteLine("Start");

var quoteMaker = new QuoteMaker();
quoteMaker.CreateQuote(quoteMaker);

var enterpriseQuoteMaker = new EnterpriseQuoteMaker();
quoteMaker.CreateQuote(enterpriseQuoteMaker);

var splittedQuoteMaker = new SplittedQuoteMaker();
quoteMaker.CreateQuote(splittedQuoteMaker);