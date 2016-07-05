using UnityEngine;
using System.Collections;

public class BaseSkill : MonoBehaviour {
	
	private string name;
	private int power;
	private float bonusMultiplier;
	private string discipline;
	private string school;

	public string Name { get; set; }
	public int Power{ get; set; }
	public float BonusMultiplier{ get; set; }
	public string Discipline{ get; set; }
	public string School{ get; set; }

	public BaseSkill () {
		Name = "Skill";
		Power = 10;
		BonusMultiplier = 1.5f;
		Discipline = "Discipline";
		School = "School";
	}
}
