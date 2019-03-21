using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SceneChange2 : MonoBehaviour {

	public int ChangeCount = 0;
	public int GetChangeCount(){
    return ChangeCount;
}

    void OnCollisionEnter2D(Collision2D oth)
    {
        if (oth.transform.tag == "trap")
        {
			Debug.Log("scenechange?");
			ChangeCount += 1;
        }
    }
}
