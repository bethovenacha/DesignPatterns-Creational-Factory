Factory pattern returns the right type of object based on a given condition. Kindly see the sample classes and read me.

To use this factory you need to instantiate the SavingsFactory() e.g.
<br>
var factory = new SavingsFactory() as ICreditUnionFactory;<br>
var citysavings = factory.GetSavings("CITY-1234-234234");<br>
var nationalsavings = factory.GetSavings("NATIONAL-12342-1234324");

OUTPUT:

console.log(citysavings.Balance);<br>
console.log(nationalsavings.Balance);

