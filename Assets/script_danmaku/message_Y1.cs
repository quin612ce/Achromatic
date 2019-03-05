using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class message_Y1 : MonoBehaviour {

public GameObject Message;
	float TimeCount　= 3;
	
	void Update () {
		TimeCount -= Time.deltaTime;
		if(TimeCount <= 0)
		{
			Message.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
	}
}