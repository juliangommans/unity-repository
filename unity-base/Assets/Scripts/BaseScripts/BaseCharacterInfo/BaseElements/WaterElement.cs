using UnityEngine;
using System.Collections;

public class WaterElement : BaseElement {

	public WaterElement () {
		Type = "Water";
		StrongAgainstType = "Fire";
		WeakAgainstType = "Earth";
	}

}
