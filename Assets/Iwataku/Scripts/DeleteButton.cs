using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeleteButton : MonoBehaviour {

	public void OnClick () {
		PlayerPrefs.DeleteAll();
		Destroy(GameObject.Find("BackGround1(Clone)"));
	}
}
