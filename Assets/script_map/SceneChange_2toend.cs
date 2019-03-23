using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SceneChange_2toend : MonoBehaviour {

	public int count = 0;
	public GameObject Panel;

    void Update () {
		if (Input.GetKeyDown(KeyCode.Return)) {
			count += 1;
		}
		if (count == 26) 
        {
            //Panel.SetActive(false);
			Debug.Log("ToEnd");
            SceneManager.LoadScene("end");
        }
    }
}