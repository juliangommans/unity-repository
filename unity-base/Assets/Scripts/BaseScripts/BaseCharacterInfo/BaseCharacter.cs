using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacter : MonoBehaviour {

// Character classes/mods
  private string characterName;
  private BaseElement element;
  private string alignment;
  private string size;
  private string personality;

// Character base stats
  private int health;
  private int maxHealth;
  private int attack;
  private int defense;
  private int energy; // (special attack)
  private int resistence; // (special defence)
  private int speed;

// Character advanced stats
  private int shield; // (absorbs damage, resets each round)
  private int resilience; // (reduces debuff duration 0-4 each)
  private int retaliation; // (defaults to one retaliation a round)
  private float retaliationDamage; // (defaults to 50%)
  private int comboPoints; // (starts at zero, once it reaches max, 4, attacks do extra things)
  private int maxComboPoints;
  private int actionPoints; // (used on abilities, start with 4 max)
  private int maxActionPoints;

// Character passive modifiers - might need to impliment/learn about c# lists
  public List<GameObject> buffs;
  public List<GameObject> deBuffs;
  public List<GameObject> passives;

// Experience and OOC stats
  private int level;
  private int experience;

// Getters and Setters
  public string CharacterName {get; set;}
  public BaseElement Element {get; set;}
  public string Alignment {get; set;}
  public string Size {get; set;}
  public string Personality {get; set;}

  public int Health {get; set;}
  public int MaxHealth {get; set;}
  public int Attack {get; set;}
  public int Defense {get; set;}
  public int Energy {get; set;}
  public int Resistence {get; set;}
  public int Speed {get; set;}

  public int Shield {get; set;}
  public int Resilience {get; set;}
  public int Retaliation {get; set;}
  public float RetaliationDamage {get; set;}
  public int ComboPoints {get; set;}
  public int MaxComboPoints {get; set;}
  public int ActionPoints {get; set;}
  public int MaxActionPoints {get; set;}

  public int Level {get; set;}
  public int Experience {get; set;}

	public BaseCharacter (){
	  CharacterName = "Character";
	  Element = new BaseElement(); // earth/fire/water/air
	  Alignment = "Alignment"; // dark/light/mind/might
	  Size = "Size"; // big/small/medium
	  Personality = "Personality"; // reserved/aggressive/focused/adaptable

	  Health = 300;
	  MaxHealth = 300;
	  Attack = 30;
	  Defense = 30;
	  Energy = 30;
	  Resistence = 30;
	  Speed = 30;

	  Shield = 5;
	  Resilience = 0;
	  Retaliation = 1;
	  RetaliationDamage = 0.5f;
	  ComboPoints = 0;
	  MaxComboPoints = 3;
	  ActionPoints = 0;
	  MaxActionPoints = 4;

	  Level = 0;
	  Experience = 0;
	}
}
