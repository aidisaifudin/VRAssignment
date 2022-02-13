using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TapeCables : UseItemOnThis {
	public GameObject brokenCables;
	public GameObject tapedCables;
	public Collider brokenCablesCollider;
	public AudioSource audio;
	public AudioClip clip;

	public override void DoesntWork() {

	}

	public override void FirstUnlockInstance() {
		brokenCables.SetActive(false);
		tapedCables.SetActive(true);
		brokenCablesCollider.enabled = false;
		audio.PlayOneShot(clip);

		SetItemAsUsed(); // this method must be added after usage
	}

	public override void SubsequentActivation_IfAny() {

	}
}