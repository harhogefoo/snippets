using System;
using System.Collections.Generic;
using HarhogefooExtension;

/// <summary>
/// リストの末尾から指定した数の要素を取得する拡張メソッド
/// Get the number of elements from the end of the list
/// </summary>
class GetLastFromListSample
{
  public static void Main ()
  {
    var strData = new List<string>();
    strData.Add("a");
    strData.Add("b");
    strData.Add("c");
    strData.Add("d");
    strData.Add("e");
    strData.Add("f");
    strData.Add("g");
    strData.Add("h");
    strData.Add("i");
    strData.Add("j");
    strData.Add("k");

    List<string> data = strData.GetLastFromList(5);
    for (int i = 0; i < data.Count; i++) {
      Console.WriteLine(data[i]);
    }
  }
}

namespace HarhogefooExtension
{
  public static class ListExtensions
  {
    public static List<T> GetLastFromList<T>( this List<T> self, int pickupNumFromLast )
    {
      int pickupStartIndex = self.Count - pickupNumFromLast;
      if (pickupStartIndex < 0) {
        pickupStartIndex = 0;
        pickupNumFromLast = self.Count;
      }
      return self.GetRange(pickupStartIndex, pickupNumFromLast);
    }
  }
}
