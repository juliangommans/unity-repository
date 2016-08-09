using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class DummyEnemy : BaseCharacter {

	private const string name = "Dummy Enemy"; // input can effect this later
	private BaseDiscipline discipline = new ElementalDiscipline(); //should be set when selected.

	public DummyEnemy ()
		:base (){

		this.BaseHealth = 100;
		this.BaseMaxHealth = 100;
		this.BaseAttack = 10;
		this.BaseDefense = 10;
		this.BaseEtherealDamage = 10;
		this.BaseEtherealResistance = 10;
		this.BaseSpeed = 10;

		this.CharacterName = name;
		this.Discipline = discipline;
		this.Skills.Add (new TouchOfFlame (this.gameObject));
	}
}

