using UnityEngine;
using System.Collections;

public class LightAlignment : BaseAlignment {

	public LightAlignment(){
		Type = "Light";
		StrongAgainstType = "Dark";
		WeakAgainstType = "Mind";

		IncreasedStat1 = "Defense";
		IncreasedStat2 = "Resistance";
	}

}
