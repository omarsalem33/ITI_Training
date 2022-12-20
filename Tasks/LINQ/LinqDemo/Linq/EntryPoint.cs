using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static Linq.ListGenerators;


namespace Linq
{
    public class EntryPoint
    {
        static void Main()
        {

            #region Restriction Operators

            //1
            //var res = ProductList.Where(p => p.UnitsInStock == 0);
            //foreach (var item in res)
            //    Console.WriteLine(item);
            ////2
            //var ans = ProductList.Where(p => p.UnitsInStock != 0 && p.ProductID >= 3.00m);
            //foreach (var item in ans)
            //    Console.WriteLine(item);
            ////3
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.Where((P, i) => P.Length < i);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            #endregion

            #region Element Operators

            ////1
            //var ans1 = ProductList.First();
            //Console.WriteLine(ans1);
            ////2 
            //var res1 = ProductList.Where(p=> p.UnitPrice > 100).First();
            //Console.WriteLine(res1);    
            ////3 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = Arr.OrderBy(p => p).Skip(1).Take(1).Single();
            //Console.WriteLine(res);
            #endregion

            #region Set Operators
            ////1
            //var res = ProductList.DistinctBy(p => p.Category);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            //// 2
            //var proNamefirst = ProductList.Select(p => p.ProductName[0]);
            //var customerNamefirst = CustomerList.Select(p => p.CompanyName[0]);
            //var Result = proNamefirst.Union(customerNamefirst);
            //foreach (var i in Result)
            //    Console.WriteLine(i);

            //// 3
            //var proNamefirst = ProductList.Select(p => p.ProductName[0]);
            //var customerNamefirst = CustomerList.Select(p => p.CompanyName[0]);
            //var Result = proNamefirst.Intersect(customerNamefirst);
            //foreach (var i in Result)
            //    Console.WriteLine(i);

            //// 4
            //var proNamefirst = ProductList.Select(p => p.ProductName[0]);
            //var customerNamefirst = CustomerList.Select(p => p.CompanyName[0]);
            //var Result = proNamefirst.Except(customerNamefirst);
            //foreach (var i in Result)
            //    Console.WriteLine(i);
            //// 5
            //var res = ProductList.Select(p => p.ProductName.Substring(p.ProductName.Length - 3)) .Concat(CustomerList.Select(p => p.CompanyName.Substring(p.CompanyName.Length - 3)));
            //foreach (var i in res)
            //    Console.WriteLine(i);
            #endregion

            #region Aggregate Operators
            //// 1
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //List <int> ints = new List<int>();
            //foreach(int i in Arr)
            //    if(i % 2 == 1)
            //        ints.Add(i);
            //Console.WriteLine(ints.Count());


            ////2
            //var res = CustomerList.OrderBy(p => p.CustomerID).Count();
            //Console.WriteLine(res);

            ////3
            //var res = ProductList.OrderBy (p => p .ProductID).Count();  
            //Console.WriteLine(res);

            //// 4
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //Console.WriteLine(Arr.Count());
            //Console.WriteLine(Arr.Sum());

            //// 5
            //var lines = System.IO.File.ReadAllLines(@"D:\ITI\LINQ\Assignment Files\dictionary_english.txt");
            //var res = lines.Sum(p => p.Length);
            //Console.WriteLine(res);

            ////6
            //var res = ProductList.Select(p=>p.UnitsInStock).Sum();
            //Console.WriteLine(res); 

            ////7 
            //var res = lines.Min(p => p.Length);
            //Console.WriteLine(Result);
            //// 8
            //var res = ProductList.Min(p=>p.UnitPrice);
            //Console.WriteLine(res);

            ////10
            //var lines = System.IO.File.ReadAllLines(@"D:\ITI\LINQ\Assignment Files\dictionary_english.txt");
            //var res = lines.Sum(p => p.Length);
            //Console.WriteLine(res);

            ////11 / 12
            //var res = ProductList.Max(p => p.UnitPrice);
            //Console.WriteLine(res);

            //// 13
            //var res = lines.Average(p => p.Length);
            //Console.WriteLine(res);

            ////14

            //var res = ProductList.Average(p => p.UnitPrice);
            //Console.WriteLine(res); 
            #endregion

            #region Ordering Operators
            ////1
            // var res = (from P in ProductList
            //           orderby P.ProductName
            //           select P).ToList();
            //foreach (var item in res)
            //     Console.WriteLine(item);

            ////2
            //string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var Result = Arr.OrderBy(p => p.ToUpper());
            //foreach (var i in Result)
            //    Console.WriteLine(i);

            //3
            //var res = (from P in ProductList
            //           orderby P.UnitsInStock descending
            //           select P).ToList();
            //foreach (var item in res)
            //    Console.WriteLine(item);



            ////4
            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var res = Arr.OrderBy(p => p.Length).ThenBy(p => p);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            ////5 
            //var Result = ProductList.OrderByDescending(p => p.UnitsInStock);
            //foreach (var i in Result)
            //    Console.WriteLine(i);

            ////6
            //var res = (from P in ProductList
            //           orderby P.Category descending
            //           select P).ToList();
            //foreach (var item in res)
            //    Console.WriteLine(item);

            //7
            //var res = (from P in ProductList
            //           orderby P.UnitPrice descending
            //           select P).ToList();
            //foreach (var item in res)
            //    Console.WriteLine(item);

            ////8
            //string[] words = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var res = words.OrderBy(p => p.Length).ThenBy(p => p.ToLower());
            //foreach (var i in res)
            //    Console.WriteLine(i);

            #endregion

            #region Partitioning 
            //// Return a sequence of just the names of a list of products.
            //var res = ProductList.Select(p => new { ProductName = p.ProductName });
            //foreach (var i in res)
            //    Console.WriteLine(i);
            //// Get the elements of the array starting from the first element divisible by 3.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile(i => i % 3 != 0);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            //// Get the elements of the array starting from the first element less than its position.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.SkipWhile((p, i) => p > i);
            //foreach (var i in res)
            //    Console.WriteLine(i);
            #endregion

            #region Projection 
            // Produce a sequence of the uppercase and lowercase versions of each word in the original array(Anonymous Types).
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };
            //var res = words.Select(p => new { UpperCase = p.ToUpper(), LowerCase = p.ToLower() });
            //foreach (var i in res)
            //    Console.WriteLine(i);
            //// Produce a sequence containing some properties of Products, including UnitPrice which is renamed to Price in the resulting type.
            //var res = ProductList.Select(p => new { ProductName = p.ProductName, Category = p.Category, Price = p.UnitPrice });
            //foreach (var i in res)
            //    Console.WriteLine(i);

