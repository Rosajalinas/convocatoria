
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
IEnumerable<string> query = names
.Where(n => n.Contains("a"))
.OrderBy(n => n.Length)
.Select(n => n.ToUpper());
foreach (var item in query)
    Console.Write($"{item} |");
