using UnityEngine;
using System.Collections;

public class ElementalDiscipline : BaseDiscipline {

	private const string name = "Elemental";
	private const string modifiedStat = "Ethereal Damage";

	public ElementalDiscipline () {
		this.Name = name;
		this.ModifiedStat = modifiedStat;
	}

}
