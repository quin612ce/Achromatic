using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour {

	public void OnClick () {
		if(PlayerPrefs.HasKey("reScene") != false){
			SceneManager.LoadScene(PlayerPrefs.GetString("reScene",""));
		}else{
			Debug.Log("Nothing!");
		}
	}
}
