using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class Buff : BaseSkillEffects {

	private const string name = "Buff";
	private const string description = "Applies a positive effect to the target for it's duration.";

	// private const Sprite icon = Resource.Load(#path);
	private string stat;
	private float percentModified;
	private int flatAmountModified;
	private int baseDuration; // Duration is number of rounds
	private int remainingDuration;


	public Buff() 
		:base(new BaseObjectInformation(name, description))
	{
		
	}
}
