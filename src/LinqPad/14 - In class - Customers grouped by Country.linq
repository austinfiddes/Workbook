<Query Kind="Expression">
  <Connection>
    <ID>78a0fcdc-f00b-42d6-93fd-2dc57ffd18b4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Display all the company names and contact names for our customers, grouped by country
from row in Customers
where row.Address.City.StartsWith("M")
group  row   by   row.Address.City into CustomersByCountry
//    \what/      \       how       /
where CustomersByCountry.Count() > 2
select new
{
   Country = CustomersByCountry, // the key is "how" we have sorted the data
   Customers = from data in CustomersByCountry
               select new
               {
			       Company = data.CompanyName,
				   Contact = data.ContactName
               }
}