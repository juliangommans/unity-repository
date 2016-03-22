using UnityEngine;
using System.Collections;
using System;
using System.Linq.Expressions;

public class CharacterTestButton : MonoBehaviour {

	public NewPlayer playa;
	BasePassive shieldingPassive;

	void Start(){
		playa = GameObject.Find ("PlayerTest").GetComponent<NewPlayer> ();
		shieldingPassive = new ShieldingPassive();
	}

	public void SetElement(){
		
		Debug.Log ("Health befores "+ playa.player.Health);
		Debug.Log ("Attack befores "+ playa.player.Attack);
		Debug.Log ("Shield befores "+ playa.player.Shield);
		Debug.Log ("passives? " + playa.player.passives + " AND " + shieldingPassive);

		playa.player.Element = new WaterElement ();
		playa.player.Alignment = new MightAlignment ();
		playa.player.Size = new BigSize ();
		playa.player.Personality = new AggressivePersonality ();

		playa.player.passives.Add (shieldingPassive);


		playa.player.ImplimentTraits ();

		Debug.Log ("Health AFTER "+ playa.player.Health);
		Debug.Log ("Attack AFTER "+ playa.player.Attack);
		Debug.Log ("Shield AFTER "+ playa.player.Shield);

	}

}
