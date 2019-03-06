using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DelateChara : MonoBehaviour {
public GameObject Chara;
public GameObject Panel;

	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update() {
		//もしパネルが非表示になったらキャラを消して弾幕を始めたい
		//if (Panel.SetActive(false));
		//{
		//	Destroy(Chara);
		//}
	}
}
