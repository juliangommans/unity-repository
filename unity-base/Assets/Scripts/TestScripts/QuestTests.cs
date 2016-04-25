using UnityEngine;
using System.Collections;
using QuestSystem;

public class QuestTests : MonoBehaviour {

	public GameObject item;

	// Use this for initialization
	void Start () {
		IQuestObjective qo = new CollectionObjective("Gather", 72, item, "Gather 72 Virgins", false);
		Debug.Log (qo.ToString ());
	}

}
