using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitleButton : MonoBehaviour {

	public GameObject PL;
	public float reposX,reposY;
	public string currentScene;

	public void OnClick () {
		PL = GameObject.Find("PlayerAnime");
		reposX = PL.transform.position.x;
		reposY = PL.transform.position.y;
		PlayerPrefs.SetFloat("reposX",reposX);
		PlayerPrefs.SetFloat("reposY",reposY);
		PlayerPrefs.SetString("reScene",SceneManager.GetActiveScene().name);
		PlayerPrefs.Save();

		SceneManager.LoadScene("Title");
		Time.timeScale = 1f;
	}
}
