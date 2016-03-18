using UnityEngine;
using System.Collections;

public class EarthElement : BaseElement {

	void Start () {
		this.Type = "Earth";
		this.StrongAgainstType = "Water";
		this.WeakAgainstType = "Air";
	}

}
