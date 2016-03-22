using UnityEngine;
using System.Collections;

public class BasePassive {

	private string type;
	private string tree;
	private string description;
	private int tier;
	private int requiredLevel;
	private int requiredTreePoints; // you need to have spent X points to get this

	public ActionPhase actionPhase;

	public string Type { get; set; }
	public string Tree { get; set; }
	public string Description { get; set; }
	public int Tier { get; set;}
	public int RequiredLevel { get; set; }
	public int RequiredTreePoints { get; set; }

	public enum ActionPhase {
		BEFORE,
		DURING,
		AFTER,
		STATIC // always
	}

	public BasePassive (){
		Type = null;
		Tree = null;
		Description = null;
		Tier = 1;
		RequiredLevel = 1;
		RequiredTreePoints = 0;
		actionPhase = ActionPhase.STATIC;
	}

	public virtual void PassiveAction(BaseCharacter player){

	}
}
