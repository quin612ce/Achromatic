using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BackTitle : MonoBehaviour {

public string nextSceneName;

	public void OnClick () {
        PlayerPrefs.DeleteAll();
        SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
    }
}