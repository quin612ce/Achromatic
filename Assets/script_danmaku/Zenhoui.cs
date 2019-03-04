using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Zenhoui : MonoBehaviour {
	public GameObject bullet;
	//private GameObject target;
//public float GetAim()
  //  {
    //    float dx = target.transform.x - transform.position.x;
      //  float dy = target.transform.y - transform.position.y;
        //return Mathf.Atan2(dy, dx) * Mathf.Rad2Deg;
    //}

	//Use  */this for initialization
	void Start () {
		//target = GameObject.Find ("Player");
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
