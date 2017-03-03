﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotatetowards : MonoBehaviour {

	public Transform target;
	public float speed;

	void Update() {
		Vector3 targetDir = target.position - transform.position;
		float step = speed * Time.deltaTime;
		Vector3 newDir = Vector3.RotateTowards (transform.forward, targetDir, step, 0.0F);
		Debug.DrawRay (transform.position, newDir, Color.blue);
		transform.rotation = Quaternion.LookRotation (newDir);
	}



}
