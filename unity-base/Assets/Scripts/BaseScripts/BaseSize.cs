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

  void Awake() {
    this.Size = "Size";
    this.IncreasedStat = "Stat";
    this.DecreasedStat = "Stat";

    this.IncreasedAmount = 0.2f;
    this.DecreasedAmount = 0.2f;

  }

}
