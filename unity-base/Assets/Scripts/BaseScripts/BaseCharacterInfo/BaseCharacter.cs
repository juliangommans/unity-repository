using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;

public class BaseCharacter : MonoBehaviour {

	// Character classes/mods
	private string characterName;
	private BaseElement element;
	private BaseAlignment alignment;
	private BaseSize size;
	private BasePersonality personality;

	// Character base stats
	private int health;
	private int baseHealth;
	private int maxHealth;
	private int baseMaxHealth;
	private int attack;
	private int baseAttack;
	private int defense;
	private int baseDefense;
	private int energy;
	private int baseEnergy;// (special attack)
	private int resistance;
	private int baseResistance;// (special defence)
	private int speed;
	private int baseSpeed;

	// Character advanced stats
	private int shield; // (absorbs damage, resets each round)
	private int baseShield;
	private int resilience; // (reduces debuff duration 0-4 each)
	private int baseResilience;
	private int retaliations; // (defaults to one retaliation a round)
	private int baseRetaliations;
	private int retaliationDamage; // (defaults to 50%)
	private int baseRetaliationDamage;
	private int comboPoints; // (starts at zero, once it reaches max, 4, attacks do extra things)
	private int baseComboPoints;
	private int maxComboPoints;
	private int baseMaxComboPoints;
	private int actionPoints; // (used on abilities, start with 4 max)
	private int baseActionPoints;
	private int maxActionPoints;
	private int baseMaxActionPoints;
	private int gloabalCooldownReduction;
	private int baseGlobalCooldownReduction;

	// Character passive modifiers - might need to impliment/learn about c# lists
	public List<GameObject> buffs;
	public List<GameObject> deBuffs;
	public List<BasePassive> passives = new List<BasePassive>();

	// Experience and OOC stats
	private int level;
	private int experience;

	// Getters and Setters
	public string CharacterName {get; set;}
	public BaseElement Element {get; set;}
	public BaseAlignment Alignment {get; set;}
	public BaseSize Size {get; set;}
	public BasePersonality Personality {get; set;}

	public int Health {get; set;}
	public int BaseHealth { get; set; }
	public int MaxHealth {get; set;}
	public int BaseMaxHealth { get; set; }
	public int Attack {get; set;}
	public int BaseAttack {get; set;}
	public int Defense {get; set;}
	public int BaseDefense {get; set;}
	public int Energy {get; set;}
	public int BaseEnergy {get; set;}
	public int Resistance {get; set;}
	public int BaseResistance {get; set;}
	public int Speed {get; set;}
	public int BaseSpeed {get; set;}

	public int Shield {get; set;}
	public int BaseShield { get; set; }
	public int Resilience {get; set;}
	public int BaseResilience {get; set;}
	public int Retaliations {get; set;}
	public int BaseRetaliations {get; set;}
	public int RetaliationDamage {get; set;}
	public int BaseRetaliationDamage {get; set;}
	public int ComboPoints {get; set;}
	public int BaseComboPoints {get; set;}
	public int MaxComboPoints {get; set;}
	public int BaseMaxComboPoints {get; set;}
	public int ActionPoints {get; set;}
	public int BaseActionPoints {get; set;}
	public int MaxActionPoints {get; set;}
	public int BaseMaxActionPoints {get; set;}
	public int GlobalCooldownReduction {get; set;}
	public int BaseGlobalCooldownReduction {get; set;}

	public int Level {get; set;}
	public int Experience {get; set;}

	public BaseCharacter (){
		CharacterName = "Character";
		Element = new BaseElement(); // earth/fire/water/air
		Alignment = new BaseAlignment(); // dark/light/mind/might
		Size = new BaseSize(); // big/small/medium
		Personality = new BasePersonality(); // reserved/aggressive/focused/adaptable

		BaseHealth = 300;
		BaseMaxHealth = 300;
		BaseAttack = 30;
		BaseDefense = 30;
		BaseEnergy = 30;
		BaseResistance = 30;
		BaseSpeed = 30;

		BaseShield = 5;
		BaseResilience = 0;
		BaseRetaliations = 1;
		BaseRetaliationDamage = 5;
		BaseComboPoints = 0;
		BaseMaxComboPoints = 3;
		BaseActionPoints = 0;
		BaseMaxActionPoints = 4;
		BaseGlobalCooldownReduction = 0;

		Level = 0;
		Experience = 0;
	}

// This should be called whenever there is a change to anyones stats (maybe once per update)
// i.e. keeps the % increase relevent to the current state of the game
	public void ImplimentTraits () { 
//		ImplimentElements ();
		ResetStats();
		ImplimentAlignments ();
		ImplimentSizes ();
		ImplimentPassives ();
//		ImplimentPersonalities ();
	}

