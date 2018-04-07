﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjFactory : MonoBehaviour {

	[SerializeField]
	private float interval = 3f;
	[SerializeField]
	private GameObject obj;
	private float timer;

	private void Awake() {
		this.ClearTime ();
	}
	
	private void Update () {
		this.timer -= Time.deltaTime;
		if (this.TimeTarget()) {
			this.BuildNewObj ();
			this.ClearTime ();
		}
	}

	private void BuildNewObj() {
		GameObject.Instantiate (this.obj, this.transform.position, Quaternion.identity);
	}

	private void ClearTime() {
		this.timer = this.interval;
	}

	private bool TimeTarget() {
		return this.timer <= 0;
	}

}
