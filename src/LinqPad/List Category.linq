<Query Kind="Program">
  <Connection>
    <ID>9d00dd66-f42b-46b7-886c-64785fe93a51</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

void Main()
{	
// List all the categories and the products in that category
// We need the name, description, and picture of the category,
// along with the name, quantity/unit, and price of the products.
	var result = from cat in Categories
				 select new CategorizedProducts
				 {
				 	 Name = cat.CategoryName,
					 Description = cat.Description,
					 Picture = cat.Picture.ToArray(),//.ToImage()
					 Products = from item in cat.Products
							    select new ProductInfo
							    {
							   		 Name = item.ProductName,
									 QuantityPerUnit = item.QuantityPerUnit,
									 Price = item.UnitPrice
							    }
				};
	result.Dump();
}

// Define other methods and classes here
public class ProductInfo // POCO class (Plain Old CLR Object)
{
	public string Name { get; set; }
	public string QuantityPerUnit { get; set; }
	public decimal Price { get; set; }
}

public class CategorizedProducts // DTO (Data Transfer Object)
{
	public string Name { get; set; }
	public string Description { get; set; }
	public byte[] Picture { get; set; }
	public IEnumerable<ProductInfo> Products { get; set; }
}















