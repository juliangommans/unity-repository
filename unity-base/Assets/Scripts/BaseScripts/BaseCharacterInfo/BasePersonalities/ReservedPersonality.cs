using UnityEngine;
using System.Collections;

public class ReservedPersonality : BasePersonality {

	public ReservedPersonality(){
		Type = "Reserved";
		PrimaryEffectedStat = "EnergyShield";
		PrimaryAmountChanged = 5;
	}
}
