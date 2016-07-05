using UnityEngine;
using System.Collections.Generic;
using System.Collections;

public class BaseDiscipline : MonoBehaviour {

	private string name;
	private string modifiedStat;
	private float modifyPercent;
	public List<BaseSkill> skills;

	public string Name { get; set; }
	public string ModifiedStat { get; set; }
	public string ModiftPercent { get; set; }

	public BaseDiscipline(){
		Name = "Discipline";
		ModifiedStat = "Stat";
		modifyPercent = 1.2f;
	}
}
