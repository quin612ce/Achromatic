using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour {

GameObject Playerhp;
Player hpcomp;
Slider slider;
private int hp;

	// Use this for initialization
	void Start () {
		Playerhp = GameObject.Find("Player");
		hpcomp = Playerhp.GetComponent<Player>();
		Debug.Log("true");
		slider = GameObject.Find("Slider").GetComponent<Slider>();
		hp = 10;
		slider.value = hp;
	}
	// Update is called once per frame
	void Update () {
		int Pyhp = hpcomp.hp;
		slider.value = Pyhp;
	}
}
