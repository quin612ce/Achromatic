using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Encount : MonoBehaviour {

public GameObject Randombullet;

public string nextSceneName;

public float genetime;


		Vector3 genepoint;

void changeNext(){
	if (Time.timeSinceLevelLoad > 10.0f) {
            SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
        }
    }


	// Use this for initialization
	void Start () {
			StartCoroutine (Update_1());
	}
	
	// Update is called once per frame
	IEnumerator Update_1 () {

		while(true){
			genepoint = new Vector3(Random.Range(-5, 5), 6, 0);
		Instantiate(Randombullet, genepoint, Quaternion.identity);
			yield return new WaitForSeconds (genetime);
			if (Time.timeSinceLevelLoad > 10.0f) {
            SceneManager.LoadScene (nextSceneName, LoadSceneMode.Single);
			}
		}
	}
}