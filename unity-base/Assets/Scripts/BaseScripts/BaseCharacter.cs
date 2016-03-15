﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class BaseCharacter : MonoBehaviour {

// Character classes/mods
  private string characterName;
  private string element;
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
  public string Element {get; set;}
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

  void Awake (){
    this.CharacterName = "Character";
    this.Element = "Element"; // earth/fire/water/air
    this.Alignment = "Alignment"; // dark/light/mind/might
    this.Size = "Size"; // big/small/medium
    this.Personality = "Personality"; // reserved/aggressive/focused/adaptable

    this.Health = 300;
    this.MaxHealth = 300;
    this.Attack = 30;
    this.Defense = 30;
    this.Energy = 30;
    this.Resistence = 30;
    this.Speed = 30;

    this.Shield = 5;
    this.Resilience = 0;
    this.Retaliation = 1;
    this.RetaliationDamage = 0.5f;
    this.ComboPoints = 0;
    this.MaxComboPoints = 3;
    this.ActionPoints = 0;
    this.MaxActionPoints = 4;

    this.Level = 0;
    this.Experience = 0;
  }


}
