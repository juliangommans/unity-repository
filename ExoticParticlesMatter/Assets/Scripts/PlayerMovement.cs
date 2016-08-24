﻿using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

	private InputManager inputManager;
	private PlayerEnergy playerEnergy;
	private Rigidbody2D playerRb;

	private float forceOutput;
	public float forceFactor;

	private int cost;

	void Start () {
		inputManager = FindObjectOfType<InputManager> ();
		playerEnergy = this.GetComponent<PlayerEnergy>();
		playerRb = this.GetComponent<Rigidbody2D>();
		forceFactor = 2f;
	}

	void Update () {
		// Test Script atm (speed boost)
		if (Input.GetKeyDown (KeyCode.Space)) {
			Debug.Log ("CurrentDirection: " + playerRb.velocity.normalized);
			playerRb.AddForce (playerRb.velocity * 50f);
		}
			
	}

	void LateUpdate () {
		if (inputManager.draggingFinished){
			forceOutput = inputManager.distance * forceFactor;
			MovePlayer(inputManager.direction, forceOutput);
			CalculateCost ();
		}
	}

	public void MovePlayer (Vector2 direction, float speed){
		playerRb.AddForce (direction * speed);
	}

	private void CalculateCost () {
		switch (inputManager.dragSize) {
			case InputManager.DragSize.Short:
				cost = 1;
				break;
			case InputManager.DragSize.Medium:
				cost = 2;
				break;
			case InputManager.DragSize.Long:
				cost = 3;
				break;
		}
		Debug.Log ("Cost: " + cost);
		Debug.Log ("---------------------");
		playerEnergy.ChangeEnergy (-cost);
	}
}
