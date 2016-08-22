using UnityEngine;
using System.Collections;

public class PlayerMove : MonoBehaviour {

	float speed = 10.0f;

	public bool canMove;
	
	// Update is called once per frame
	void Update () {
		if (!canMove) {
			return;
		}
		var move = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0);
		transform.position += move * speed * Time.deltaTime;
	}
}
