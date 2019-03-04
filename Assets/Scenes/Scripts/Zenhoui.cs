using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zenhoui : MonoBehaviour {
	public GameObject bullet;

	//Use this for initialization
	void Start () {
		StartCoroutine (Update_coroutine());
	}

	IEnumerator Update_coroutine()
	{
		int count = 0;
		while (true)
		{
			for (int rad = 0; rad < 360; rad += 8)
			{
				Instantiate (bullet, this.transform.position, Quaternion.Euler (this.transform.rotation.eulerAngles+ new Vector3(0, 0, rad)));
			}
			yield return new WaitForSeconds (3.0f);
			count++;
			Debug.Log ("unchi");
		}
	}
}
