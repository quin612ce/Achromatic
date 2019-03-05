using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelateChara : MonoBehaviour {
public GameObject Control;
public GameObject Chara;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {
		if (Control.GetComponent<TextController_Y1>().count >= Control.GetComponent<TextController_Y1>().shift){
			Destroy(Chara);
		}
	}
}
