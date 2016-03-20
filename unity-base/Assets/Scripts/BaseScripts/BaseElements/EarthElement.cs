using UnityEngine;
using System.Collections;

public class EarthElement : BaseElement {

	public EarthElement () {
		Type = "Earth";
		StrongAgainstType = "Water";
		WeakAgainstType = "Air";
	}

}
