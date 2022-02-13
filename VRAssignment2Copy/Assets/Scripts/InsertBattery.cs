using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InsertBattery : UseItemOnThis {
	public override void DoesntWork() {

	}

	public override void FirstUnlockInstance() {
		this.gameObject.AddComponent<CollectItem>();
		SetItemAsUsed();
		Destroy(this);
	}

	public override void SubsequentActivation_IfAny() {

	}
}