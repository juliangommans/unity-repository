using UnityEngine;
using System.Collections;

public class AirElement : BaseElement {

	void Start () {
		this.Type = "Air";
		this.StrongAgainstType = "Earth";
		this.WeakAgainstType = "Fire";
	}

}
