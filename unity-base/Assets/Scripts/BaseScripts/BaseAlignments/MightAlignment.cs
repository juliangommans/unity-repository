using UnityEngine;
using System.Collections;

public class MightAlignment : BaseAlignment {

	public MightAlignment(){
		Type = "Might";
		StrongAgainstType = "Mind";
		WeakAgainstType = "Dark";

		IncreasedStat1 = "Attack";
		IncreasedStat2 = "Defense";
	}

}
