using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ChangeColor : MonoBehaviour {
	public int num1, num2, num3, num4, num5, num6, num7,num8, num9, num10  = 0;
	public int count = 0;
	float red, green, blue;
	public GameObject panel;

	// Use this for initialization
	void Start () {
        red = GetComponent<Image>().color.r;
        green = GetComponent<Image>().color.g;
        blue = GetComponent<Image>().color.b;
    }
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			count += 1;
		}
		if (count == num1 || count == num2 || count == num3 || count == num4 || count == num5 || count == num6 ||count == num7 || count == num8 || count == num9 || count == num10) {
			GetComponent<Image>().color = new Color(red, green, blue);
			red = 160;
			green = 235;
			blue = 100;
		}
	}
}
