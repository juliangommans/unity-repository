using UnityEngine;
using System.Collections;
using System;
using System.Linq.Expressions;

public class CharacterTestButton : MonoBehaviour {

	public NewPlayer playa;

	void Start(){
		playa = GameObject.Find ("PlayerTest").GetComponent<NewPlayer> ();
	}

	public void SetElement(){
		
		Debug.Log ("Health befores "+ playa.player.Health);
		Debug.Log ("Attack befores "+ playa.player.Attack);
		Debug.Log ("Speed befores "+ playa.player.Speed);

		playa.player.Element = new WaterElement ();
		playa.player.Alignment = new MightAlignment ();
		playa.player.Size = new BigSize ();
		playa.player.Personality = new AggressivePersonality ();

		playa.player.ImplimentTraits ();

		Debug.Log ("Health AFTER "+ playa.player.Health);
		Debug.Log ("Attack AFTER "+ playa.player.Attack);
		Debug.Log ("Speed AFTER "+ playa.player.Speed);

	}

}
