using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange1_second : MonoBehaviour {

	Talk Talk;

    void Start () {
        Talk = GetComponent<Talk> ();
    }

    void Update () {
		if (Talk.searchtalkend == 1) 
        {
            Debug.Log("trueからシーン遷移");
            SceneManager.LoadScene("Stage1-Y");
        }
    }
}
