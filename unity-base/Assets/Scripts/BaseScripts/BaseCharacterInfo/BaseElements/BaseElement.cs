using UnityEngine;
using System.Collections;

public class BaseElement {

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


  public BaseElement(){
	Type = null;
	StrongAgainstType = null;
	WeakAgainstType = null;

	SameElementBonus = 0.2f;
	StrengthBonus = 0.3f;
	ResistedBonus = 0.3f;
  }
}
