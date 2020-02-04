<Query Kind="Expression">
  <Connection>
    <ID>78a0fcdc-f00b-42d6-93fd-2dc57ffd18b4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the shippers and the products that they shipped.
// Include the company name and phone of the shipper
// along with the name and quantity of the items shipped.

// TODO: Also read the Notes-->Ling Intro and 
// 		 the Demos -> eRestaurant -> Linq - Query and Method Syntax

from eachRow in Shippers
select new
{
	Company = eachRow.CompanyName,
	Phone = eachRow.Phone,
	ItemsShipped = from shipped in eachRow.ShipViaShipments
				   from item in shipped.ManifestItems
				   select new
				   {
				   		Product = item.Product.ProductName,
						Qty = item.ShipQuantity
				   }
}