using System.Collections;
using System.Text.RegularExpressions;
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
            //var result = ProductList.MaxBy(p => p.UnitPrice); // returns the product with the highest unit price
            //Console.WriteLine(result);
            //List<string> Names = new List<string>() { "Ahmed", "Ali", "Omar", "Osama" };
            //var result = Names.Aggregate((S01, S02) => $"{S01} , {S02}");
            //Console.WriteLine(result);

            #endregion

            #region Casting Operators - Immediate Execution
            // From Data type to another data type
            //List<Product> list = ProductList.Where(P => P.UnitsInStock == 0).ToList();
            //Product[] list = ProductList.Where(P => P.UnitsInStock == 0).ToArray();
            //Dictionary<long, Product> list = ProductList.Where(P=> P.UnitsInStock == 0).ToDictionary(p=> p.ProductID );
            //HashSet<Product> list = ProductList.Where(P=> P.UnitsInStock == 0).ToHashSet();

            //foreach (var product in list) 
            //{
            //    Console.WriteLine(product);
            //}
            #endregion

            #region Generation Operators 
            // Generates new sequence, the only way to call it as a class memeber method
            // Range, Empty, Repeat
            //var result = Enumerable.Range(1, 100);
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            //var r = Enumerable.Empty<Product>(); // generates empty sequence

            //var result = Enumerable.Repeat(ProductList[0], 3);

            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Set Operators - Union Family
            // Union, Union All, Intersect, Except

            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);
            //var result = seq01.Union(seq02); // works like maths union (without duplication)

            //var result = seq01.Concat(seq02); // With Duplication
            //result = result.Distinct(); // removes duplication

            //var result = seq01.Intersect(seq02);

            //var result = seq01.Except(seq02); // what's in the first sequence and not in the second sequence


            //foreach (var item in result) 
            //{
            //    Console.Write($"{item} ");
            //}
            #endregion

            #region Quantifier Operator
            // Returns one value of boolean
            // Any - All - SequenceEqual - Contains
            //var seq01 = Enumerable.Range(1, 100);
            //var seq02 = Enumerable.Range(50, 100);

            //var result = seq01.Any(N => N % 2 == 0); // if there is at least one element matches condition => returns true

            //var result = seq01.All(N => N <= 100); // returns true if ALL elements matches condition and if the sequence is empty

            // SequenceEqual()
            //var result = seq01.SequenceEqual(seq02); // must be equals

            //var result = seq01.Contains(1);
            //Console.WriteLine(result);
            #endregion

            #region Zip Operator
            // Zipping Operator
            // Zip (Isn't Supported in EFCore)

            //List<string> Words = new List<string>() { "Ten" , "Twenty", "Thirty", "Fourty"};
            //List<int> Numbers = new List<int>() { 10, 20, 30, 40, 50, 60 };
            //var result = Words.Zip(Numbers,(W,N) => $"{N} --> {W}");
            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region Grouping Operators
            // Similar to groupby

            //var result = ProductList.GroupBy(P => P.Category);

            //var result = from P in ProductList
            //             group P by P.Category;

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}");
            //    foreach (var Product in item)
            //    {
            //        Console.WriteLine($".... {Product}");
            //    }
            //}
            //var result = from P in ProductList
            //             where P.UnitsInStock > 0
            //             group P by P.Category
            //             into Category
            //             where Category.Count() > 5
            //             select new {CategoryName = Category.Key, CountOfCategory = Category.Count()};
            //foreach (var item in result) 
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Partitioning Operators
            // Take, TakeLast, Skip, SkipLast, TakeWhile, SkipWhile => Used For Pagination
            //var Result = ProductList.Where(P=> P.UnitsInStock == 0).Take(3);
            //var Result = ProductList.Where(P=> P.UnitsInStock == 0).TakeLast(3);
            //var Result = ProductList.Skip(5); // will skip the first 5
            //var Result = ProductList.SkipLast(5); // will skip the last 5


            //int[] Numbers = { 9, 6, 4, 1, 2, 3, 4, 5 };
            //var Result = Numbers.TakeWhile(N => N % 3 == 0); // Takes The Elements as Long as the condition is true
            //var Result = Numbers.SkipWhile(N => N % 3 == 0); // Skips The Elements as Long as the condition is true, when the condition become false it takes the rest elements int[] Numbers = {9,6,4,1,2,3,4,5};


            //int[] Numbers = {5,4,1,3,9,6,7,2,0};
            //var Result = Numbers.TakeWhile((N,I) => N > I); 
            //var Result = Numbers.SkipWhile((N,I) => N > I); 

            //foreach (var item in Result)    
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

        }
    }
}
