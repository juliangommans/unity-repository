using UnityEngine;
using System.Collections;

public class FireElement : BaseElement {

	public FireElement () {
		Type = "Fire";
		StrongAgainstType = "Air";
		WeakAgainstType = "Water";
	}

}
