using System;
using System.Collections.Generic;
using System.Linq;
 

namespace BridgeLabzConsoleApp.advoops.linq
{
    public class EmployeeLinqDemo
    {
        public static void Main()
        {
            List<int> nums = new() { 1, 2, 3, 4, 5, 6, 3, 2 };
            List<string> names = new() { "ram", "ravi", "raj" };

            var data = new[]
            {
            new { Id = 1, Name = "A", Score = 50 },
            new { Id = 2, Name = "B", Score = 60 },
            new { Id = 3, Name = "C", Score = 50 }
        };

            Console.WriteLine("=== Filtering ===");
            Console.WriteLine(string.Join(",", nums.Where(n => n > 3)));
            Console.WriteLine(string.Join(",", names.OfType<string>()));

            Console.WriteLine("\n=== Sorting ===");
            Console.WriteLine(string.Join(",", nums.OrderBy(n => n)));
            Console.WriteLine(string.Join(",", nums.OrderByDescending(n => n)));
            Console.WriteLine(string.Join(",", names.OrderBy(n => n)));
            Console.WriteLine(string.Join(",", nums.AsEnumerable().Reverse<int>));

            Console.WriteLine("\n=== Grouping ===");
            foreach (var g in data.GroupBy(d => d.Score))
                Console.WriteLine($"{g.Key}: {string.Join(",", g.Select(x => x.Name))}");

            Console.WriteLine("\n=== Join ===");
            var cities = new[] {
            new { CityId = 1, City = "BLR" },
            new { CityId = 2, City = "CHN" }
        };

            var students = new[] {
            new { Id = 1, CityId = 1 },
            new { Id = 2, CityId = 2 }
        };

            var join = students.Join(cities,
                                     s => s.CityId,
                                     c => c.CityId,
                                     (s, c) => new { s.Id, c.City });

            foreach (var j in join) Console.WriteLine($"{j.Id} - {j.City}");

            Console.WriteLine("\n=== Projection ===");
            Console.WriteLine(string.Join(",", data.Select(d => d.Name)));
            Console.WriteLine(string.Join(",", names.SelectMany(n => n.ToCharArray())));

            Console.WriteLine("\n=== Aggregation ===");
            Console.WriteLine(nums.Aggregate((a, b) => a + b));
            Console.WriteLine(nums.Average());
            Console.WriteLine(nums.Count());
            Console.WriteLine(nums.Max());
            Console.WriteLine(nums.Sum());

            Console.WriteLine("\n=== Quantifiers ===");
            Console.WriteLine(nums.All(n => n > 0));
            Console.WriteLine(nums.Any(n => n == 3));
            Console.WriteLine(nums.Contains(4));

            Console.WriteLine("\n=== Element Operators ===");
            Console.WriteLine(nums.ElementAt(2));
            Console.WriteLine(nums.First());
            Console.WriteLine(nums.Last());

            Console.WriteLine("\n=== Set Operators ===");
            Console.WriteLine(string.Join(",", nums.Distinct()));
            Console.WriteLine(string.Join(",", nums.Intersect(new[] { 2, 3 })));
            Console.WriteLine(string.Join(",", nums.Union(new[] { 10 })));

            Console.WriteLine("\n=== Partitioning ===");
            Console.WriteLine(string.Join(",", nums.Skip(2)));
            Console.WriteLine(string.Join(",", nums.Take(3)));

            Console.WriteLine("\n=== Concatenation ===");
            Console.WriteLine(string.Join(",", nums.Concat(new[] { 100, 200 })));

            Console.WriteLine("\n=== Equality ===");
            Console.WriteLine(nums.SequenceEqual(new List<int> { 1, 2, 3, 4, 5, 6, 3, 2 }));

            Console.WriteLine("\n=== Generation ===");
            Console.WriteLine(string.Join(",", nums.DefaultIfEmpty()));
            Console.WriteLine(string.Join(",", Enumerable.Range(1, 5)));
            Console.WriteLine(string.Join(",", Enumerable.Repeat("hi", 3)));

            Console.WriteLine("\n=== Conversion ===");
            Console.WriteLine(string.Join(",", nums.ToArray()));
            Console.WriteLine(string.Join(",", nums.ToList()));
            Console.WriteLine(string.Join(",", nums.AsEnumerable()));
        }

    }
}
