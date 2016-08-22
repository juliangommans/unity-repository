using UnityEngine;
using System.Collections;

public class Button : MonoBehaviour {

	public GameObject player;
	public int healthChange;
	
	public void ChangePlayersHealth() {
		player.GetComponent<PlayerHealth>().ChangeHealth (healthChange);
	}
}
