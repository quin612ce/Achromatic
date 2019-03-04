using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Uzumaki : MonoBehaviour {
	public GameObject bullet;

	// Use this for initialization
	void Start () {
		StartCoroutine (Update_coroutine());
	}
	
	// Update is called once per frame
	IEnumerator Update_coroutine() 
	{
		int rad = 0;
		{
			while(true)
			{
				Instantiate (bullet, this.transform.position, Quaternion.Euler (this.transform.rotation.eulerAngles+ new Vector3(0, 0, rad)));
				rad += 8;
            yield return new WaitForSeconds(0.05f);
			}
		}
	}
}
