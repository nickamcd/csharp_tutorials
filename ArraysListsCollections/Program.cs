namespace ArraysListsCollections
{
  class Program 
  {
    static void Main(string[] args)
    {
      int[] arr = new int[] { 1, 2, 3, 4 };

      var names = new List<string> { "<name>", "Ana", "Felipe" };
      foreach (string name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }

      names.Add("Tony");
      names.Add("Maria");
      names.Add("Bill");

      var index = names.IndexOf("Jeremy");
      Console.WriteLine($"Found Jeremy at {index}");

      if (index == -1)
      {
        Console.WriteLine($"When an item is not found, IndexOf returns {index}");
      }
      else
      {
        Console.WriteLine($"The name {names[index]} is at index {index}");
      }

      names.Sort();
      foreach (string name in names)
      {
        Console.WriteLine($"{name}");
      }

      var fibonacciNumbers = new List<int> { 1, 1 };

      while (fibonacciNumbers.Count < 20)
      {
        var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
        var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];

        fibonacciNumbers.Add(previous + previous2);
      }

      foreach (int num in fibonacciNumbers)
        Console.WriteLine($"{num}");
    }
  }
}