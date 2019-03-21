using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackGroundScript : MonoBehaviour {

[SerializeField]
	private GameObject backGroundPrefab1;
	private GameObject backGroundInstance;

	void Start () {
		Debug.Log(PlayerPrefs.GetString("reScene",""));
		if(PlayerPrefs.GetString("reScene","") == "PlayMap1"){
			backGroundInstance = GameObject.Instantiate(backGroundPrefab1) as GameObject;
		}
	}
}
