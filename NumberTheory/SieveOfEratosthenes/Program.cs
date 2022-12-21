//int[] inputs => Console.ReadLine().Split(' ').Select();
var n = int.Parse(Console.ReadLine());
var list = GetResult(n);
if(list.Count < 1)
{
    Console.WriteLine("No Prime Number");
}
else
{
    foreach(var item in list)
        Console.WriteLine(item);
}


List<int> GetResult(int range)
{
    var result = new List<int>();
    var rejection = Enumerable.Repeat(false, n).ToArray();
    for (int i = 2; i * i <= n; i++)
        if (!rejection[i])
            for (int j = i * i; j < n; j += i)
                rejection[j] = true;
    for(int i = 2; i < n; i++)
        if (!rejection[i]) result.Add(i);
    return result;
}