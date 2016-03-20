using UnityEngine;
using System.Collections;

public class BaseAlignment : MonoBehaviour {

  private string type;
  private string strongAgainstType;
  private string weakAgainstType;

  private float sameElementBonus;
  private float strengthBonus;
  private float resistedBonus;

  public string Type {get; set;}
  public string StrongAgainstType {get; set;}
  public string WeakAgainstType {get; set;}

  public float SameElementBonus {get; set;}
  public float StrengthBonus {get; set;}
  public float ResistedBonus {get; set;}

// Passive bonuses to stats
  private string increasedStat;
  private string increasedStat2;

  private float increasedAmount;
  private float increasedAmount2;

  public string IncreasedStat {get; set;}
  public string IncreasedStat2 {get; set;}

  public float IncreasedAmount {get; set;}
  public float IncreasedAmount2 {get; set;}

	public BaseAlignment(){
    Type = "Element"; // name of this element
    StrongAgainstType = "Element1"; // what this element is strong against
    WeakAgainstType = "Element2";  // what this element is weak against

    SameElementBonus = 0.2f;
    StrengthBonus = 0.3f;
    ResistedBonus = 0.3f;

// Alignment is half elemnet, half size in terms of effects
    IncreasedStat = "Stat";
    IncreasedStat2 = "Stat2";

    IncreasedAmount = 0.2f;
    IncreasedAmount2 = 0.2f;
  }
}
