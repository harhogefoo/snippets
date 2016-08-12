using System;

/// <summary>
/// カスタム拡張メソッドを実装して呼び出す
/// 引用: https://msdn.microsoft.com/ja-jp/library/bb311042.aspx
/// </summary>
namespace ExtensionMethods
{
  public static class MyExtensions
  {
    public static int WordCount(this String str)
    {
      return str.Split(new char[] {' ', '.', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
    }
  }
}

namespace Extension_Methods_Sample
{
  using ExtensionMethods;
  class ExtensionSample
  {
    public static void Main(String[] args)
    {
      string s = "Hello Extension Methods";
      int i = s.WordCount();
      System.Console.WriteLine("Word count of s is {0}", i);
    }
  }
}
