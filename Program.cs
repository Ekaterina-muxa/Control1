string[] strings = { "Kate", "kat", "is", "29", "=-))", "0000", "=p", "London is a capital of" }; 
var result = strings.Where(s => s.Length <= 3).ToArray(); 
Console.WriteLine(string.Join(", ", result)); 
Console.ReadLine();