            //// Determine if the value of ints in an array match their position in the array.
            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var res = numbers.Where((p, i) => p == i);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            ////.Select all orders where the order total is less than 500.00.
            //var orders = CustomerList.SelectMany(p => p.Orders);
            //var res = orders.Where(p => p.Total < 500.00m);
            //foreach (var i in res)
            //    Console.WriteLine(i);

            //// Select all orders where the order was made in 1998 or later.
            //var orders = CustomerList.SelectMany(p => p.Orders);
            //var res = orders.Where(p => p.OrderDate.Year >= 1998).Select(p => new { Date = p.OrderDate });
            //foreach (var i in res)
            //    Console.WriteLine(i);

            #endregion

          

            #region ZIP
            // var l1 = new List<int>() { 1,2,3,4,5};
            // var l2 = new List<string>() { "omar", "salem", "ahmed" };
            // var res = l1.Zip(l2);
            //foreach(var item in res)
            //     Console.WriteLine(item);
            #endregion
            #region let , into
            //List<string> l1 = new List<string> { "omar" , "salem" , "ahmed"  };
            //var res = from N in l1 
            //          select Regex.Replace(N , "[AEUIO aoeui]" ,string .Empty);

            //foreach (string s in res)
            //    Console.WriteLine(s);        

 
            #endregion
            #region Lab


