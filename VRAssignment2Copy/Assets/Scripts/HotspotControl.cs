using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HotspotControl : MonoBehaviour {
	public void OnEnable() {
		this.gameObject.SetActive(true);
	}

	public void OnDisable() {
		this.gameObject.SetActive(false);
	}
}