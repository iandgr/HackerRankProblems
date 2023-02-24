using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

  /*
   * Complete the 'plusMinus' function below.
   *
   * The function accepts INTEGER_ARRAY arr as parameter.
   */

  public static void plusMinus(List<int> arr)
  {
    decimal rPos, rNeg, rZer;
    int nPos, nNeg, nZer;
    nPos = nNeg = nZer = 0;
    for (int i = 0; i < arr.Count; i++)
    {
      if (arr[i] > 0)
      {
        nPos++;
      }
      else if (arr[i] < 0)
      {
        nNeg++;
      }
      else
      {
        nZer++;
      }
    }
    rPos = Math.Round(((nPos + 0.0m) / arr.Count), 6, MidpointRounding.ToEven);
    rNeg = Math.Round(((nNeg + 0.0m) / arr.Count), 6, MidpointRounding.ToEven);
    rZer = Math.Round(((nZer + 0.0m) / arr.Count), 6, MidpointRounding.ToEven);
    Console.WriteLine(rPos);
    Console.WriteLine(rNeg);
    Console.WriteLine(rZer);
  }

}

class Solution
{
  public static void Main(string[] args)
  {
    int n = Convert.ToInt32(Console.ReadLine().Trim());

    List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

    Result.plusMinus(arr);
  }
}

