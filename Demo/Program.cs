using System.Collections;
using static Demo.ListGenerator;
namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Filteration Operators (OfType, Where)
            //var r = ProductList.Where(x => x.UnitsInStock == 0);
            //foreach (var x in r)
            //{
            //    Console.WriteLine(x);
            //}

            //// Query Expression
            //var result =
            //    from P in ProductList
            //    where P.UnitsInStock == 0
            //    select P;
            //foreach (var x in result)
            //{
            //    Console.WriteLine(x);
            //}

            //var result = ProductList.Where(x => x.Category == "Meat/Poultry");
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}


            //var result = ProductList.Where(p => p.UnitsInStock > 0).Where(p => p.Category == "Meat/Poultry");
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Meat/Poultry"); // syntax sugar
            //ProductList.Where((P, Index) => Index <= 10 && P.UnitsInStock == 0); // 

            //var result = ProductList.Where(P => P.UnitsInStock > 0).Where((P, I) => I < 5);

            // OfType Operator
            //ArrayList array = new ArrayList() { 1,2,3,"Ahmed", "Ali", 1.3,1.5,1.7};
            //var result = array.OfType<int>();
            //// Filters and returns ints only
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Transformation operators Select/SelectMany
            //var result = ProductList.Select(P => P.ProductName);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}
            //var result = ProductList.Where(p => p.UnitsInStock > 0 && p.Category == "Seafood")
            //           .Select(p => new { p.ProductName, p.Category, OldPrice = p.UnitPrice, NewPrice = p.UnitPrice - 0.1M * p.UnitPrice });
            //var result = CustomerList.SelectMany(c => c.Orders); // if one of the property is sequence 

            //var result = from C in CustomerList
            //             from O in C.Orders
            //             select O;

            // indexed select valid only in fluent syntax


            #endregion

            #region Ordering Operators (Deffered)
            // Sorting 
            // sort based on price ascending
            //var result = ProductList.OrderBy(p => p.UnitPrice).Select(p=> new {p.ProductName, p.UnitPrice, p.UnitsInStock}); // sort ascending

            // sort based on UnitsInStock descending
            //var result = ProductList.OrderByDescending(p => p.UnitsInStock).ThenByDescending(p=> p.UnitPrice).Select(p=> new {p.ProductName, p.UnitPrice, p.UnitsInStock}); // sort ascending
            //var result = from P in ProductList
            //             where P.Category == "Meat/Poultry"
            //             orderby P.UnitPrice descending, P.UnitsInStock ascending
            //             select new { P.ProductName,P.Category ,P.UnitPrice, P.UnitsInStock };

            //var result = ProductList.Reverse<Product>();
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Elements Operators (Immediate) - Returns One Element
            //var result = ProductList.First(); // May Throw Exception if sequence is empty
            //result = ProductList.Last(); // May Throw Exception if sequence is empty

            // 2 Overloads // first or last based on a func, WILL THROW EXCEPTION IF NO MATCHING CONDITION
            //var result = ProductList.First(p=> p.UnitsInStock == 0); // May Throw Exception if sequence is empty
            //result = ProductList.Last(p => p.UnitsInStock == 0); // May Throw Exception if sequence is empty
            //Console.WriteLine(result);

            // WE Can first Or Default (Returns null if there is no mathcing)
            //ProductList = new List<Product>();
            //var result = ProductList.FirstOrDefault();
            //var result = ProductList.FirstOrDefault(P => P.UnitsInStock == 1000, new Product { ProductName = "Default Value"});

            //var result = ProductList.ElementAt(0); // at index
            //result = ProductList.ElementAtOrDefault(0); // at index

            //result = ProductList.Single(); // returns value if the sequence contains only one element , will throw an exception if there is no elements
            //result = ProductList.Single(p=> p.UnitsInStock == 100); // will throw an exception if there is no matching or more than one matching

            //var result = ProductList.SingleOrDefault(); // More than element ==> Exception
            //                                        // 0 Elements ==> Null
            //                                        // 1 Element ==>  Returns the actual element
            //var result = ProductList.SingleOrDefault(new Product {ProductName = "Default Value" });
            //                                        // More than element ==> Exception
            //                                        // 0 Elements ==> the passed default value 
            //                                        // 1 Element ==>  Returns the actual element

            //var result = ProductList.SingleOrDefault(P=> P.UnitsInStock == 1000);
            //                                        // More than element ==> Exception
            //                                        // 0 Elements ==> null
            //                                        // 1 Element ==>  Returns the actual element
            //var result = ProductList.SingleOrDefault(P=> P.UnitsInStock == 1000, new Product { ProductName = "Default Value"});
            //                                        // More than element ==> Exception
            //                                        // 0 Elements ==> Passed Default Value
            //                                        // 1 Element ==>  Returns the actual element

            //Console.WriteLine(result);

            //ProductList = new List<Product>();
            //var result = ProductList.DefaultIfEmpty(new Product { ProductName = "Default Value"});
            //// 0 Elements => default value
            //// More Elements ==>  Returns Elements
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Aggregate Operators (Immediate) - Built-In Aggregate in SQL
            // Count - Sum - Max - Min - Avg

            //var result = ProductList.Count(P=> P.UnitsInStock == 0); // if using a predicate use this
            //var result = ProductList.Count; //else use this 

            //var result = ProductList.Sum(P => P.UnitPrice); // total prices

            //result  = ProductList.Sum(P => P.UnitsInStock); // total units

            //result = ProductList.Average(p => p.UnitPrice);

            //var result = ProductList.Max(); // Exception because Product doesn't Implement ICompareable
            //var result = ProductList.Max(new ProductComparerUnitInStock()); // Implemented IComparer
            //var result = ProductList.Max(p => p.UnitsInStock); 
            var result = ProductList.MaxBy(p => p.UnitPrice); // returns the product with the highest unit price
            Console.WriteLine(result);

            #endregion

            #region Casting Operators - Immediate Execution
            #endregion
        }
    }
}
