using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endtutorial : MonoBehaviour {

	public string nextSceneName;

	public float FinishSecond;

void changeNext(){
	if (Time.timeSinceLevelLoad > FinishSecond) {
		SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
	}
}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	if (Time.timeSinceLevelLoad > FinishSecond){
		SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
	}
	}
}