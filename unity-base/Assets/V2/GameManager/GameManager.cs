using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {
	
	public static GameManager Instance;

	public enum GameState
	{
		Paused,
		World,
		Combat,
		Town
	}
		
	private GameObject player;
	private GameState gameState;
	private CombatManager combatManager;

	public GameObject Player { get {return player;} }
	public string Test = "testing";

	void Awake() {
		Instance = this;
		player = (GameObject)Instantiate(Resources.Load("prefabs/Player"));
		gameState = GameState.Paused;
	}

	void Update () {

		switch(gameState) 
		{
		case GameState.Paused:
			if (true) { // Testing purposes - SHOULD give options here.
				combatManager = new CombatManager();
				combatManager.StartCombat(Player);
				gameState = GameState.Combat;
			}
			break;
		case GameState.Combat:
			combatManager.CheckCombat ();
			break;

		}

	}


}