	void ImplimentElements (){
		Debug.Log ("nothing for elements to do here");
	}

	void ImplimentAlignments (){
		if (Alignment.IncreasedStat1 != null)
			UpdateStats (Alignment.IncreasedStat1, Alignment.IncreasedAmount1);
		if (Alignment.IncreasedStat2 != null)
			UpdateStats (Alignment.IncreasedStat2, Alignment.IncreasedAmount2);
	}

	void ImplimentSizes (){
		if (Size.IncreasedStat != null)
			UpdateStats (Size.IncreasedStat, Size.IncreasedAmount);
		if (Size.DecreasedStat != null)
			UpdateStats (Size.DecreasedStat, Size.DecreasedAmount);
	}

	void ImplimentPassives(){
		foreach (BasePassive passive in passives){
			if (passive.actionPhase == BasePassive.ActionPhase.STATIC){
				passive.PassiveAction (this);
				//do something
			}
		}
		Debug.Log ("no passives here yet captn");
	}

	void ImplimentPersonalities (){
		if (Personality.PrimaryEffectedStat != null)
			UpdateStats (Personality.PrimaryEffectedStat, Personality.PrimaryAmountChanged);
		if (Personality.SecondaryEffectedStat != null)
			UpdateStats(Personality.SecondaryEffectedStat, Personality.SecondaryAmountChanged);
	}

	void UpdateStats (string stat, float percent){
		switch (stat) {
		// Base stats
		case "Health":
			Health += (int)(BaseHealth * percent);
			break;
		case "MaxHealth":
			MaxHealth += (int)(BaseMaxHealth * percent);
			break;
		case "Attack":
			Attack += (int)(BaseAttack * percent);
			break;
		case "Defense":
			Defense += (int)(BaseDefense * percent);
			break;
		case "Energy":
			Energy += (int)(BaseEnergy * percent);
			break;
		case "Resistance":
			Resistance += (int)(BaseResistance * percent);
			break;
		case "Speed":
			Speed += (int)(BaseSpeed * percent);
			break;
		// Advanced stats
		case "Shield":
			Shield += (int)(BaseShield * percent);
			break;
		case "Resilience":
			Resilience += (int)(BaseResilience * percent);
			break;
		case "Retaliations":
			Retaliations += (int)(BaseRetaliations * percent);
			break;
		case "RetaliationDamage":
			RetaliationDamage += (int)(BaseRetaliationDamage * percent);
			break;
		case "ComboPoints":
			ComboPoints += (int)(BaseComboPoints * percent);
			break;
		case "MaxComboPoints":
			MaxComboPoints += (int)(BaseMaxComboPoints * percent);
			break;
		case "ActionPoints":
			ActionPoints += (int)(BaseActionPoints * percent);
			break;
		case "MaxActionPoints":
			MaxActionPoints += (int)(BaseMaxActionPoints * percent);
			break;
		case "GlobalCooldownReduction":
			GlobalCooldownReduction += (int)(BaseGlobalCooldownReduction * percent);
			break;
		}
	}

	public void UpdateBaseStats (string stat, int change){
		switch (stat) {
// Base stats
		case "Health":
			BaseHealth += change;
			break;
		case "MaxHealth":
			BaseMaxHealth += change;
			break;
		case "Attack":
			BaseAttack += change;
			break;
		case "Defense":
			BaseDefense += change;
			break;
		case "Energy":
			BaseEnergy += change;
			break;
		case "Resistance":
			BaseResistance += change;
			break;
		case "Speed":
			BaseSpeed += change;
			break;
// Advanced stats
		case "Shield":
			BaseShield += change;
			break;
		case "Resilience":
			BaseResilience += change;
			break;
		case "Retaliations":
			BaseRetaliations += change;
			break;
		case "RetaliationDamage":
			BaseRetaliationDamage += change;
			break;
		case "ComboPoints":
			BaseComboPoints += change;
			break;
		case "MaxComboPoints":
			BaseMaxComboPoints += change;
			break;
		case "ActionPoints":
			BaseActionPoints += change;
			break;
		case "MaxActionPoints":
			BaseMaxActionPoints += change;
			break;
		case "GlobalCooldownReduction":
			BaseGlobalCooldownReduction += change;
			break;
		}
	}

	public void ResetStats (){
		Health = BaseHealth;
		MaxHealth = BaseMaxHealth;
		Attack = BaseAttack;
		Defense = BaseDefense;
		Energy = BaseEnergy;
		Resistance = BaseResistance;
		Speed = BaseSpeed;

		Shield = BaseShield;
		Resilience = BaseResilience;
		Retaliations = BaseRetaliations;
		RetaliationDamage = BaseRetaliationDamage;
		GlobalCooldownReduction = BaseGlobalCooldownReduction;
	}
}
