using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeP : MonoBehaviour {

	public int shift = 0;
	public int count = 0;

	void Update () {
		if (Input.GetKeyDown(KeyCode.RightShift)) {
			count++;
		}
		if (count != 0 && shift == count) {
			Debug.Log("ToBlack");
			SceneManager.LoadScene("Prologue_2"); 
		}
	}
}
