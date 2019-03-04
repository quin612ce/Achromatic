using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChangeP1 : MonoBehaviour {

	float TimeCount　= 3;
	
	void Update () {
		TimeCount -= Time.deltaTime;
		if(TimeCount <= 0)
		{
			Debug.Log("ToPlay");
			SceneManager.LoadScene("PlayMap1"); 
		}
	}
}