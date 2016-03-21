using UnityEngine;
using System.Collections;

public class BasePersonality : MonoBehaviour {
	
	private string type;
	private string primaryEffectedStat;
	private string secondaryEffectedStat;
	private int primaryAmountChanged;
	private int secondaryAmountChanged;

	public string Type { get; set; }
	public string PrimaryEffectedStat { get; set; }
	public string SecondaryEffectedStat { get; set; }
	public int PrimaryAmountChanged { get; set; }
	public int SecondaryAmountChanged { get; set; }

	public BasePersonality() {
		Type = null;
		PrimaryEffectedStat = null;
		SecondaryEffectedStat = null;
		PrimaryAmountChanged = 1;
		SecondaryAmountChanged = 5;
	}
		
}
