using UnityEngine;
using System.Collections;

public class FocusedPersonality : BasePersonality {

	public FocusedPersonality(){
		Type = "Focused";
		PrimaryEffectedStat = "Resilience"; // Debuffs last less long
	}
}
