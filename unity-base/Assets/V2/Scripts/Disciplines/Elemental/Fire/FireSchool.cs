using UnityEngine;
using System.Collections;

public class FireSchool : BaseSchool {

	private const string name = "Fire";
	private const string strongAgainst = "Ice";
	private const string weakAgainst = "Fire";


	public FireSchool () {
		this.Name = name;
		this.StrongAgainst = strongAgainst;
		this.WeakAgainst = weakAgainst;

	}

}
