using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtutorial : MonoBehaviour {

	public string nextSceneName;

	public GameObject Chara;

	public float TimeCount;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Chara.activeSelf){
			TimeCount++;
		}
		if (TimeCount == 20.0f)
		{
			SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
		}
	}
}
