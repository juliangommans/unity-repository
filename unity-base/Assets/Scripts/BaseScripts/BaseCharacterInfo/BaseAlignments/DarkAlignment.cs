using UnityEngine;
using System.Collections;

public class DarkAlignment : BaseAlignment {

	public DarkAlignment(){
		Type = "Dark";
		StrongAgainstType = "Might";
		WeakAgainstType = "Light";

		IncreasedStat1 = "Attack";
		IncreasedStat2 = "Energy";
	}

}
