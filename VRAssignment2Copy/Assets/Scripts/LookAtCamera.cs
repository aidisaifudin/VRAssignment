﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCamera : MonoBehaviour {
	public Camera mainCamera;

	void Update() {
		this.transform.LookAt(mainCamera.transform);
	}
}