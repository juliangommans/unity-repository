using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BaseDiscipline {

	private string name;
	private string modifiedStat;
	private float modifyPercent;
	public List<BaseSkill> skills;

	public string Name { get; set; }
	public string ModifiedStat { get; set; }
	public float ModifyPercent { get; set; }

	public BaseDiscipline(){
		Name = "Discipline";
		ModifiedStat = "Stat";
		ModifyPercent = 1.2f;
	}
}
