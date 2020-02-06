<Query Kind="Expression">
  <Connection>
    <ID>9d00dd66-f42b-46b7-886c-64785fe93a51</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

// List all the categories and the products in that category
// We need the name, description, and picture of the category,
// along with the name, quantity/unit, and price of the products.
from cat in Categories
select new
{
	Name = cat.CategoryName,
	Description = cat.Description,
	Picture = cat.Picture,//.ToImage()
	Products = from item in cat.Products
			   select new
			   {
			   		Name = item.ProductName,
					QuantityPerUnit = item.QuantityPerUnit,
					Price = item.UnitPrice
			   }
}
