using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class TurnManager : MonoBehaviour {

	public enum TurnState {
		BeginTurn, // player/opponentes choose actions
		ManageOutcome, // actions based on player/opponent actions
		EndTurn, // report outcomes, list new totals
		EndOfRound // something that is always checked, when no further actions are available
	}

	private TurnState turnState;
	private List<GameObject> characters;

	private GameObject player;
	private List<GameObject> enemies;

	// bools
	public bool finishedRound;
	private bool playerSelectedAction;
	private bool turnActionsComplete;
	private bool inAction;


	public void StartTurn (GameObject p, List<GameObject> e){
		finishedRound = false;
		turnState = TurnState.BeginTurn;
		player = p;
		enemies = e;
		characters = enemies;
		characters.Add (player);
		playerSelectedAction = false;
		turnActionsComplete = false;
		inAction = false;
	}
		
	public void CheckTurn () {
		switch(turnState)
		{
		case TurnState.BeginTurn:
			// wait for player to choose his action
			if (player.GetComponent<Player>().MadeSelection) {
				// auto select opponents actions

				turnState = TurnState.ManageOutcome;
				SpeedCalculation ();
			}

			break;
		case TurnState.ManageOutcome:
			// do actions, animations, calculations etc.
			if (!inAction){
				// start waitforXseconds until all actions have been taken
			}
			if (turnActionsComplete) {
				turnState = TurnState.EndTurn;
			}
			break;
		case TurnState.EndTurn:
			// actions have occured, we have the outcome, now begin turn again if we have AP left over
			break;
		case TurnState.EndOfRound:
			finishedRound = true;
			break;
		}
	}

	void SpeedCalculation (){
		Debug.Log ("before " + characters[0].GetComponent<BaseCharacter>().CharacterName);
		characters.Sort ((x, y) => x.GetComponent<BaseCharacter>().Speed.CompareTo (y.GetComponent<BaseCharacter>().Speed));
		Debug.Log ("after " + characters[0].GetComponent<BaseCharacter>().CharacterName);
	}
}
