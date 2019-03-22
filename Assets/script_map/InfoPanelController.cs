using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoPanelController : MonoBehaviour {
	public GameObject Panel;
	public GameObject PL;
	public float reposX,reposY;

	void Update () {
		PL = GameObject.Find("PlayerAnime");
		reposX = PL.transform.position.x;
		reposY = PL.transform.position.y;
		if (reposX >= -21 && reposX <= -3 && reposY >= -8 && reposY <= -1) {
			Panel.SetActive(true);
		}
		else if (reposX >= 24 && reposX <= 36 && reposY >= 2 && reposY <= 17) {
			Panel.SetActive(true);
		}
		else {
			Panel.SetActive(false);
		}
	}
}
