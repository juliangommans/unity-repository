using UnityEngine;
using System.Collections;

public class AggressivePersonality : BasePersonality {

	public AggressivePersonality(){
		Type = "Aggressive";
		PrimaryEffectedStat = "Retaliations";
		SecondaryEffectedStat = "RetaliationDamage";
	}
}
