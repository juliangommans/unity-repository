using UnityEngine;
using System.Collections;

public class ShieldingPassive : BasePassive {

	public ShieldingPassive (){
		Type = "Shielding";
		Tree = "Defensive";
		Description = "Increses the characters shield by 20%";
	}

	public override void PassiveAction (BaseCharacter player){
		player.Shield = (int)(player.BaseShield * 1.2f);
	}
}