            #region Implicit Typed Local Varaible

            //var D = 15.5;

            //double D02 = 17.5;
            //Console.WriteLine(D02.GetType().Name);
            ////D02 = "Aloi";

            ////D = "hamada";


            #endregion


            #region Anonmance Type
            ////Employee employee = new Employee() { Id = 1, Age = 20, Name = "Ahmed", Salary = 25000 };
            ////Console.WriteLine(employee);
            ////Console.WriteLine(employee.GetType().Name);

            //var E = new { Id = 2, Name = "Hamada", Salary = 2000, Age = 30 }; //immutable datatype --- readonly
            //Console.WriteLine(E);
            //Console.WriteLine(E.GetType().Name);

            //var E01 = new { Id = 2, Name = "Hamada1", Salary = 2000, Age = 30 };
            //Console.WriteLine(E01);
            //Console.WriteLine(E01.GetType().Name);

            ////var E02 = new { Id = 3, Name = "Hamada", Age = 25 , Salary = 3000};
            ////Console.WriteLine(E02);
            ////Console.WriteLine(E02.GetType().Name);
            //// E02.Age = 25; //immutable datatype --- readonly

            //Console.WriteLine($"E : {E.GetHashCode()}");
            //Console.WriteLine($"E01 : {E01.GetHashCode()}"); 
            #endregion

            #region Extension Method

            //int X = 12345;
            //Console.WriteLine(  X.Mirror() );
            ////Console.WriteLine(X.Mirror()); //54321 
            #endregion



            //   List<int> iList = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };
            #region LinqEX01

            ////No Linq 
            //List<int> iList2 = iList.FindAll(i => i % 3 == 0);

            //foreach (int i in iList2)
            //{
            //    Console.WriteLine(i);
            //}

            ////V02 using Where as Extension Method
            ///
            // var Result = iList.Where(i => i % 3 == 0);
            //Fluent Syntax
            //foreach(int i in Result)
            //    Console.WriteLine(i);


            //Query Expersion


            //var Result = from i in iList
            //             where i % 3 == 0
            //             select i;

            //foreach (int i in Result)
            //    Console.WriteLine(i); 
            #endregion

            #region Deffered and Immedute Execution
            ///Deffered Execution
            // var Result = iList.Where(i => i % 2 == 0);
            //var Result = from i in iList
            //             where i % 2 == 0
            ////             select i;

            //iList.AddRange(new int[] { 16, 17, 18, 19 });

            //iList.RemoveRange(0, 4);

            //foreach(int i in Result)
            //{
            //    Console.WriteLine(i);   
            //}

            ///Immedute Execution
            //var Result = iList.Where(i => i % 2 == 0).ToList();
            //var Result = (from i in iList
            //             where i % 2 == 0
            //             select i).ToList();

            //iList.AddRange(new int[] { 16, 17, 18, 19 });

            //iList.RemoveRange(0, 4);

            //foreach (int i in Result)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion


            #region Where / indexed where
            //////var Result = ProductList.Where(P => P.UnitsInStock == 0);
            ////var Result = from P in ProductList
            ////             where P.UnitsInStock == 0
            ////             select P;

            ////foreach(var i in Result)
            ////{
            ////    Console.WriteLine(i);
            ////}

            ////var Result = ProductList.Where(P => P.UnitsInStock == 0 && P.ProductID == 17);
            ////var Result = from P in ProductList
            ////             where P.UnitsInStock == 0 && P.ProductID == 17
            ////             select P;

            //var Result = ProductList.Where((P, i) => P.UnitPrice > 0 && i < 10); //i=>index of element i seq start from 0e


            //foreach (var i in Result)
            //{
            //    Console.WriteLine(i);
            //} 
            #endregion

