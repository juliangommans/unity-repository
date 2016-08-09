using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class CombatManager {

	public enum CombatState {
		BeforeCombat, 
		BeginRound, 
		TurnManager, 
		EndRound, 
		AfterCombat
	}
		
	private GameObject player;
	private List<GameObject> enemies;
	private CombatState combatState;
	private TurnManager turnManager;
	private int round;
	private int frameCounter;
	private GameObject enemy;
	private EnemyManager enemyManager;

	public void StartCombat (GameObject p) {
		player = p;
		enemyManager = GameObject.Find ("GameScripts").GetComponent<EnemyManager>();
		turnManager = new TurnManager ();
		enemies = enemyManager.FetchEnemies();
		combatState = CombatState.BeforeCombat;
		round = 0;
		frameCounter = 0;
	}

	public void CheckCombat () {
		frameCounter += 1;
		switch (combatState) 
		{
		case CombatState.BeforeCombat:
			combatState = CombatState.BeginRound; // Testing purposes - SHOULD give options here.
			break;
		case CombatState.BeginRound:
			turnManager.StartTurn (player, enemies);
			round += 1;
			combatState = CombatState.TurnManager;
			break;
		case CombatState.TurnManager:
			turnManager.CheckTurn ();
			if (turnManager.finishedRound == true) {
				combatState = CombatState.EndRound;
			}
			break;
		case CombatState.EndRound:
			// check if we have people alive on both sides, if yes, begin round, if no, calculate outcomes
			break;
		}
	}
}
