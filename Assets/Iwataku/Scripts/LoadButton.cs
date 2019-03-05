using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadButton : MonoBehaviour {

	public void OnClick () {
		SceneManager.LoadScene(PlayerPrefs.GetString("reScene",""));
	}
}
