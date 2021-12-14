﻿namespace TeleprompterConsole
{
  class Program
  {
    static void Main(string[] args)
    {
      var lines = ReadFrom("sampleQuotes.txt");
      foreach (var line in lines)
      {
        Console.WriteLine(line);
        if (!string.IsNullOrWhiteSpace(line))
        {
          var pause = Task.Delay(200);
          pause.Wait();
        }
      }
    }

    static IEnumerable<string> ReadFrom(string file)
    {
      string? line;
      using (var reader = File.OpenText(file))
      {
        while ((line = reader.ReadLine()) != null)
        {
          var words = line.Split(' ');
          var lineLength = 0;
          foreach (var word in words)
          {
            yield return word + " ";
            lineLength += word.Length + 1;
            if (lineLength > 70)
            {
              yield return Environment.NewLine;
              lineLength = 0;
            }
          }
          yield return Environment.NewLine;
        }
      }
    }
  }
}