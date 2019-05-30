using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wavesystem : MonoBehaviour {
	public float time;

	public GameObject gameobject;

	// Use this for initialization
	void Start () {
		Destroy(gameobject, time);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
