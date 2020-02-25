using System;
using System.Text;
using System.Collections.Generic;

public class UnitTest {

  public static void Test5 () 
  {
     Console.WriteLine("Test Generate: 5 Levels");
     List<IList<int>> correct = new List<IList<int>>() {
       new List<int>() { 1 },
       new List<int>() { 1, 1 },
       new List<int>() { 1, 2, 1 },
       new List<int>() { 1, 3, 3, 1 },
       new List<int>() { 1, 4, 6, 4, 1 }
    };
    ValidatePascalsTriangle(correct, 5);

    Console.WriteLine();
  }

  public static void Test7 () 
  {
     Console.WriteLine("Test Generate: 7 Levels");
     List<IList<int>> correct = new List<IList<int>>() {
       new List<int>() { 1 },
       new List<int>() { 1, 1 },
       new List<int>() { 1, 2, 1 },
       new List<int>() { 1, 3, 3, 1 },
       new List<int>() { 1, 4, 6, 4, 1 },
       new List<int>() { 1, 5, 10, 10, 5, 1 },
       new List<int>() { 1, 6, 15, 20, 15, 6, 1 }
    };
    ValidatePascalsTriangle(correct, 7);

    Console.WriteLine();
  }

  public static void ValidatePascalsTriangle(IList<IList<int>> correct, int sizeGoal)
  {
    Solution s = new Solution();

    IList<IList<int>> answer = s.Generate(sizeGoal);

    Assert(answer != null, "Result should not be null.");
    Assert(answer.Count, sizeGoal,  $"Outer Array should be {sizeGoal} in length");
   
    for(int index = 0; index < sizeGoal; index++)
    {
      if (answer.Count > index )
        Assert(answer[index].Count, index + 1, $"Index {index} should have length {index + 1}.");
      else
        Console.WriteLine($"Fail: Index {index} should have length {index + 1}.");
    }

    for(int index = 0; index < sizeGoal; index++)
    {
        if (answer.Count > index)
        {
          Assert(answer[index], correct[index], $"Level {index + 1} should be {ToIntArray(correct[index])}" );
        }
        else
        {
          Console.WriteLine($"Fail: Level {index + 1} should be {ToIntArray(correct[index])}");
        }
    }

    DrawPascalsTriangle(sizeGoal, answer);
  }

  public static string ToIntArray(IList<int> numbers)
  {
    StringBuilder sb = new StringBuilder(128);
    for(int i = 0; i < numbers.Count; i++)
    {
      if (i > 0)
         sb.Append(", ");
      sb.Append(numbers[i].ToString());
    }
    return sb.ToString();
  }

  public static void DrawPascalsTriangle(int size, IList<IList<int>> answer)
  {
    Console.WriteLine();
    Console.WriteLine("Your Pascal Triangle for " + size.ToString() + " looks like...");
    Console.WriteLine();

    foreach(IList<int> list in answer)
    {
      foreach(int i in list)
      {
          Console.Write(i);
          Console.Write(" ");
      }
      Console.WriteLine();
    }
  }

  public static void Assert(int value, int correctValue, string testcase) 
  {
      if (value == correctValue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }

  public static void Assert(bool isTrue, string testcase) 
  {
      if (isTrue)
      {
         Console.WriteLine("Pass: " + testcase);
      }
      else
      {
         Console.WriteLine("Fail: " + testcase);
      }
  }

  public static void Assert(IList<int> source, IList<int> check, string testcase)
  {
    if (source.Count != check.Count)
    {
         Console.WriteLine("Fail: Count Incorrect, " + testcase);
    }
    else
    {
      for(int i = 0; i < source.Count; i++)
      {
          if (source[i] != check[i])
          {
              Console.WriteLine("Fail: Elements Incorrect, " + testcase);
              return;
          }
      }

      Console.WriteLine("Pass: " + testcase);
    }
  }
}