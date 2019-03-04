using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt : MonoBehaviour {

	private GameObject target;

	// Use this for initialization
	void Start () {
		target = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		this.gameObject.transform.LookAt (target.transform.position);
	}
}
