using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTV : UseItemOnThis {
	public GameObject tvScreen, cables;

	public override void DoesntWork() {

	}

	public override void FirstUnlockInstance() {
		if(cables.activeSelf) {
			tvScreen.SetActive(true);
			SetItemAsUsed();
		}
	}

	public override void SubsequentActivation_IfAny() {

	}
}