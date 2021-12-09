namespace ArraysListsCollections
{
  class Program 
  {
    static void Main(string[] args)
    {
      var names = new List<string> { "<name>", "Ana", "Felipe" };
      foreach (string name in names)
      {
        Console.WriteLine($"Hello {name.ToUpper()}!");
      }
    }
  }
}