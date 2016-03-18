using UnityEngine;
using System.Collections;

public class CharacterTestButton : MonoBehaviour {

	public NewPlayer playa;

	void Start(){
		playa = GameObject.Find ("PlayerTest").GetComponent<NewPlayer> ();
	}

	public void SetElement(){
		
		Debug.Log ("currently playa is "+ playa.player.Element.Type);
		playa.player.Element = new WaterElement ();
		Debug.Log ("currently playa is "+ playa.player.Element.Type);
		Debug.Log ("playa SAME "+ playa.player.Element.SameElementBonus);
		Debug.Log ("playa str "+ playa.player.Element.StrengthBonus);

	}
}
