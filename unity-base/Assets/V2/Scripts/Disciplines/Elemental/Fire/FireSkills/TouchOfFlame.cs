using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TouchOfFlame : BaseSkill {
	
	private const string name = "Touch of Flame";
	private const string description = "A ethereal, fire based melee attack"; // in the future, pull out key words from effects
	// private const Sprite icon = Resource.Load(#path);

	private const bool canRetaliate = true;
	private const bool melee = true;
	private const bool targetOther = true;

	private const string bonusName = "Ignition";
	private const string bonusDescription ="Burns the target dealing damage each turn and returns 1 action point to the user"; // in the future, pull out key words from effects

	private BaseBonus bonus = new BaseBonus(bonusName, bonusDescription );
	private Debuff burn = new Debuff ();
	private ModifyStat ap = new ModifyStat ();


	public TouchOfFlame(GameObject o)
		:base(new BaseObjectInformation(name,description), o)
	{
		
		this.Discipline = new ElementalDiscipline();
		this.School = new FireSchool ();
		this.CanRetaliate = canRetaliate;
		this.TargetOther = targetOther;
		this.Melee = melee;

		// Setting Up Bonus Effects
		BuildBonus();

	}

	void BuildBonus(){
		this.Bonus = bonus;

		burn.Stat = "Health";
		burn.FlatAmountModified = -3;
		ap.Stat = "Action Points";
		ap.FlatAmountModified = 1;

		this.Bonus.Effects.Add (burn);
		this.Bonus.Effects.Add (ap);
	}

	public void AnnounceBonus() {
		Debug.Log (bonus.DescribeBonus ());
	}

	public override void UseSkill(){
		
	}
}
