<Query Kind="Expression">
  <Connection>
    <ID>9f795fec-6525-43c5-bbd0-2819df27768a</ID>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// Shipper Data.linq
// List the names and phone numbers of all the shippers
// along with the number of shipments they have done. 
// Use an anonymous type for yor results.
from company in Shippers
select new 
{
	Name = company.CompanyName,
	PhoneNumber = company.Phone, 
	NumberOfShipments = company.ShipViaShipments.Count()
}

