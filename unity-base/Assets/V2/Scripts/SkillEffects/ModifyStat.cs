using UnityEngine;
using System.Collections;

public class ModifyStat : BaseSkillEffects {

	private const string name = "Modify Stat";
	private const string description = "Modifies a combat stat (combat points, action points etc.)";

	// private const Sprite icon = Resource.Load(#path);
	private string stat;
	private int flatAmountModified;

	public string Stat { get; set; }
	public int FlatAmountModified { get; set; }


	public ModifyStat() 
		:base(new BaseObjectInformation(name, description))
	{

	}
}
