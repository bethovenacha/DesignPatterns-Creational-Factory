Factory pattern returns the right type of object based on a given condition. Kindly see the sample classes and read me.

To use this factory you need to instantiate the SavingsFactory() e.g.

var factory = new SavingsFactory() as ICreditUnionFactory;
var citysavings = factory.GetSavings("CITY-1234-234234");
var nationalsavings = factory.GetSavings("NATIONAL-12342-1234324");

OUTPUT:

console.log(citysavings.Balance);
console.log(nationalsavings.Balance);

