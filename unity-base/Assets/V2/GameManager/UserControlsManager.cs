using UnityEngine;
using System.Collections;

public class UserControlsManager : MonoBehaviour {

	private bool targetSelected;
	private GameObject target;
//	private GameObject user;
//
//	vo

	void Update () {
		if (targetSelected) {
			GetComponent<GameManager> ().Player.GetComponent<BaseCharacter> ().CurrentTarget = target;
			targetSelected = false;
		}
		SelectTarget ();
	}

	void SelectTarget (){
		if (Input.GetMouseButtonDown (0)) {
			target = CheckForTarget ();
			if (target != null) {
				targetSelected = true;
			}
		}
	}

	private GameObject CheckForTarget(){
		//Converting Mouse Pos to 2D (vector2) World Pos
		Vector2 rayPos = new Vector2(Camera.main.ScreenToWorldPoint(Input.mousePosition).x, Camera.main.ScreenToWorldPoint(Input.mousePosition).y);
		RaycastHit2D hit=Physics2D.Raycast(rayPos, Vector2.zero, 0f);

		if (hit)
		{
			Debug.Log("YOU SELECTED: " + hit.transform.name);
			return hit.transform.gameObject;
		}
		else return null;
	}
}
