using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowCables : UseItemOnThis
{
	public GameObject brokenCables;
	public Collider cablesCollider;
	public AudioSource audio;
	public AudioClip clip;

	public override void DoesntWork() {
	   
	}

	public override void FirstUnlockInstance() {
		brokenCables.SetActive(true);
		cablesCollider.enabled = false;
		audio.PlayOneShot(clip);

		SetItemAsUsed(); // must be called everytime after use
	}

	public override void SubsequentActivation_IfAny() {

	}
}