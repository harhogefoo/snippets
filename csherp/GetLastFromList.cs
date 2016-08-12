using System;
using System.Collections.Generic;

/// <summary>
/// リストの末尾から指定した数の要素を取得する
/// Get the number of elements from the end of the list
/// </summary>
class GetLastFromList
{
  private static readonly int PICK_UP_NUM = 9;
  public static void Main ()
  {
    List<string> strData = new List<string>();
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

    int pickupIndex = strData.Count - PICK_UP_NUM;
    if (pickupIndex < 0) {
      pickupIndex = 0;
    }
    List<string> data = strData.GetRange(pickupIndex, PICK_UP_NUM);

    for (int i = 0; i < data.Count; i++) {
      Console.WriteLine(data[i]);
    }
  }
}

