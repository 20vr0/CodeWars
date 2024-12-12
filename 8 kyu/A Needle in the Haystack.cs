using System;
public class Kata
{
  public static string FindNeedle(object[] haystack)
  {
    string findneedle = "needle";
    int index = Array.IndexOf(haystack, findneedle);
    return $"found the needle at position {index}";
  }
}
