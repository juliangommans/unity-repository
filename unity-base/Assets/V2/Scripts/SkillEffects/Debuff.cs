using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Debuff : BaseSkillEffects {

	private const string name = "Debuff";
	private const string description = "Applies a negative effect to the target for it's duration.";

	// private const Sprite icon = Resource.Load(#path);
	private string stat;
	private float percentModified;
	private int flatAmountModified;
	private int baseDuration; // Duration is number of rounds
	private int remainingDuration;

	public string Stat { get; set; }
	public float PercentModified { get; set; }
	public int FlatAmountModified { get; set; }
	public int BaseDuration { get; set; }
	public int RemainingDuration { get; set; }


	public Debuff() 
		:base(new BaseObjectInformation(name, description))
	{
		this.BaseDuration = 3;
		this.RemainingDuration = 3;
	}
}
