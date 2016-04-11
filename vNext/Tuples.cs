
//Current
public Tuple<int, int> Tally(IEnumerable<int> values) { ... }

var t = Tally(myValues);
Console.WriteLine($"Sum: {t.Item1}, count: {t.Item2}");


//Proposed
public (int sum, int count) Tally(IEnumerable<int> values) { ... }

var t = Tally(myValues);
Console.WriteLine($"Sum: {t.sum}, count: {t.count}");  
