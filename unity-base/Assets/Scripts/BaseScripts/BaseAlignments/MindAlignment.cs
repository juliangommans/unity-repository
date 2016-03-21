using UnityEngine;
using System.Collections;

public class MindAlignment : BaseAlignment {

	public MindAlignment(){
		Type = "Mind";
		StrongAgainstType = "Light";
		WeakAgainstType = "Might";

		IncreasedStat1 = "Energy";
		IncreasedStat2 = "Resistance";
	}

}
