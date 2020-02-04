<Query Kind="Expression">
  <Connection>
    <ID>78a0fcdc-f00b-42d6-93fd-2dc57ffd18b4</ID>
    <Persist>true</Persist>
    <Server>.</Server>
    <Database>WestWind</Database>
  </Connection>
</Query>

//A) List all the customer company names for those with more than 5 orders.

from CompanyName in Customers
where CompanyName.Orders.Count > 5
select CompanyName