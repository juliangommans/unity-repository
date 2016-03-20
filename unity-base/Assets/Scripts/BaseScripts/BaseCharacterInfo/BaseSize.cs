using UnityEngine;
using System.Collections;

public class BaseSize : MonoBehaviour {

  private string size;
  private string increasedStat;
  private string decreasedStat;

  private float increasedAmount;
  private float decreasedAmount;

  public string Size {get; set;}
  public string IncreasedStat {get; set;}
  public string DecreasedStat {get; set;}

  public float IncreasedAmount {get; set;}
  public float DecreasedAmount {get; set;}

	public BaseSize() {
    Size = "Size";
    IncreasedStat = "Stat";
    DecreasedStat = "Stat";

    IncreasedAmount = 0.2f;
    DecreasedAmount = 0.2f;

  }

}
