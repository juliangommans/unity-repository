using UnityEngine;
using System.Collections;

public class FireElement : BaseElement {

	void Start () {
		this.Type = "Fire";
		this.StrongAgainstType = "Air";
		this.WeakAgainstType = "Water";
	}

}
