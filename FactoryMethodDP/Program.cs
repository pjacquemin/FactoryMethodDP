using FactoryMethod.QuoteMaker;
using QuoteFactoryMethod.EnterpriseQuoteMaker;
using QuoteFactoryMethod.SplittedQuoteMaker;

Console.WriteLine("Start");

var quoteMaker = new QuoteMaker();
quoteMaker.CreateQuote();

var enterpriseQuoteMaker = new EnterpriseQuoteMaker();
enterpriseQuoteMaker.CreateQuote();

var splittedQuoteMaker = new SplittedQuoteMaker();
splittedQuoteMaker.CreateQuote();