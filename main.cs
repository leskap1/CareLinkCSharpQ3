using System;
using System.Collections.Generic;

public class Tester {
  public static void Main (string[] args) {
    UnitTest.Test5(); // Test Generation 5 Level Pascal's Triangle
    UnitTest.Test7(); // Test Generation 7 Level Pascal's Triangle
  }
}

// Given a non-negative integer numRows
// generate the first numRows of Pascal's triangle.
//
// Example:
//
// Input: 5
// Output:
// [
//      [1],
//     [1,1],
//    [1,2,1],
//   [1,3,3,1],
//  [1,4,6,4,1]
// ]
//
public class Solution {
    public IList<IList<int>> Generate(int numRows) 
    {        
        IList<IList<int>> result = new List<IList<int>>();

        // TODO

        return result;
    }
}

