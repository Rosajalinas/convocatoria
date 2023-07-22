
//definicion de arreglo
string[] names = { "Tom", "Dick", "Harry", "Mary", "Jay" };
//este variable almacena los resultados de filtro
IEnumerable<string> query = names
//filtro para obtener nombre que contiene a
.Where(n => n.Contains("a"))
//ordenados por el tamaño de caracteres 
.OrderBy(n => n.Length)
//convertir los seleccionados a mayuscula
.Select(n => n.ToUpper());
foreach (var item in query)
    Console.Write($"{item} |");
