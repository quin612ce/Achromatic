using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange2todanmaku : MonoBehaviour {

	public int count = 0;
	public GameObject Panel;

    void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			count += 1;
		}
		if (count == 17) 
        {
            Panel.SetActive(false);
			Debug.Log("Todanmaku2");
            SceneManager.LoadScene("Stage-O1");
        }
    }
}
