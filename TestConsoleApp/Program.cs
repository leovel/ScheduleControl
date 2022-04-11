

using TestConsoleApp;

Dictionary<int , Data> data = new()
{
    { 1, new Data { Id = 1, Date = DateTime.Now.AddDays(1) } },
    { 2, new Data { Id = 2, Date = DateTime.Now.AddDays(2) } },
};

var list = data.Values;

foreach (var item in list)
{
    item.Date = item.Date.AddDays(1);
}

foreach (var item in data)
{
    Console.Write($"{item.Value.Id} => {item.Value.Date}");
    Console.WriteLine();
}

foreach (var item in list)
{
    Console.Write($"{item.Id} => {item.Date}");
    Console.WriteLine();
}
Console.WriteLine("--------------------------------------------------------");
Console.WriteLine();

Console.ReadLine();
