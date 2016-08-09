using UnityEngine;
using System.Collections;

public class AreaOfEffect : BaseSkillEffects {

	private const string name = "Area of Effect";
	private const string description = "An area of effect attack";
	// private const Sprite icon = Resource.Load(#path);

	// specific to aoe
	private bool targeted; // if true, one target receieves full damage and X others nearby receive less.
	private float targetMultiplier; // how much damage the target takes
	private int numberOfTargets; // if targeted, this matters
	private float aoeMultiplier; // if targeted how much multiplied damage do the otehr target receive


	public AreaOfEffect(bool tar, float tarMulti, float aoeMulti, int numOfTars) 
		:base(new BaseObjectInformation(name, description))
	{
		targeted = tar;
		targetMultiplier = tarMulti;
		aoeMultiplier = aoeMulti;
		numberOfTargets = numOfTars;
	}

	public bool Targeted{ get { return targeted; } }
	public float TargetMultiplier{ get { return targetMultiplier; } }
	public int NumberOfTargets{ get { return numberOfTargets; } }
	public float AoeMultiplier{ get { return aoeMultiplier; } }
}
