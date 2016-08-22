using UnityEngine;
using System.Collections;

public class PlayerControls : MonoBehaviour {

	private GameObject playerGameObject;
	private Rigidbody2D playerRb;

	private Vector2 startDrag;
	private Vector2 endDrag;
	private Vector2 direction;

	private float distance;
	private float forceOutput;
	public float forceFactor;

	// Use this for initialization
	void Start () {
		playerGameObject = this.GetComponent<GameObject>();
		playerRb = this.GetComponent<Rigidbody2D>();
		forceFactor = 0.01f;
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			startDrag = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
			Debug.Log ("StartDrag = " + startDrag);
		}
		if (Input.GetMouseButtonUp (0)) {
			endDrag = new Vector2(Input.mousePosition.x,Input.mousePosition.y);
			direction = startDrag - endDrag;
			distance = Vector2.Distance (startDrag, endDrag);
			forceOutput = distance * forceFactor;

			Debug.Log ("EndDrag = " + endDrag);
			Debug.Log ("direction = " + direction);
			Debug.Log ("DISTANCE = " + distance);
			Debug.Log ("FORCE FACTOR NINE THOUSAND = " + forceOutput);
			FireInTheHole ();
		}
	
	}

	private void FireInTheHole(){
		Debug.Log ("player? " + playerRb);
		playerRb.AddForce (direction * forceOutput);
	}
}
