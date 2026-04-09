using G_Net_34_LINQ02.DataSources;
using G_Net_34_LINQ02.Models;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;

namespace G_Net_34_LINQ02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 Get top 3 most expensive products
            //var Result = Source.ProductList
            //  .OrderByDescending(p => p.UnitPrice)
            //  .Take(3);

            //Console.WriteLine("--- Top 3 Most Expensive Products ---");
            #endregion

            #region Q2 show page 2 of products, with page size = 5
            //int pageSize = 5;
            //int pageNumber = 2;

            //var Result = Source.ProductList
            //    .Skip((pageNumber - 1) * pageSize) 
            //    .Take(pageSize);              

            //Console.WriteLine($"--- Page {pageNumber} of Products (Size: {pageSize}) ---");

            #endregion

            #region Q3 Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var Result = Source.ProductList
            //  .OrderBy(p => p.UnitPrice)
            //  .TakeWhile(p => p.UnitPrice < 25);

            //Console.WriteLine("--- Products with UnitPrice < $25 (Using TakeWhile) ---");
            #endregion

            #region Q4 Check if ALL products in the "Seafood" category are in stock
            //bool allSeafoodInStock = Source.ProductList
            // .Where(p => p.Category == "Seafood")
            // .All(p => p.UnitsInStock > 0);
            //Console.WriteLine("--- Are ALL Seafood products in stock? ---");
            //if (allSeafoodInStock)
            //{
            //    Console.WriteLine("Yes, every single seafood product is in stock.");
            //}
            //else
            //{
            //    Console.WriteLine("No, at least one seafood product is out of stock.");
            //}
            #endregion

            #region Q5 Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };
            //int[] ids = { 3, 9, 13, 18 };

            //bool hasNine = ids.Any(id => id == 9);

            //Console.WriteLine("--- Does the list contain 9? ---");
            //if (hasNine)
            //{
            //    Console.WriteLine("Yes, the number 9 is in the list.");
            //}
            //else
            //{
            //    Console.WriteLine("No, the number 9 is NOT in the list.");
            //}
            #endregion

            #region Q6 Group all products by Category and print each group with its product count.
            //var groupedProducts = Source.ProductList
            //  .GroupBy(p => p.Category)
            //  .OrderByDescending(g => g.Count());
            //Console.WriteLine("--- Product Count by Category ---");
            //foreach (var group in groupedProducts)
            //{
            //    Console.WriteLine($"Category: {group.Key} | Count: {group.Count()} products");
            //}
            #endregion

            #region Q7 Group products by Category and project only product names per group
            //var categoryProductNames = Source.ProductList.GroupBy(
            //    p => p.Category,        
            //    p => p.ProductName
            //    );

            //Console.WriteLine("--- Product Names Grouped by Category ---");

            //foreach (var group in categoryProductNames)
            //{
            //    Console.WriteLine($"\nCategory: {group.Key}");

            //    foreach (var name in group)
            //    {
            //        Console.WriteLine($"  - {name}");
            //    }
            //}
            #endregion

            #region Q8 Find all categories that have MORE THAN 3 products
            //var categoriesWithMoreThan3Products = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3);

            //Console.WriteLine("--- Categories with MORE THAN 3 products ---");
            //foreach (var group in categoriesWithMoreThan3Products)
            //{
            //    Console.WriteLine($"Category: {group.Key} | Count: {group.Count()}");
            //}
            #endregion

            #region Q 9 Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var customersByCountry =
            //    from c in Source.CustomerList
            //    group c by c.Country into g 
            //    select new
            //    {
            //        Country = g.Key,        
            //        Count = g.Count(),       
            //        TotalOrderValue = g.Sum(c => c.Orders.Sum(o => o.Total))
            //    };

            //Console.WriteLine("--- Customers Grouped by Country ---");
            //foreach (var item in customersByCountry)
            //{
            //    Console.WriteLine($"Country: {item.Country,-15} | Customers: {item.Count,-3} | Total Value: {item.TotalOrderValue:C2}");
            //}
            #endregion

            #region Q 10 Calculate the total number of units in stock across all products 
            //int totalUnitsInStock = Source.ProductList.Sum(p => p.UnitsInStock);
            //Console.WriteLine($"--- Total Units In Stock ---");
            //Console.WriteLine($"Total: {totalUnitsInStock} units");
            #endregion

            #region Q11 Find the CHEAPEST and MOST EXPENSIVE product prices
            //decimal cheapestPrice = Source.ProductList.Min(p => p.UnitPrice);
            //decimal mostExpensivePrice = Source.ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine("--- Price Range of Products ---");
            //Console.WriteLine($"Cheapest Price: {cheapestPrice:C2}");

            #endregion

            #region Q12 Get a distinct list of all product categories
            //var distinctCategories = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct();

            //Console.WriteLine("--- Distinct Product Categories ---");
            //foreach (var category in distinctCategories)
            //{
            //    Console.WriteLine($"- {category}");
            //}
            #endregion

            #region Q13 find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };
            //var uniqueToSetA = setA.Except(setB);

            //Console.WriteLine("--- IDs in setA but NOT in setB ---");
            //foreach (var id in uniqueToSetA)
            //{
            //    Console.WriteLine(id);
            //}
            #endregion

            #region Q14 Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //    string[] list1 = { "Germany", "France", "UK", "Spain" };
            //    string[] list2 = { "france", "SPAIN", "Italy" };
            //var uniqueToList1 = list1.Except(list2, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("--- Countries in list1 but NOT in list2 (Case-Insensitive) ---");
            //foreach (var country in uniqueToList1)
            //{
            //    Console.WriteLine(country);
            //}


            #endregion

            #region Q15 Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //Dictionary<int, Product> productDictionary = Source.ProductList.ToDictionary(p => p.ProductID);

            //Console.WriteLine("--- Retrieving Product ID = 18 ---");

            //if (productDictionary.TryGetValue(18, out Product targetProduct))
            //{
            //    Console.WriteLine(targetProduct);
            //}
            //else
            //{
            //    Console.WriteLine("Product with ID 18 was not found.");
            //}
            #endregion

            #region Q16 Get the first product whose price is greater than $50.
            //var firstExpensiveProduct = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 50);

            //Console.WriteLine("--- First Product with Price > $50 ---");

            ////Error handling: Check if a product was found before trying to access its properties
            //if (firstExpensiveProduct != null)
            //{
            //    Console.WriteLine($"Name: {firstExpensiveProduct.ProductName}, Price: {firstExpensiveProduct.UnitPrice:C2}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with a price greater than $50.");
            //}
            #endregion

            #region Q17 Try to get the first product with a price > $500. it returns null instead of throwing.
            //var expensiveProduct = Source.ProductList.FirstOrDefault(p => p.UnitPrice > 500);

            //Console.WriteLine("--- First Product > $500 ---");

            ////Error handling: Check if a product was found before trying to access its properties
            //if (expensiveProduct != null)
            //{
            //    Console.WriteLine($"Found: {expensiveProduct.ProductName} at {expensiveProduct.UnitPrice:C2}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found with a price greater than $500. (Returned null safely)");
            //}
            #endregion

            #region Q18 Generate a multiplication table row for 7
            //    int number = 7;

            //    Console.WriteLine($"--- nultiplication Table for {number} ---");

            //    var Result = Enumerable.Range(1, 12)
            //          .Select(i => $"{number} × {i,-2} = {number * i}");

            #endregion

            #region Q19 Generate even numbers between 1 and 30.

            //var evenNumbers = Enumerable.Range(1, 30).Where(n => n % 2 == 0);

            //Console.WriteLine("--- Even Numbers (1 to 30) ---");
            //Console.WriteLine(string.Join(", ", evenNumbers));
            #endregion

            #region Q20 20.Concatenate the first 3 product names with the first 3 customer company names into a single sequence.
            //var first3Products = Source.ProductList
            //  .Take(3)
            //  .Select(p => p.ProductName);

            //var first3Customers = Source.CustomerList
            //    .Take(3)
            //    .Select(c => c.CompanyName);

            //var combinedSequence = first3Products.Concat(first3Customers);

            //Console.WriteLine("--- Concatenated Sequence ---");
            //foreach (var name in combinedSequence)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion

            #region Q21 21.Pair each product with a customer(by position) and produce a string "ProductName sold to CompanyName".
            var pairedSales = Source.ProductList.Zip(
              Source.CustomerList, 
              (product, customer) => $"{product.ProductName} sold to {customer.CompanyName}" 
            );

            Console.WriteLine("--- Paired Products and Customers ---");
            foreach (var pair in pairedSales)
            {
                Console.WriteLine(pair);
            }
            #endregion

            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine(item);
            //    }
        }
    }
}
