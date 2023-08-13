int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

var result = numbers
    .Where(x => x % 2 == 0)
    .Select(x => x * 10).ToList();

result.ForEach(x => Console.WriteLine(x));  