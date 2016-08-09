using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class Player : BaseCharacter {

	private const string name = "Player"; // input can effect this later
	private BaseDiscipline discipline = new ElementalDiscipline(); //should be set when selected.

	public Player ()
		:base (){

		this.CharacterName = name;
		this.Discipline = discipline;
		this.Skills.Add (new TouchOfFlame (this.gameObject));
	}
}
