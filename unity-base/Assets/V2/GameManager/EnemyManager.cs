using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class EnemyManager : MonoBehaviour {

	private List<GameObject> enemies;
	private GameObject enemy;

	public List<GameObject> FetchEnemies(){
		CalculateEnemies ();
		return enemies;
	}

	void Awake(){
		enemies = new List<GameObject> ();
	}

	private void CalculateEnemies(){
// in future we need logic to add the types of enemies we want to the list
		enemy = (GameObject)Instantiate(Resources.Load("prefabs/Enemy1"));
		if (enemy != null) {
			Debug.Log ("enemy = " + enemy);
			enemies.Add (enemy);
		} else {
			Debug.Log("NULL BITCH");
		}
		enemy = (GameObject)Instantiate(Resources.Load("prefabs/Enemy2"));
		enemies.Add (enemy);
	}


}
