using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.Arm;
using System.Threading;
using static Assignment.ListGenerator;
namespace Assignment;

class CaseInsensitiveComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}

class CustomComparer : IEqualityComparer<string>
{
    public bool Equals(string x, string y)
    {
        return GetSortedKey(x) == GetSortedKey(y);
    }

    public int GetHashCode(string obj)
    {
        return GetSortedKey(obj).GetHashCode();
    }

    private string GetSortedKey(string word)
    {
        return new string(word.Trim().OrderBy(c => c).ToArray()); // Sort characters after trimming spaces
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        #region Restriction Operators

        #region Q1
        //var result = ProductList.Where(p=> p.UnitsInStock == 0);
        #endregion
        #region Q2
        //var result = ProductList.Where(P => P.UnitsInStock > 0 && P.UnitPrice > 3.00M);
        #endregion
        #region Q3
        //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        //var result = Arr.Where((P,I) => P.Length < I);
        #endregion

        #endregion

        #region Element Operators

        #region Q1
        //var result = ProductList.FirstOrDefault(p=> p.UnitsInStock == 0);
        #endregion
        #region Q2
        //var result = ProductList.FirstOrDefault(P => P.UnitPrice > 1000);
        #endregion
        #region Q3
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = Arr.Where(P=> P > 5).Skip(1).Take(1); // solution1 
        //var result = Arr.Where(P => P > 5).ElementAt(1); // solution 2

        #endregion

        #endregion

        #region Aggregate Operators
        #region Q1
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = Arr.Count(p=> p %2 != 0);
        #endregion
        #region Q2
        //var result = CustomerList.Select(p => new {p.CustomerName , Orders = p.Orders.Length});
        #endregion
        #region Q3
        //var result = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key , Count = g.Count()}) ;
        #endregion
        #region Q4
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = Arr.Sum();
        #endregion
        #region Q5
        string[] words = File.ReadAllLines("dictionary_english.txt");
        //var result = words.Sum(P => P.Length);
        #endregion
        #region Q6
        //var result = words.Min(w => w.Length);
        #endregion
        #region Q7
        //var result = words.Max(x => x.Length);
        #endregion
        #region Q8
        //var result = words.Average(x=> x.Length);
        #endregion
        #region Q9
        //var result = ProductList.Sum(s => s.UnitsInStock);
        #endregion
        #region Q10
        //var result = ProductList.GroupBy(c => c.Category).Select(p => new {Category = p.Key, MinPrice = p.Min(x => x.UnitPrice)}) ;
        #endregion
        #region Q11
        //var result = from P in ProductList
        //             group P by P.Category into g
        //             let minPrice = g.Min(p=> p.UnitPrice)
        //             from P in g
        //             where P.UnitPrice == minPrice
        //             select P;
        #endregion
        #region Q12
        //var result = ProductList.GroupBy(c => c.Category).Select(p => new { Category = p.Key, MaxPrice = p.Max(x => x.UnitPrice) });
        #endregion
        #region Q13
        //var result = from P in ProductList
        //             group P by P.Category into g
        //             let maxPrice = g.Max(p => p.UnitPrice)
        //             from P in g
        //             where P.UnitPrice == maxPrice
        //             select P;
        #endregion
        #region Q14
        //var result = ProductList.GroupBy(c => c.Category).Select(p => new {Category = p.Key, AvgPrice = p.Average(x => x.UnitPrice)}) ;
        #endregion

        #endregion

        #region Ordering Operators
        #region Q1
        //var result = ProductList.OrderBy(p => p.ProductName);
        #endregion
        #region Q2
        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var result = Arr.Order(new CaseInsensitiveComparer());
        #endregion
        #region Q3
        //var result = ProductList.OrderByDescending(x => x.UnitsInStock);
        #endregion
        #region Q4
        //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};
        //var result = Arr.OrderBy(x=> x.Length).ThenBy(x=>x);
        #endregion
        #region Q5
        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var result = Arr.OrderBy(x => x).ThenBy(x=> x);
        #endregion
        #region Q6
        //var result = ProductList.OrderBy(x => x.Category).ThenByDescending(x => x.UnitPrice);
        #endregion
        #region Q7
        //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
        //var result = Arr.OrderBy(x => x.Length).ThenByDescending(x => x);
        #endregion
        #region Q8
        //string[] Arr = {"zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine"};

        //var result = Arr.Where(word => word.Length > 1 && word[1] == 'i')
        //                .Reverse();
        #endregion


        #endregion

        #region Transformation Operators
        #region Q1
        //var result = ProductList.Select(p => p.ProductName);
        #endregion

        #region Q2
        //string[] words2 = { "aPPLE", "BlUeBeRrY", "cHeRry" };
        //var result = words2.Select(w => new {Lower = w.ToLower(), Upper = w.ToUpper() });
        #endregion

        #region Q3
        //var result = ProductList.Select(p => new { p.ProductID, p.ProductName, Price = p.UnitPrice });

        #endregion

        #region Q4
        //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = Arr.Select((X,I) => new {X , Status = (X==I)});
        //foreach (var unit in result)
        //{
        //    Console.WriteLine($"{unit.X}: {unit.Status}");
        //}
        #endregion

        #region Q5
        //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
        //int[] numbersB = { 1, 3, 5, 7, 8 };
        //var result = from a in numbersA
        //             from b in numbersB
        //             where a < b
        //             select (a, b);
        //foreach (var unit in result)
        //{
        //    Console.WriteLine($"{ unit.a } is less than {unit.b} ");
        //}

        #endregion

        #region Q6
        //var result = CustomerList.SelectMany(p => p.Orders).Where(p => p.Total < 500);
        #endregion

        #region Q7
        //var result = CustomerList.SelectMany(p => p.Orders).Where(p=> p.OrderDate.Year >= 1998);
        #endregion

        #endregion

        #region Set Operators
        #region Q1
        //var result = ProductList.Select(p => p.ProductName).Distinct();
        #endregion

        #region Q2
        //var result = ProductList.Select(p => p.ProductName[0]).Union(CustomerList.Select(c => c.CustomerName[0]));
        #endregion

        #region Q3
        //var result = ProductList.Select(p => p.ProductName[0]).Intersect(CustomerList.Select(c => c.CustomerName[0]));
        #endregion

        #region Q4
        //var result = ProductList.Select(p => p.ProductName[0]).Except(CustomerList.Select(c => c.CustomerName[0]));
        #endregion

        #region Q5
        //var result = ProductList.Select(p => p.ProductName[^3..]).Concat(CustomerList.Select(c=> c.CustomerName[^3..]));
        #endregion


        #endregion

        #region Partitioning Operators
        #region Q1
        //var result = CustomerList.Where(c=> c.City == "Washington").Take(3);
        #endregion

        #region Q2
        //var result = CustomerList.Where(c=> c.City == "Washington").Skip(2);

        #endregion
        #region Q3
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = numbers.TakeWhile((p, i) => p >= i);

        #endregion

        #region Q4
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = numbers.SkipWhile(p => p%3 !=0);
        #endregion

        #region Q5
        //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
        //var result = numbers.SkipWhile((p, i) => p >= i);
        #endregion
        #endregion

        #region Quantifiers
        #region Q1
        //var result = words.Any(p=> p.Contains("ei"));
        #endregion

        #region Q2
        //var result = ProductList.GroupBy(p => p.Category).Where(g => g.Any(p => p.UnitsInStock == 0));
        //foreach (var unit in result)
        //{
        //    Console.WriteLine(unit.Key);
        //}
        #endregion

        #region Q3
        //var result = ProductList.GroupBy(p => p.Category).Where(g => g.All(p => p.UnitsInStock > 0));
        //foreach (var unit in result)
        //{
        //    Console.WriteLine(unit.Key);
        //}
        #endregion

        #endregion

        #region Grouping Operators

        #region Q1
        //List<int> numbers = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        //var result = numbers.GroupBy(n => n % 5);
        //foreach (var unit in result)
        //{
        //    Console.WriteLine($"Numbers with remainder {unit.Key} when divided by 5:");
        //    foreach (var item in unit) Console.WriteLine(item);
        //}
        #endregion

        #region Q2
        //var result = words.GroupBy(p => p[0]);
        //foreach (var item in result) 
        //{
        //    Console.WriteLine($"The Letter: {item.Key}");
        //    foreach(var item2 in item) Console.WriteLine(item2);
        //}
        #endregion

        #region Q3
        //string[] Arr = { "from", "salt", "earn", "last", "near", "form" };
        //var result = Arr.GroupBy(w => w, new CustomComparer());
        //foreach (var unit in result)
        //{ 
        //    foreach (var s in unit) Console.WriteLine(s);
        //    Console.WriteLine("....");
        //}
        #endregion

        #endregion

        //Console.WriteLine(result);
        //foreach (var unit in result)
        //{
        //    Console.WriteLine(unit);
        //}
    }
}
