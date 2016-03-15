using UnityEngine;
using System.Collections;

public class BaseElements : MonoBehaviour {

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

  void Awake(){
    this.Type = "Element"; // name of this element
    this.StrongAgainstType = "Element1"; // what this element is strong against
    this.WeakAgainstType = "Element2";  // what this element is weak against

    this.SameElementBonus = 0.2f;
    this.StrengthBonus = 0.3f;
    this.ResistedBonus = 0.3f;
  }

}
