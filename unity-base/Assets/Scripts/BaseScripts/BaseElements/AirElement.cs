using UnityEngine;
using System.Collections;

public class AirElement : BaseElement {

	public AirElement () {
		Type = "Air";
		StrongAgainstType = "Earth";
		WeakAgainstType = "Fire";
	}

}
