using NorthwindExercise.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NorthwindExercise.DAL
{
    public class NorthwindInitializer : CreateDatabaseIfNotExists<NorthwindContext>
    {
        protected override void Seed(NorthwindContext context)
        {
            var regionE = new Region { RegionDescription = "Eastern" };
            var regionW = new Region { RegionDescription = "Western" };
            var regionN = new Region { RegionDescription = "Northern" };
            var regionS = new Region { RegionDescription = "Southern" };
            context.Regions.Add(regionE);
            context.Regions.Add(regionW);
            context.Regions.Add(regionN);
            context.Regions.Add(regionS);
            context.SaveChanges();

            List<Employee> employees = new List<Employee>
            {
                new Employee { LastName = "Davolio", FirstName = "Nancy", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = Convert.ToDateTime(1948-12-08), HireDate = Convert.ToDateTime(1992-05-01), Address = "507 - 20th Ave. E.Apt. 2A", City = "Seattle" },
                new Employee { LastName = "Fuller", FirstName = "Andrew", Title = "Vice President, Sales", TitleOfCourtesy = "Dr.", BirthDate = Convert.ToDateTime(1952-02-19), HireDate = Convert.ToDateTime(1992-08-14), Address = "908 W. Capital Way", City = "Tacoma" },
                new Employee { LastName = "Leverling", FirstName = "Janet", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = Convert.ToDateTime(1963-08-30), HireDate = Convert.ToDateTime(1992-04-01), Address = "722 Moss Bay Blvd.", City = "Kirkland" },
                new Employee { LastName = "Peacock", FirstName = "Margaret", Title = "Sales Representative", TitleOfCourtesy = "Mrs.", BirthDate = Convert.ToDateTime(1937-09-19), HireDate = Convert.ToDateTime(1993-05-03), Address = "4110 Old Redmond Rd.", City = "Redmond" },
                new Employee { LastName = "Buchanan", FirstName = "Steven", Title = "Sales Manager", TitleOfCourtesy = "Mr.", BirthDate = Convert.ToDateTime(1955-03-04), HireDate = Convert.ToDateTime(1993-10-17), Address = "14 Garrett Hill", City = "London" },
                new Employee { LastName = "Suyama", FirstName = "Michael", Title = "Sales Representative", TitleOfCourtesy = "Mr.", BirthDate = Convert.ToDateTime(1963-07-02), HireDate = Convert.ToDateTime(1993-10-17), Address = "Coventry House Miner Rd.", City = "London" },
                new Employee { LastName = "King", FirstName = "Robert", Title = "Sales Representative", TitleOfCourtesy = "Mr.", BirthDate = Convert.ToDateTime(1960-05-29), HireDate = Convert.ToDateTime(1994-01-02), Address = "Edgeham Hollow Winchester Way", City = "London" },
                new Employee { LastName = "Callahan", FirstName = "Laura", Title = "Inside Sales Coordinator", TitleOfCourtesy = "Ms.", BirthDate = Convert.ToDateTime(1958-01-09), HireDate = Convert.ToDateTime(1994-03-05), Address = "4726 - 11th Ave. N.E.", City = "Seattle" },
                new Employee { LastName = "Dodsworth", FirstName = "Anne", Title = "Sales Representative", TitleOfCourtesy = "Ms.", BirthDate = Convert.ToDateTime(1966-01-27), HireDate = Convert.ToDateTime(1994-11-15), Address = "7 Houndstooth Rd.", City = "London" }
            };
            employees.ForEach(employee => context.Employees.Add(employee));
            context.SaveChanges();

            List<Category> categories = new List<Category>
            {
                new Category { CategoryName = "Beverages", Description = "Soft drinks, coffees, teas, beers, and ales" },
                new Category { CategoryName = "Condiments", Description = "Sweet and savory sauces, relishes, spreads, and seasonings" },
                new Category { CategoryName = "Confections", Description = "Desserts, candies, and sweet breads" },
                new Category { CategoryName = "Dairy Products", Description = "Cheeses" },
                new Category { CategoryName = "Grains/Cereals", Description = "Breads, crackers, pasta, and cereal" },
                new Category { CategoryName = "Meat/Poultry", Description = "Prepared meats" },
                new Category { CategoryName = "Produce", Description = "Dried fruit and bean curd" },
                new Category { CategoryName = "Seafood", Description = "Seaweed and fish" }
            };
            categories.ForEach(category => context.Categories.Add(category));
            context.SaveChanges();

            List<Customer> customers = new List<Customer>
            {
                new Customer { CustomerID = "ALFKI", CompanyName = "Alfreds Futterkiste", ContactName = "Maria Anders", ContactTitle = "Sales Representative", Address = "Obere Str. 57", City = "Berlin", PostalCode = "12209", Country = "Germany", Phone= "030-0074321", Fax = "030-0076545"},
                new Customer { CustomerID = "ANATR", CompanyName = "Ana Trujillo Emparedados y helados", ContactName = "Ana Trujillo", ContactTitle = "Owner", Address = "Avda. de la Constitución 2222", City = "México D.F.", PostalCode="05021", Country="Mexico", Phone= "(5) 555-4729", Fax= "(5) 555-3745" },
                new Customer { CustomerID = "ANTON", CompanyName = "Antonio Moreno Taquería", ContactName = "Antonio Moreno", ContactTitle = "Owner", Address = "Mataderos  2312", City = "México D.F.", PostalCode = "05023", Country = "Mexico", Phone = "(5) 555-3932" },
                new Customer { CustomerID = "AROUT", CompanyName = "Around the Horn", ContactName = "Thomas Hardy", ContactTitle = "Sales Representative", Address = "120 Hanover Sq.", City = "London", PostalCode="WA1 1DP", Country="UK", Phone="(171) 555-7788", Fax="(171) 555-6750"},
                new Customer { CustomerID = "BERGS", CompanyName = "Berglunds snabbköp", ContactName = "Christina Berglund", ContactTitle = "Order Administrator", Address = "Berguvsvägen  8", City = "Luleå", PostalCode="S-958 22", Country="Sweden", Phone= "0921-12 34 65", Fax="0921-12 34 67"},
                new Customer { CustomerID = "BLAUS", CompanyName = "Blauer See Delikatessen", ContactName = "Hanna Moos", ContactTitle = "Sales Representative", Address = "Forsterstr. 57", City = "Mannheim", PostalCode="68306", Country = "Germany", Phone= "0621-08460", Fax="0621-08924"},
                new Customer { CustomerID = "BLONP", CompanyName = "Blondesddsl père et fils", ContactName = "Frédérique Citeaux", ContactTitle = "Marketing Manager", Address = "24, place Kléber", City = "Strasbourg", PostalCode="67000", Country = "France", Phone="88.60.15.31", Fax="88.60.15.32"},
                new Customer { CustomerID = "BOLID", CompanyName = "Bólido Comidas preparadas", ContactName = "Martín Sommer", ContactTitle = "Owner", Address = "C/ Araquil, 67", City = "Madrid", PostalCode = "28023", Country = "Spain", Phone = "(91) 555 22 82", Fax = "(91) 555 91 99" },
                new Customer { CustomerID = "BONAP", CompanyName = "Bon app'", ContactName = "Laurence Lebihan", ContactTitle = "Owner", Address = "12, rue des Bouchers", City = "Marseille", PostalCode="13008",    Country = "France", Phone="91.24.45.40",    Fax = "91.24.45.41" }
            };
            customers.ForEach(customer => context.Customers.Add(customer));
            context.SaveChanges();

            List<Shipper> shippers = new List<Shipper>
            {
                new Shipper {  CompanyName = "Speedy Express", Phone = "(503) 555-9831" },
                new Shipper {  CompanyName = "United Package", Phone = "(503) 555-3199" },
                new Shipper {  CompanyName = "Federal Shipping", Phone = "(503) 555-9931" }
            };
            shippers.ForEach(shipper => context.Shippers.Add(shipper));
            context.SaveChanges();

            List<Supplier> suppliers = new List<Supplier>
            {
                new Supplier { CompanyName = "Exotic Liquids", ContactName = "Charlotte Cooper", ContactTitle = "Purchasing Manager", Address = "49 Gilbert St.", City = "London", PostalCode = "EC1 4SD", Country = "UK", Phone = "(171) 555-2222"},
                new Supplier { CompanyName = "New Orleans Cajun Delights", ContactName = "Shelley Burke", ContactTitle = "Order Administrator", Address = "P.O. Box 78934", City = "New Orleans", Region = "LA", PostalCode = "70117", Country = "USA", Phone = "(100) 555-4822", HomePage = "#CAJUN.HTM#"},
                new Supplier { CompanyName = "Grandma Kelly's Homestead", ContactName = "Regina Murphy", ContactTitle = "Sales Representative", Address = "707 Oxford Rd.", City = "Ann Arbor", Region = "MI", PostalCode = "48104", Country = "USA", Phone = "(313) 555-5735", Fax = "(313) 555-3349"},
                new Supplier { CompanyName = "Tokyo Traders", ContactName = "Yoshi Nagase", ContactTitle = "Marketing Manager", Address = "9-8 Sekimai Musashino-shi", City = "Tokyo", PostalCode = "100", Country = "Japan", Phone = "(03) 3555-5011", },
                new Supplier { CompanyName = "Cooperativa de Quesos 'Las Cabras'", ContactName = "Antonio del Valle Saavedra", ContactTitle = "Export Administrator", Address = "Calle del Rosal 4", City = "Oviedo", Region = "Asturias", PostalCode = "33007", Country = "Spain", Phone = "(98) 598 76 54"},
                new Supplier { CompanyName = "Mayumi's", ContactName = "Mayumi Ohno", ContactTitle = "Marketing Representative", Address = "92 Setsuko Chuo-ku", City = "Osaka", PostalCode = "545", Country = "Japan", Phone = "(06) 431-7877", HomePage = "Mayumi's (on the World Wide Web)#http://www.microsoft.com/accessdev/sampleapps/mayumi.htm#"},
                new Supplier { CompanyName = "Pavlova, Ltd.", ContactName = "Ian Devling", ContactTitle = "Marketing Manager", Address = "74 Rose St. Moonie Ponds", City = "Melbourne", Region = "Victoria", PostalCode = "3058", Country = "Australia", Phone = "(03) 444-2343", Fax = "(03) 444-6588"},
                new Supplier { CompanyName = "Specialty Biscuits, Ltd.", ContactName = "Peter Wilson", ContactTitle = "Sales Representative", Address = "29 King's Way", City = "Manchester", PostalCode = "M14 GSD", Country = "UK", Phone = "(161) 555-4448"},
                new Supplier { CompanyName = "PB Knäckebröd AB", ContactName = "Lars Peterson", ContactTitle = "Sales Agent", Address = "Kaloadagatan 13", City = "Göteborg", PostalCode = "S-345 67", Country = "Sweden", Phone = "031-987 65 43", Fax = "031-987 65 91"},
            };
            suppliers.ForEach(supplier => context.Suppliers.Add(supplier));
            context.SaveChanges();

            List<Order> orders = new List<Order>
            {
                new Order { CustomerID = "ALFKI", EmployeeID = 5, OrderDate = Convert.ToDateTime(1996-07-04), RequiredDate = Convert.ToDateTime(1996-08-01), ShippedDate = Convert.ToDateTime(1996-07-16), ShipVia = 3, Freight = Convert.ToDecimal(32.3800), ShipName = "Vins et alcools Chevalier", ShipAddress = "59 rue de l'Abbaye", ShipCity = "Reims", ShipPostalCode = "51100", ShipCountry = "France" },
                new Order { CustomerID = "ANATR", EmployeeID = 6, OrderDate = Convert.ToDateTime(1996-07-05), RequiredDate = Convert.ToDateTime(1996-08-16), ShippedDate = Convert.ToDateTime(1996-07-10), ShipVia = 1, Freight = Convert.ToDecimal(11.6100), ShipName = "Toms Spezialitäten", ShipAddress = "Luisenstr. 48", ShipCity = "Münster", ShipPostalCode = "44087", ShipCountry = "Germany" },
                new Order { CustomerID = "ANTON", EmployeeID = 4, OrderDate = Convert.ToDateTime(1996-07-08), RequiredDate = Convert.ToDateTime(1996-08-05), ShippedDate = Convert.ToDateTime(1996-07-12), ShipVia = 2, Freight = Convert.ToDecimal(65.8300), ShipName = "Hanari Carnes", ShipAddress = "Rua do Paço, 67", ShipCity = "Rio de Janeiro", ShipRegion = "RJ", ShipPostalCode = "05454-876", ShipCountry = "Brazil" }
            };
            orders.ForEach(order => context.Orders.Add(order));
            context.SaveChanges();

            List<Product> products = new List<Product>
            {
                new Product { ProductName = "Chai", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "10 boxes x 20 bags", UnitPrice = Convert.ToDecimal(18.0000), UnitsInStock = 39, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false },
                new Product { ProductName = "Chang", SupplierID = 1, CategoryID = 1, QuantityPerUnit = "24 - 12 oz bottles", UnitPrice = Convert.ToDecimal(19.0000), UnitsInStock = 17, UnitsOnOrder = 40, ReorderLevel = 25, Discontinued = false },
                new Product { ProductName = "Aniseed Syrup", SupplierID = 1, CategoryID = 2, QuantityPerUnit = "12 - 550 ml bottles", UnitPrice = Convert.ToDecimal(10.0000), UnitsInStock = 13, UnitsOnOrder = 70, ReorderLevel = 25, Discontinued = false },
                new Product { ProductName = "Chef Anton's Cajun Seasoning", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "48 - 6 oz jars", UnitPrice = Convert.ToDecimal(22.0000), UnitsInStock = 53, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = false },
                new Product { ProductName = "Chef Anton's Gumbo Mix", SupplierID = 2, CategoryID = 2, QuantityPerUnit = "36 boxes", UnitPrice = Convert.ToDecimal(21.3500), UnitsInStock = 0, UnitsOnOrder = 0, ReorderLevel = 0, Discontinued = true },
                new Product { ProductName = "Grandma's Boysenberry Spread", SupplierID = 3, CategoryID = 2, QuantityPerUnit = "12 - 8 oz jars", UnitPrice = Convert.ToDecimal(25.0000), UnitsInStock = 120, UnitsOnOrder = 0, ReorderLevel = 25, Discontinued = false },
                new Product { ProductName = "Uncle Bob's Organic Dried Pears", SupplierID = 3, CategoryID = 7, QuantityPerUnit = "12 - 1 lb pkgs.", UnitPrice = Convert.ToDecimal(30.0000), UnitsInStock = 15, UnitsOnOrder = 0, ReorderLevel = 10, Discontinued = false }
            };
            products.ForEach(product => context.Products.Add(product));
            context.SaveChanges();

            List<Territory> territories = new List<Territory>
            {
                new Territory { TerritoryID = "01581", TerritoryDescription = "Westboro", RegionID = 1 },
                new Territory { TerritoryID = "01730", TerritoryDescription = "Bedford", RegionID = 1 },
                new Territory { TerritoryID = "01833", TerritoryDescription = "Georgetow", RegionID = 1 },
                new Territory { TerritoryID = "02116", TerritoryDescription = "Boston", RegionID = 1 },
                new Territory { TerritoryID = "02139", TerritoryDescription = "Cambridge", RegionID = 1 },
                new Territory { TerritoryID = "02184", TerritoryDescription = "Braintree", RegionID = 1 },
                new Territory { TerritoryID = "02903", TerritoryDescription = "Providence", RegionID = 1 },
                new Territory { TerritoryID = "03049", TerritoryDescription = "Hollis", RegionID = 3 },
                new Territory { TerritoryID = "03801", TerritoryDescription = "Portsmouth", RegionID = 3 },
                new Territory { TerritoryID = "06897", TerritoryDescription = "Wilton", RegionID = 1 },
                new Territory { TerritoryID = "07960", TerritoryDescription = "Morristown", RegionID = 1 },
                new Territory { TerritoryID = "08837", TerritoryDescription = "Edison", RegionID = 1 },
                new Territory { TerritoryID = "10019", TerritoryDescription = "New York", RegionID = 1 },
                new Territory { TerritoryID = "10038", TerritoryDescription = "New York", RegionID = 1 }
            };
            territories.ForEach(territory => context.Territories.Add(territory));
            context.SaveChanges();

            base.Seed(context);
        }
    }
}