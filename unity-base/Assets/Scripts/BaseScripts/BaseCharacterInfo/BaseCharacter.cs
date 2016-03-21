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
  private int maxHealth;
  private int attack;
  private int defense;
  private int energy; // (special attack)
  private int resistance; // (special defence)
  private int speed;

// Character advanced stats
  private int shield; // (absorbs damage, resets each round)
  private int resilience; // (reduces debuff duration 0-4 each)
  private int retaliations; // (defaults to one retaliation a round)
  private int retaliationDamage; // (defaults to 50%)
  private int comboPoints; // (starts at zero, once it reaches max, 4, attacks do extra things)
  private int maxComboPoints;
  private int actionPoints; // (used on abilities, start with 4 max)
  private int maxActionPoints;
  private int gloabalCooldownReduction;

// Character passive modifiers - might need to impliment/learn about c# lists
  public List<GameObject> buffs;
  public List<GameObject> deBuffs;
  public List<GameObject> passives;

	// not sure if these are needed yet
  public List<GameObject> baseStats;
  public List<GameObject> advancedStats;

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
  public int MaxHealth {get; set;}
  public int Attack {get; set;}
  public int Defense {get; set;}
  public int Energy {get; set;}
  public int Resistance {get; set;}
  public int Speed {get; set;}

  public int Shield {get; set;}
  public int Resilience {get; set;}
  public int Retaliations {get; set;}
  public int RetaliationDamage {get; set;}
  public int ComboPoints {get; set;}
  public int MaxComboPoints {get; set;}
  public int ActionPoints {get; set;}
  public int MaxActionPoints {get; set;}
  public int GlobalCooldownReduction {get; set;}

  public int Level {get; set;}
  public int Experience {get; set;}

	public BaseCharacter (){
	  CharacterName = "Character";
	  Element = new BaseElement(); // earth/fire/water/air
	  Alignment = new BaseAlignment(); // dark/light/mind/might
	  Size = new BaseSize(); // big/small/medium
	  Personality = new BasePersonality(); // reserved/aggressive/focused/adaptable

	  Health = 300;
	  MaxHealth = 300;
	  Attack = 30;
	  Defense = 30;
	  Energy = 30;
	  Resistance = 30;
	  Speed = 30;

	  Shield = 5;
	  Resilience = 0;
	  Retaliations = 1;
	  RetaliationDamage = 5;
	  ComboPoints = 0;
	  MaxComboPoints = 3;
	  ActionPoints = 0;
	  MaxActionPoints = 4;
	  GlobalCooldownReduction = 0;

	  Level = 0;
	  Experience = 0;
	}

	public void ImplimentTraits () {
		ImplimentElements ();
		ImplimentAlignments ();
		ImplimentSizes ();
		ImplimentPersonalities ();
	}

	void ImplimentElements (){
		Debug.Log ("nothing for elements to do here");
	}

	void ImplimentAlignments (){
		if (Alignment.IncreasedStat1 != null)
			UpdateStats (Alignment.IncreasedStat1, Alignment.IncreasedAmount1, 0);
		if (Alignment.IncreasedStat2 != null)
			UpdateStats (Alignment.IncreasedStat2, Alignment.IncreasedAmount2, 0);
	}

	void ImplimentSizes (){
		if (Size.IncreasedStat != null)
			UpdateStats (Size.IncreasedStat, Size.IncreasedAmount, 0);
		if (Size.DecreasedStat != null)
			UpdateStats (Size.DecreasedStat, Size.DecreasedAmount, 0);
	}

	void ImplimentPersonalities (){
		if (Personality.PrimaryEffectedStat != null)
			UpdateStats (Personality.PrimaryEffectedStat, 0, Personality.PrimaryAmountChanged);
		if (Personality.SecondaryEffectedStat != null)
			UpdateStats(Personality.SecondaryEffectedStat, 0, Personality.SecondaryAmountChanged);
	}

	void UpdateStats (string stat, float percent, int change){
		switch (stat) {
		// Base stats
		case "Health":
			Health = (int)(Health * percent);
			break;
		case "MaxHealth":
			MaxHealth = (int)(MaxHealth * percent);
			break;
		case "Attack":
			Attack = (int)(Attack * percent);
			break;
		case "Defense":
			Defense = (int)(Defense * percent);
			break;
		case "Energy":
			Energy = (int)(Energy * percent);
			break;
		case "Resistance":
			Resistance = (int)(Resistance * percent);
			break;
		case "Speed":
			Speed = (int)(Speed * percent);
			break;
		// Advanced stats
		case "Shield":
			Shield += change;
			break;
		case "Resilience":
			Resilience += change;
			break;
		case "Retaliations":
			Retaliations += change;
			break;
		case "RetaliationDamage":
			RetaliationDamage += change;
			break;
		case "ComboPoints":
			ComboPoints += change;
			break;
		case "MaxComboPoints":
			MaxComboPoints += change;
			break;
		case "ActionPoints":
			ActionPoints += change;
			break;
		case "MaxActionPoints":
			MaxActionPoints += change;
			break;
		case "GlobalCooldownReduction":
			GlobalCooldownReduction += change;
			break;
		}
	}
}
