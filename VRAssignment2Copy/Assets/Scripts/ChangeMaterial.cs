using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeMaterial: MonoBehaviour {
	public List<Material> materials = new List<Material>();

	public void NextMaterial() {
		this.GetComponent<MeshRenderer>().material = materials[1];
	}

	public void PreviousMaterial() {
		this.GetComponent<MeshRenderer>().material = materials[0];
	}
}