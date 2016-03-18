using UnityEngine;
using System.Collections;

public class BasePersonality : MonoBehaviour {
	
	private string type;
	private string effectedStat;
	private int amountChanged;

	public string Type { get; set; }
	public string EffectedStat { get; set; }
	public int AmountChanged { get; set; }

	void Awake() {
		this.Type = "Personality";
		this.EffectedStat = "Stat";
		this.AmountChanged = 1;
	}
}
