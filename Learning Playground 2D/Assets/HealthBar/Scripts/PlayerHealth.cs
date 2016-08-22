using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour {


	private int health;
	private int maxHealth = 100;
	public Slider healthSlider;

	// Use this for initialization
	void Start () {
		health = maxHealth;
		healthSlider.maxValue = maxHealth;
		healthSlider.value = health;
	}
	
	// Update is called once per frame
	public void ChangeHealth (int change) {
		health += change;
		if (health > maxHealth) {
			health = maxHealth;
		}
		if (health < 0) {
			health = 0;
		}
		healthSlider.value = health;
		Debug.Log ("health eees " + health);
	}
}
