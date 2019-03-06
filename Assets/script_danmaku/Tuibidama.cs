using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tuibidama : MonoBehaviour {

	private GameObject player;
	public int speed = 10;
	public float lifeTime = 10;
	public int power = 1;

	public int limit;
	int count;


	// Use this for initialization
	void Start () {
		player = GameObject.Find ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if(count <= limit){
		GetComponent<Rigidbody2D>().velocity = (player.transform.position - this.transform.position).normalized * speed;
		}
		count++;
	}
}