            #region Select

            // var Result = ProductList.Where(p => p.UnitsInStock == 0).Select(P => P.ProductName);
            //var Result = from P in ProductList
            //             where P.UnitsInStock == 0
            //             // select P.ProductName;
            //             select new { Name = P.ProductName, Id = P.ProductID };

            //var Result = ProductList.Select((P, i) => new { Index = i, Name = P.ProductName });  
            #endregion

            #region Select Many

            // List<string> strList = new List<string>() { "Hamada Ali", "Ahmed Mohamed", "Alaa Ali", "Aya Ragab" };

            //// var Result = strList.SelectMany(FN => FN.Split(' ')).Where(SN => SN.Length >= 4).Select(SN=>SN);

            // var Result = from FN in strList
            //              from SN in FN.Split(' ')
            //              where SN.Length >= 4
            //              select SN; 
            #endregion

            #region Order By
            //var Result = ProductList.OrderBy(P => P.UnitPrice).ThenByDescending(P=>P.UnitsInStock);

            //var Result = from P in  ProductList
            //             orderby P.UnitsInStock descending , P.UnitPrice descending
            //             select P;

            #endregion

            #region Take / Skip
            //var Result = ProductList.Take(5);
            // var Result = ProductList.Skip(5);
            //var Result = ProductList.TakeLast(5);
            ////var Result = ProductList.SkipLast(5);
            //for(int i = 0; i < ProductList.Count / 10; i++)
            //{
            //    var Result = ProductList.Skip(10 * i).Take(10);
            //    foreach (var item in Result)
            //    {
            //        Console.WriteLine(item);
            //    }
            //    Console.ReadLine();
            //    Console.Clear();

            //}
            //var Result = ProductList.TakeWhile(P => P.UnitsInStock > 0);
            //var Result = ProductList.SkipWhile(P => P.UnitsInStock > 0); 
            #endregion

            #region Single Operators
            //var Result = ProductList.First();c

            //var Result = ProductList.Last();
            // List<Product> PList = new List<Product>();

            //var Result = PList.Last();
            // var Result = PList.FirstOrDefault();
            //var Result = PList.LastOrDefault();
            //var Result = ProductList.Single();
            //var Result = ProductList.SingleOrDefault();

            // var Result = ProductList.FirstOrDefault(P=>P.UnitsInStock > 0);
            //var Result = ProductList.LastOrDefault(P=>P.UnitsInStock > 0);

            //Console.WriteLine(Result); 
            #endregion


            #region Aggar. Methods
            // //var Result = ProductList.Count();
            // //var Result = ProductList.Max(P=>P.UnitPrice);
            // //var Result = ProductList.Min(P=>P.UnitPrice);
            // //var Result = ProductList.Sum(P=>P.UnitPrice);

            // //var Result = ProductList.Average(P=>P.UnitPrice);

            //var Result = ProductList.Count(P=>P.UnitsInStock == 0);

            // Console.WriteLine(Result); 

            // //foreach (var i in Result)
            // //{
            // //    Console.WriteLine(i);
            // //} 
            #endregion

            #region Casting Operator
            //List<string> strList = ProductList.Select(P => P.ProductName).ToList();
            //List<Product> strList = ProductList.Where(P => P.UnitsInStock == 0 ).ToList();
            //Product[] prr = ProductList.Where(P => P.UnitsInStock> 0).ToArray();
            // var r= ProductList.Where(P => P.UnitsInStock> 0);

            //foreach (var str in strList)
            //{
            //    Console.WriteLine(str);
            //} 
            #endregion




            #region Generation Operator

            ////var Result = Enumerable.Range(0, 100);
            //var Result = Enumerable.Repeat(3, 10);


            //foreach (int i in Result)
            //    Console.WriteLine(i);

            #endregion




            //////search Set Operator in Linq



            #endregion
          
        }
    }
}
