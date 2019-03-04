using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aiming : MonoBehaviour {

	private GameObject player;
	private GameObject enemy; 

	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
		enemy = GameObject.Find ("Enemy1");
	}
	
	// Update is called once per frame
	void Update () {
		var vec = (player.transform.position - enemy.transform.position).normalized;
		var angle = (Mathf.Atan2 (vec.y, vec.x) * Mathf.Rad2Deg) - 90.0f;
		enemy.transform.rotation = Quaternion.Euler (0.0f, 0.0f, angle);
	}
}
